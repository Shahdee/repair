using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Models{

    [System.Serializable]
    public class ClientMeta{      

        public string assetName;
        public int clientID;
        public int timer;
        public int pizzaComplexity;

        //


        // public string assetSoundName;
        // public int pizzaComplexity; // 1-3
        // public int scandalScaleCoeff;



        // asset name 
        // id 
        // timer        
        // sound name    
        // pizza complexity 
        // scandal scale coeff
    }

    [System.Serializable]
    public class PizzaMeta{

        public string assetName;
        public int pizzaId;
        public int complexity; // 1-3

        // public List<IngredientMeta> ;
        public int[] ingredientSet;
        public int garbageCount;

        // asset name
        // id 
        // belongs to complexity 

        // ingredients to mix (2-4), depends on complexity 
        // ingredients = garbage 

        // TODO discuss ? 
        // with N% decides if exlude happens 
            // ingredient id to exclude (1) with M% chance 
            
            // TODO include 
    }

    [System.Serializable]
    public class IngredientMeta{ 

        public string assetName;
        public int ingredientID;
        public string soundPut;
        public string soundTake;
        public float scale;

        // asset name 
        // type 
        // id 
        // sound name : drag & put 
    }


}
