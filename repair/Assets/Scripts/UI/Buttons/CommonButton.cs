using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CommonButton : MonoBehaviour
{
    public ExtendedButton button;

    UnityAction onBtnClick;

    public void OnBtnClickAddListener(UnityAction listener){
        onBtnClick += listener;
    }

    void Awake(){
        button.onClick.AddListener(ButtonClick);
    }

    void ButtonClick(){

        if (onBtnClick != null)
            onBtnClick();

        SoundManager.GetSoundManager().PlayButtonPressedSound();

        // event 
        // TODO  play sound 
    }

}
