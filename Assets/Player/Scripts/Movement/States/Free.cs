using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Free : MovementState
{
    //Note to people that are copying this to make a new movement state:
    //You do not need to get the player object, a reference is already stored in the parent (type Player)
    //A reference to the RigidBody is also stored in the parent (type rb)
    //A reference to MovementResources is also already stored in the parent (type MoveRes)

    public override void OnStartup()
    {
        //do nothing
    }

    public override MoveState getMyState()
    {
        return MoveState.free;
    }

    public override bool EnterCondition()
    {
        return false;   //no way to manually enter this state
    }

    public override void OnEnter(MoveState previousState)
    {
        //do nothing
    }

    public override void WhileActive()
    {
        //enable awsd movement
    }

    public override bool ExitCondition()
    {
        return false;   //the state continues until overriden
    }

    public override MoveState OnExit()
    {
        //this method will never actually be called because ExitCondition always returns false
        return MoveState.free;
    }

    public override void OnOverriden()
    {
        //do nothing
    }

    public override void OnReset()
    {
        //do nothing
    }

}