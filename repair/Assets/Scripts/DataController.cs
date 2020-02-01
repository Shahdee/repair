using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Game.Models;

public class DataController 
{
    GameData gameData;

    static string gameDataFileName = "data.json";

    public DataController(){
        LoadGameData();
    }

    public GameData GetGameData(){
        return gameData;
    }

    void LoadGameData(){
        string filePath;
        string dataAsJson;
        
        filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName); 

        if (File.Exists(filePath)){
            dataAsJson = File.ReadAllText(filePath);

            Debug.Log(dataAsJson);
                    
            gameData = JsonUtility.FromJson<GameData>(dataAsJson);                
        }
        else{
            Debug.LogError("no game data file");
        }
    }
}
