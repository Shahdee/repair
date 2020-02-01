using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOver : WinViewBase
{
    protected override WinControllerBase CreateController(){
        return new WinOverController(this);;
    }
}
