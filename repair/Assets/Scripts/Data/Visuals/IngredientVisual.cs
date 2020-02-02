using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IngredientVisual : ReusableObject
{
    // collider 

    public Collider2D collider2d;

    List<GameObject> touchingObjects;


    // sound 
    [SerializeField]
    public SoundRandomContainer soundTake;
    [SerializeField]
    public SoundRandomContainer soundPut;

    // went to garbage 

    void Awake(){
        touchingObjects = new List<GameObject>();
    }

    void OnEnable(){

    }

    public UnityAction mouseUpCallback;

    public void AddMouseUpListener(UnityAction action){
        mouseUpCallback += action;
    }

    public void RemoveMouseUpListener(UnityAction action){
        mouseUpCallback -= action;
    }

    public UnityAction mouseDownCallback;

    public void AddMouseDownListener(UnityAction action){
        mouseDownCallback += action;
    }

    public void RemoveMouseDownListener(UnityAction action){
        mouseDownCallback -= action;
    }

    void ClearListeners(){
        mouseDownCallback = null;
        mouseUpCallback = null;
    }

    private void OnMouseDown() 
    {
        if (mouseDownCallback != null)
            mouseDownCallback();
    }

    private void OnMouseUp() 
    {
        if (mouseUpCallback != null)
            mouseUpCallback();
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

    public override void ClearForBuffer(){

        // touchingObjects
        // TODO 

        ClearListeners();

    }
}
