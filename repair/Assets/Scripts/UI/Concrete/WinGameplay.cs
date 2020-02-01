using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGameplay : WinViewBase
{
    // progress bar 
    // client 
    
    // pizza hint 
    // pizza ingredients 


    protected override WinControllerBase CreateController(){
        return new WinGameplayController(this);;
    }
}
