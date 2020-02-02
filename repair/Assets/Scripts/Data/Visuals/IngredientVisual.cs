using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientVisual : ReusableObject
{
    // collider 

    public Collider2D collider2d;

    List<GameObject> touchingObjects;


    // sound 
    [SerializeField]
    private SoundRandomContainer soundTake;
    [SerializeField]
    private SoundRandomContainer soundPut;

    // went to garbage 

    void Awake(){
        touchingObjects = new List<GameObject>();
    }

    void OnEnable(){

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        // Debug.Log(" enter ingr " + col.name);

        


        // add toching 
        // touchingObjects
        // or 

        
        // put to garbage  
       
    }

    void OnTriggerExit2D(Collider2D col)
    {
        // Debug.Log(" exit ingr" + col.name);

        // remove toching 
        // touchingObjects
       
    }

    // void OnTriggerStay2D(Collider2D col)
    // {
        
    //     Debug.Log(" stay ingr" + col.name);
    // }

    public void Clear(){

        // touchingObjects
        // TODO 
    }
}
