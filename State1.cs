using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State1 : State
{
    public State1() : base()
    {
    }
    public override bool ShowMenu() {
        return true;
    }

    public override bool ShowHint() {
        return false;
    }

    public override string HintText() {
        string x = " ";
        return x;
    }
}