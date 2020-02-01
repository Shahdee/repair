using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager 
{
    public static UnityAction<MainLogic.GameStates> onGameStateChangeCallback;
    public static void AddGameStateChangeListener(UnityAction<MainLogic.GameStates> listener){
        onGameStateChangeCallback += listener;
    }

    public static void RemoveGameStateChangeListener(UnityAction<MainLogic.GameStates> listener){
        onGameStateChangeCallback -= listener;
    }

    public static void OnGameStateChange(MainLogic.GameStates state){
        if (onGameStateChangeCallback != null)
            onGameStateChangeCallback(state);
    }


    public static UnityAction onGameStartCallback;

    public static void AddGameStartListener(UnityAction listener){
        onGameStartCallback += listener;
    }

    public static void OnGameStart(){
        if (onGameStartCallback != null)
            onGameStartCallback();
    }

    public static UnityAction onGameEndedCallback;

    public static void AddGameEndedListener(UnityAction listener){
        onGameEndedCallback += listener;
    }

    public static void OnGameEnded(){
        if (onGameEndedCallback != null)
            onGameEndedCallback();
    }


}
