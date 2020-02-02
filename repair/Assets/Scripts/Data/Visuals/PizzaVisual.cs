using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaVisual : ReusableObject
{
    // collider - square collider of a box size 
    // slices                                                                             
    // ingredients 
    // back image 

    public Transform ingredientParent;

    public Slice[] slices; // always 3 

    void Awake(){

    }

    void OnEnable(){

    }

    public override void ClearForBuffer(){
        for (int i=0; i<slices.Length; i++){
            slices[i].Clear();
        }
    }
}
