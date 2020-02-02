
using UnityEngine;
using UnityEngine.Events;

public class MainLogic : MonoBehaviour
{
    public GUILogic guiLogic;
    public EntityManager entityManager;
    public InputManager inputManager;
    public LevelManager levelManager;
    public ItemManager itemManager;
    public SoundManager soundManager;
    Player player;
    DataController dataController;

    public enum GameStates{
        Menu,
        Play,
        Over,
    }

    GameStates currGameState = GameStates.Menu;

    void SetGameState(GameStates state){

        if (currGameState != state){
            currGameState = state;

            EventManager.OnGameStateChange(currGameState);
        }
    }
    
    public EntityManager GetEntityManager(){
        return entityManager;
    }

    // public InputManager GetInputManager(){
    //     return inputManager;
    // }

    public LevelManager GetlevelManager(){
        return levelManager;
    }

    public ItemManager GetItemManager(){
        return itemManager;
    }

    static MainLogic mainLogic;

    public static MainLogic GetMainLogic(){
        return mainLogic;
    }

    public Player GetPlayer(){
        return player;
    }

    void Start()
    {
        mainLogic = this; 

        itemManager = new ItemManager();
        dataController = new DataController();
        
        // inputManager.Init();

        EventManager.AddGameStartListener(GameStarted);
        EventManager.AddGameEndedListener(GameEnded);

        OnDataLoaded();

        guiLogic.Init();
    }

    void OnDataLoaded(){

        var gameData = dataController.GetGameData();

        itemManager.PrepareClients(gameData.clients);
        itemManager.PreparePizzas(gameData.pizzas);
        itemManager.PrepareIngredients(gameData.ingredients);       
        itemManager.PrepareGarbage(gameData.garbage);       
    }

#region Level events 
    void GameStarted(){

        SetGameState(GameStates.Play);
    }

    void GameEnded(){
        SetGameState(GameStates.Over);
    }
#endregion

    public void StartGame(){
        levelManager.StartLevel();
    }

    float deltaTime = 0;

    void FixedUpdate(){
        
    }

    void Update(){
        deltaTime = Time.deltaTime;

        UpdateState(deltaTime);
    }

    void UpdateState(float deltaTime){
        switch(currGameState){
            case GameStates.Menu:
                UpdateMenu(deltaTime);
            break;

            case GameStates.Play:
                UpdatePlay(deltaTime);
            break;

            case GameStates.Over:
                UpdateOver(deltaTime);
            break;
        }
    }

    void UpdateMenu(float deltaTime){

        guiLogic.UpdateMe(deltaTime);
    }

    void UpdatePlay(float deltaTime){

        // inputManager.UpdateMe(deltaTime);        
        levelManager.UpdateMe(deltaTime);       
        guiLogic.UpdateMe(deltaTime);
    }

    void UpdateOver(float deltaTime){

        guiLogic.UpdateMe(deltaTime);
    }
}
