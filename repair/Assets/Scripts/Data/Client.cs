using System.Collections;
using System.Collections.Generic;
using UnityEngine;

   // do clients randomize between sessions - YES     

public class Client 
{
    // meta 
    Game.Models.ClientMeta clientMeta;

    // visual 

    // sound 

    public void SetupClient(Game.Models.ClientMeta meta){
        clientMeta = meta;

    }

    public int GetPizzaComplexity(){
        return clientMeta.pizzaComplexity;
    }

    // setup client
        // get client from pool  

    public void Reset(){
        
    }

    // reset client
        // return client to pool 
}
