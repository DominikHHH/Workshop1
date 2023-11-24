using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdle : PlayerState
{
    public override void StartState()
    {
        Debug.Log("Player is idle! Yay!");
    }

    public override void UpdateState()
    {
        
    }

    public override void ExitState()
    {
        
    }
}
