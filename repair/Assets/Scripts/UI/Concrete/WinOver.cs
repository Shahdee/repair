using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOver : WinViewBase
{
    public CommonButton btnRestart;

    protected override WinControllerBase CreateController(){
        return new WinOverController(this);;
    }

    protected override void InInit(){

        btnRestart.OnBtnClickAddListener(PlayClick);
        
    }

    void PlayClick(){
        (m_Controller as WinOverController).SendRestart();
    }
}
