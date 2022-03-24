using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimulatorController
{
    private StateMachine stateMachine = new StateMachine();
    private Text hintText;
    private GameObject HintObject;
    private GameObject MenuObject;

    public void onStartMenuClick()
    {
        stateMachine.MoveToNextState(State1);
        updateUi();
    }

    public void onDrillTaken()
    {
        stateMachine.MoveToNextState(State2);
        updateUi();
    }

    public void onDrillDropped()
    {
        stateMachine.MoveToPrevState(State3);
        updateUi();
    }

    public void onHoseTaken()
    {
        stateMachine.MoveToNextState(State3);
        updateUi();
    }
    private void updateUi()
    {
        State currentState = stateMachine.currentState();
        MenuObject.SetActive(currentState.ShowMenu());
        HintObject.SetActive(currentState.ShowHint());
        hintText.text(currentState.HintText());
    }
}