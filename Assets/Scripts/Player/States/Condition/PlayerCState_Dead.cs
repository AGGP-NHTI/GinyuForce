using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCState_Dead : PlayerCState
{
    public override void EnterState()
    {
        base.EnterState();
        LogMsg("The player is now dead.");
        // Switch to the "dead" sprite.
    }
}
