using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PoolledEntity{
    public GameObject prototype;
    public int amountToPool;
    public bool expandable = false;

}

public class EntityManager : MonoBehaviour
{
    // pool for diff objects

    public List<PoolledEntity> entitiesToPool;
    
    Transform trsPoolParent;
    List<GameObject> objectsInPool;
    
    void Awake(){
        trsPoolParent = transform;
        objectsInPool = new List<GameObject>();

        foreach(var entity in entitiesToPool){
            for (int i=0; i<entity.amountToPool; i++){
                AddEntityToPool(entity.prototype);            
            }
        }
    }

    GameObject AddEntityToPool(GameObject prototype){
        
        if (prototype == null) return null;

        var gobj = GameObject.Instantiate(prototype, Vector3.zero, Quaternion.identity);
        gobj.transform.SetParent(trsPoolParent);
        gobj.SetActive(false);
        objectsInPool.Add(gobj);

        return gobj;
    }

    public GameObject GetEntity(string name){

        Debug.Log("GetEntity " + name);

        for (int i=0; i<objectsInPool.Count; i++){
            if (!objectsInPool[i].activeInHierarchy && objectsInPool[i].name == name){
                return objectsInPool[i]; // this can be accessed by several classes, cause it's not activated here
            }                
        }

        foreach(var entity in entitiesToPool){
            if (entity.expandable){
                if (entity.prototype.name == name){
                    return AddEntityToPool(entity.prototype);
                }
            }
        }

        return null;
    }   

    public void ReturnEntity(GameObject obj){

        // Debug.Log("ReturnToPool " + obj);

        obj.transform.SetParent(trsPoolParent);
        obj.gameObject.SetActive(false);
    }
}
