using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class State2 : State
{
    public override bool ShowMenu() {
        return false;
    }

    public override bool ShowHint() {
        return true;
    }

    public override string HintText() {
        string x = "Take drill";
        return x;
    }
}