using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine<T>
{
    private T owner;
    public State<T> CurrentState {get; private set;}

    public StateMachine(T owner)
    {
        this.owner = owner;
        CurrentState = null;
    }

    public void ChangeState(State<T> newState = null)
    {
        CurrentState?.Exit(owner);
        CurrentState = newState;
        CurrentState?.Enter(owner);
    }

    public void Update()
    {
        CurrentState?.Execute(owner);
    }
}
