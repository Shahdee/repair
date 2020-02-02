using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 

public class Pizza 
{
    static int SLICES = 3;

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

    static float xRange = 5f;
    static float yRange = 6f;
    static Vector3 tmpPosition;
    static Vector3 tmpScale;

    void SetupIngredients(){

        // TODO reuse what is left 
        ingredients = new List<Ingredient>();

        Game.Models.IngredientMeta imeta = null;
        Ingredient ingredient = null;

        // TODO mult by 3 slices! 

        for (int i=0; i<pizzaMeta.ingredientSet.Length; i++){

            imeta = MainLogic.GetMainLogic().GetItemManager().GetIngredient(pizzaMeta.ingredientSet[i]);

            for (int j=0; j<SLICES; j++){                                       
                ingredient = new Ingredient();
                ingredient.Setup(imeta);
                ingredients.Add(ingredient);

                var ingVis = ingredient.GetVisual();

                ingVis.transform.SetParent(pizzaVisual.ingredientParent, false);
                // ingVis.transform.position = Vector3.zero;

                float ranX = UnityEngine.Random.Range(-xRange, xRange);
                float rany = UnityEngine.Random.Range(-yRange, yRange);

                tmpPosition.x = ranX;
                tmpPosition.y = rany;
                tmpPosition.z = 0;

                // Debug.Log(" >1> tmpPosition " + tmpPosition);

                ingVis.transform.localPosition = tmpPosition;

                // Debug.Log(" >2> ingVis.transform.position " + ingVis.transform.position);

                tmpScale.x = imeta.scale;
                tmpScale.y = imeta.scale;
                tmpScale.z = imeta.scale;
                ingVis.transform.localScale = tmpScale;
            }

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
