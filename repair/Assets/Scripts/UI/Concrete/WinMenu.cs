using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinMenu : WinViewBase
{
    public CommonButton btnPlay;

    protected override WinControllerBase CreateController(){
        return new WinMenuController(this);
    }

    protected override void InInit(){

        btnPlay.OnBtnClickAddListener(PlayClick);
        
    }

    void PlayClick(){
        (m_Controller as WinMenuController).SendPlay();
    }
}
