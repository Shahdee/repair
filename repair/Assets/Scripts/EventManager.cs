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


    public static UnityAction<float> onPlayerScoreChangeCallback;

    public static void AddPlayerScoreChangeListener(UnityAction<float> listener){
        onPlayerScoreChangeCallback += listener;
    }

    public static void OnPlayerScoreChange(float score){
        if (onPlayerScoreChangeCallback != null)
            onPlayerScoreChangeCallback(score);
    }

    public static UnityAction<float> onTimerChangeCallback;

    public static void AddTimerChangeListener(UnityAction<float> listener){
        onTimerChangeCallback += listener;
    }

    // normialized 
    public static void OnTimerChange(float score){
        if (onTimerChangeCallback != null)
            onTimerChangeCallback(score);
    }
}
