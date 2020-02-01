using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// manages all objects on level 

public class LevelManager : MonoBehaviour, IUpdatable
{

    // curr client 
    // curr pizza 
    // timer 
    // garbage collector 

    // hint 
    // wishes list 

    List<Client> clientOrder; // randomized list of clients for curr session 
    Client currClient;
    Pizza currPizza;
    Garbage garbage;


    public void StartLevel(){

    }

    void MoveToNextClient(){

    }


    public void UpdateMe(float deltaTime){
        // 
    }
    

    // start level 
        // assign client: ClientManager 
        // assign pizza : Client -> PizzaManager 
        // launch timer : get from clietn 


    // move to next client 
        // assign client 
        // assign pizza 
        // launch timer

    
    // timer is up 
        // move pizza from the screen 
        // calc pizza outcome 
        // change player scandal scale 

        // check 
         // win -> show win scnreen 
         // lost -> show over screen 
         // else -> mnove to next client 


    // update 
        // check timer 
        
}
