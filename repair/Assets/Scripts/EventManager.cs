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
}
