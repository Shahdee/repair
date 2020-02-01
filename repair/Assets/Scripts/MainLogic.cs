
using UnityEngine;
using UnityEngine.Events;

public class MainLogic : MonoBehaviour
{
    public GUILogic guiLogic;
    public EntityManager entityManager;
    public InputManager inputManager;
    public LevelManager levelManager;
    Player player;

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

    public InputManager GetInputManager(){
        return inputManager;
    }

    public LevelManager GetlevelManager(){
        return levelManager;
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

        levelManager = new LevelManager();

        

        // inputManager.Init();
        // m_Level.Init();
        // entityManager.Init();
        // guiLogic.Init();

        // m_levelManager.AddGameStartListener(GameStarted);
        // m_levelManager.AddLevelStartListener(LevelStarted);
        // m_levelManager.AddLevelEndListener(LevelEnded);

        OnDataLoaded();
    }

    void OnDataLoaded(){
        // init pizza manager 
        // init ingredient manager 
    }

#region Level events 
    void GameStarted(int level){
        SetGameState(GameStates.Play);
    }

    void LevelStarted(int level){
        SetGameState(GameStates.Play);
    }

    void LevelEnded(){
        SetGameState(GameStates.Over);
    }
#endregion

    // public void StartGame(){
    //     m_levelManager.StartGame(0);
    // }

    // public void RestartLevel(){
    //     m_levelManager.RestartCurrLevel();
    // }

    // public void MoveNext(){
    //     m_levelManager.MoveNext(); 
    // }

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
