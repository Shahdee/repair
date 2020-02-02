using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Models;

[System.Serializable]
public class GameData 
{
    // clients    
    // pizzaz 
    // ingredients 

    public Game.Models.ClientMeta[] clients;

    public Game.Models.PizzaMeta[] pizzas;

    public Game.Models.IngredientMeta[] ingredients;

    public Game.Models.IngredientMeta[] garbage;

}
