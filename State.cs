using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    public abstract bool ShowMenu();

    public abstract bool ShowHint();

    public abstract string HintText();
}