using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager 
{
    // collection of ingredients we have 
    Game.Models.IngredientMeta[] allIngredients;

    public void PrepareIngredients(Game.Models.IngredientMeta[] ingredients){
        allIngredients = ingredients;
    }

    // collection of clients we have 
    Game.Models.ClientMeta[] allClients;

    public void PrepareClients(Game.Models.ClientMeta[] clients){
        allClients = clients;

    }

    // collection of all pizzaz we have 

   Game.Models.PizzaMeta[] allPizzas;

   Dictionary<int, List<Game.Models.PizzaMeta>> pizzasByComplexity;

   public void PreparePizzas(Game.Models.PizzaMeta[] pizzas){
      allPizzas = pizzas;

      DistributePizzas();
   }


    // divide in diff lists pizzas by their complexities     
    void DistributePizzas(){

        // Debug.Log("DistributePizzas ");

        pizzasByComplexity = new Dictionary<int, List<Game.Models.PizzaMeta>>();

        for (int i=0; i<allPizzas.Length; i++){

            // Debug.Log("pizza cpx " + allPizzas[i].assetName + " " + allPizzas[i].complexity);

            if (! pizzasByComplexity.ContainsKey(allPizzas[i].complexity))
                pizzasByComplexity.Add(allPizzas[i].complexity, new List<Game.Models.PizzaMeta>());

            pizzasByComplexity[allPizzas[i].complexity].Add(allPizzas[i]);
        }

        // foreach(var el in pizzasByComplexity){
        //     for(int i=0; i<el.Value.Count; i++){
        //         Debug.Log("key " + el.Key + " / value = " + el.Value[i].assetName);
        //     }
        // }
    }

    public Game.Models.IngredientMeta[] GetIngredients(){
        return allIngredients;
    }

    public Game.Models.PizzaMeta[] GetPizzas(){
        return allPizzas;
    }

    public Game.Models.ClientMeta[] GetClients(){
        return allClients;
    }

    // get random pizza from specific complexity 
    public Game.Models.PizzaMeta GetRandomPizza(int pizzaComplexity){

        Debug.Log("GetRandomPizza " + pizzaComplexity);

        if (pizzasByComplexity.ContainsKey(pizzaComplexity)){
            int ranIdx = UnityEngine.Random.Range(0, pizzasByComplexity[pizzaComplexity].Count);
            return pizzasByComplexity[pizzaComplexity][ranIdx];
        }
        else{
            return null;
        }
    }


   // TODO randmozie clients for curr session 
}
