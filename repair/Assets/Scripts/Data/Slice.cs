using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slice : MonoBehaviour
{
    // collider - triangle 
    public Collider2D collider2d;

    List<GameObject> touchingObjects;

    void Awake(){
        touchingObjects = new List<GameObject>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(" enter slice" + col.name);
       
    }

    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log(" exit slice" + col.name);
       
    }

    // void OnTriggerStay2D(Collider2D col)
    // {
        
    //     Debug.Log(" stay slice" + col.name);
    // }
}
