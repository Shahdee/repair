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

      GameObject gobject = MainLogic.GetMainLogic().GetEntityManager().GetEntity(ingredientMeta.assetName);
      
      gobject.SetActive(true);     

      ingredientVisual = gobject.GetComponent<IngredientVisual>();

      //TODO subscribe to events 

   }

   public void Reset(){
      // TODO unsubscribe from events 
      // return to pool 

      if (ingredientVisual != null){
         MainLogic.GetMainLogic().GetEntityManager().ReturnEntity(ingredientVisual.gameObject);
         ingredientVisual = null;
      }
   } 
   
}
