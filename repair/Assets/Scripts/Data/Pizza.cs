using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 

public class Pizza 
{
    Game.Models.PizzaMeta pizzaMeta;
    // meta 

    // ingredients which can be dragged from pizza to garbage 
    PizzaVisual pizzaVisual;

    public PizzaVisual GetVisual(){
        return pizzaVisual;
    }
    
    // visual 
        // pizza picture 
        // ingredients 
        // wishes 
        // slice hint 


    // how do I compare ingredients when time is up? TODO ask

    
    // setuppizza 
        // get pizza from pool 
        // get ingredients to mix from pool 
        // calc ingredients to exclude 
    
    

    // resetpizza 
        // return pizza to pool 
        // return ingredients to pool 


    public void SetupPizza(Game.Models.PizzaMeta pMeta){

        Debug.Log("SetupPizza " + pMeta);

        pizzaMeta = pMeta;      

        GameObject gobject = MainLogic.GetMainLogic().GetEntityManager().GetEntity(pizzaMeta.assetName);
        gobject.SetActive(true);
        pizzaVisual = gobject.GetComponent<PizzaVisual>();
    }

    public void ResetPizza(){
        if ( pizzaVisual != null){
            MainLogic.GetMainLogic().GetEntityManager().ReturnEntity(pizzaVisual.gameObject);
            pizzaVisual = null;
        }       
    }
}
