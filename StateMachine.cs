using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    private State currentState;
    public State getCurrentState()
    {
        return currentState;
    }

    Dictionary<Type, State> allStates = new Dictionary<Type, State>(){
           {typeof(State1), new State1(this)},
           {typeof(State2), new State2(this)},
           {typeof(State3), new State3(this)},
           {typeof(State4), new State4(this)},
    };

    public StateMachine()
    {
        SetUpStates(allStates, typeof(State1));
    }

    public void SetUpStates(Dictionary<Type, State> states, Type defaultState)
    {
        allStates = states;
        currentState = allStates[defaultState];
    }

    private void MoveToNextState(State newState)
    {
        if (newState is State1)
        {
            currentState = State2;
        }
        else if (newState is State2)
        {
            currentState = State3;
        }
        else if (newState is State3)
        {
            currentState = State4;
        }
    }
    private void MoveToPrevState(State newState)
    {
        if (newState is State4)
        {
            currentState = State3;
        }
        else if (newState is State3)
        {
            currentState = State2;
        }
        else if (newState is State2)
        {
            currentState = State1;
        }
    }
}