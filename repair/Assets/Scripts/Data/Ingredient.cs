using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient 
{
   Game.Models.IngredientMeta ingredientMeta;
   // meta 


   // visual 
   IngredientVisual ingredientVisual;

   public IngredientVisual GetVisual(){
      return ingredientVisual;
   }

   // sound 

   // can be dragged from pizza to garbage 

   public void Setup(Game.Models.IngredientMeta imeta){
      ingredientMeta = imeta;

      // subscribe to events 

   }

   public void Reset(){


      // unsubscribe from events 
      
      // return to pool 
   } 
   
}
