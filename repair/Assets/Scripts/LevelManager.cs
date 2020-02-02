using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// manages all objects on level 

    // curr client 
    // curr pizza 
    // pizza box
    // ticking timer 
    // garbage collector 
    // hint 
    // wishes list    
    // pizza parent

public class LevelManager : MonoBehaviour, IUpdatable
{
    public Transform pizzaParent;
    public CardboardBox box;
    public PizzaVisual pizzaVisual;

    public Garbage garbage;

    int currClientIndex = 0;
    
    Game.Models.ClientMeta[] clients;
    Client currClient;
    Pizza currPizza;

    float currTimeLeft = 0;
    float totalTime = 0;
    bool timerTicking = false;
    
    public Client GetClient(){
        return currClient;
    }

    public Pizza GetPizza(){
        return currPizza;
    }

    public CardboardBox GetCardboardBox(){
        return box;
    }

    void Awake(){
        currClient = new Client();
        currPizza = new Pizza(pizzaVisual);       
    }

    public void StartLevel(){

        // TODO mix clients 

        clients = MainLogic.GetMainLogic().GetItemManager().GetClients();

        currClientIndex = -1;

        MoveToNextClient();

        EventManager.OnGameStart();
    }

    void MoveToNextClient(){       

        currClientIndex++;

        Debug.Log("MoveToNextClient " + currClientIndex);

        // return object to pool 
        ResetObjects();

        Game.Models.ClientMeta cmeta = clients[currClientIndex];
        currClient.SetupClient(cmeta);

        // int cpx = currClient.GetPizzaComplexity();
        // Game.Models.PizzaMeta pMeta = MainLogic.GetMainLogic().GetItemManager().GetRandomPizza(cpx);

        Game.Models.PizzaMeta pMeta = MainLogic.GetMainLogic().GetItemManager().GetRandomPizza();
        currPizza.Setup(pMeta);

        // var visual = currPizza.GetVisual();
        // visual.transform.SetParent(pizzaParent);

        SetTimer(cmeta.timer);        
    }

    void SetTimer(int time){

        Debug.Log("SetTimer " + time);

        totalTime = time;
        currTimeLeft = time;
        timerTicking = true;

        SendTime();
    }

    public void UpdateMe(float deltaTime){
        // 

        UpdateTimer(deltaTime);
    }

    void UpdateTimer(float deltaTime){

        if (timerTicking){

            // Debug.Log("currTimeLeft " + currTimeLeft);

            if (currTimeLeft > 0){
                currTimeLeft -= deltaTime;

                SendTime();
            }
            else{
                timerTicking = false;

                SendTime();

                TimeIsUp();
            }
        }
    }

    void SendTime(){
        EventManager.OnTimerChange(currTimeLeft/totalTime);
    }

    void TimeIsUp(){
        // tmp 

        // EventManager.OnGameEnded();

        // if (currClientIndex == clients.Length -1 )
        //     EventManager.OnGameEnded();
        // else 
        //     MoveToNextClient();
    }

    // send to pool 
    void ResetObjects(){
        currClient.Reset();
        currPizza.Reset();
    }
    

    // start level 
        // assign client: ItemManager 
        // assign pizza : Client -> ItemManager 
        // launch timer : get from clietn 


    // move to next client 

        // return objects to pool 

        // assign client 
        // assign pizza 
        // launch timer

    
    // timer is up 
        // move pizza from the screen 
        // calc pizza outcome 
        // change player scandal scale 

        // check 
            // done
                // return objects to pool 
                // win -> show win scnreen 
                // lost -> show over screen 
         
            // else
                // move to next client 

    // update 
        // check timer 
        
}
