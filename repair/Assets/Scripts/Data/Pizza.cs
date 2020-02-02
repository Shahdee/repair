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

    // public PizzaVisual GetVisual(){
    //     return pizzaVisual;
    // }

    // ingredients 
    List<Ingredient> ingredients = new List<Ingredient>();
    
    // visual 
        // pizza picture 
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

    // TODO improve
    public Pizza(PizzaVisual visual){
        // 

        pizzaVisual = visual;
    }


    public void Setup(Game.Models.PizzaMeta pMeta){

        Debug.Log("SetupPizza " + pMeta);

        pizzaMeta = pMeta;      

        // GameObject gobject = MainLogic.GetMainLogic().GetEntityManager().GetEntity(pizzaMeta.assetName);
        // gobject.SetActive(true);
        // pizzaVisual = gobject.GetComponent<PizzaVisual>();

        SetupIngredients();
    }

    void SetupIngredients(){

        // TODO reuse what is left 
        ingredients = null;

        Game.Models.IngredientMeta imeta = null;
        Ingredient ingredient = null;

        // TODO mult by 3 slices! 

        for (int i=0; i<pizzaMeta.ingredients.Count; i++){

            imeta = MainLogic.GetMainLogic().GetItemManager().GetIngredient(pizzaMeta.ingredients[i]);

            ingredient = new Ingredient();
            ingredient.Setup(imeta);
            ingredients.Add(ingredient);

            // set parent
            // subscribe to events

        }

    }

    public void Reset(){
        // if (pizzaVisual != null){
        //     MainLogic.GetMainLogic().GetEntityManager().ReturnEntity(pizzaVisual.gameObject);
        //     pizzaVisual = null;
        // }       
        ResetIngredients();
    }

    void ResetIngredients(){

        // unsubscribe from ingredient events 

        for (int i=0; i<ingredients.Count; i++){
            ingredients[i].Reset();
        }

        // TODO reuse what is left 
        ingredients = null;
    }

    // pizza is subscribed to collider events 
    // if ingredient went to garbage => pool visual 


    // ? 
    // ingredient to garbage 
    // randomize ingredients on pizza 
    // attach ingredients to pizza
    
    // calc scores 
        // correlation between ingredients (visuals) left alive, and how do colliders touch each other 

}
