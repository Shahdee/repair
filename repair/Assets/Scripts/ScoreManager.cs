using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreManager 
{
     
    public static void CalcMinErrors(Pizza pizza){ 

        var meta = pizza.GetMeta();
        var ingredients = pizza.GetIngredients();
        var slices = pizza.GetVisual().slices;

        int errors = slices.Length * meta.ingredientSet.Length;

        bool key = false;

        for (int i=0; i<slices.Length; i++){

            for(int j=0; j<meta.ingredientSet.Length; j++){   

                if (key){
                    key = false;
                    break;
                }

                for (int k=0; k<ingredients.Count; i++){

                    // ingredientMeta = 

                    if (meta.ingredientSet[j] == ingredients[k].GetMeta().ingredientID){

                        if (ingredients[k].GetVisual() != null){ // we didn't trash it 

                            if (CheckSliceCollision(ingredients[k].GetVisual(), slices[i])){
                                errors --;
                                key = true;
                                break;
                            }
                        }
                    }
                }
            }
        } 
    }

    static bool CheckSliceCollision(IngredientVisual ivis, Slice slc){

        var objects = ivis.GetTouchingObjects();

        for (int i=0; i<objects.Count; i++){

            if (objects[i] == slc.gameObject)
                return true;
        }
        return false;
    }

 
    public static void CalcMisplace(Pizza pizza){


    } 

    public static int CalcGarbage(Pizza pizza){

        var garbage = pizza.GetGarbage();

        int gCounter = 0;

        for (int i=0; i<garbage.Count; i++){

            if (garbage[i].GetVisual() != null)
                gCounter++;
        }
        Debug.LogError("CalcGarbage "+ gCounter);
        return gCounter;
    } 
}
