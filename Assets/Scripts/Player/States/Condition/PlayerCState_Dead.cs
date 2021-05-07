using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCState_Dead : PlayerCState
{
    public override void EnterState()
    {
        base.EnterState();
        myStateMachine.ThePlayerPawn.PlayerAudioController.PlayerSFX.clip = myStateMachine.ThePlayerPawn.PlayerAudioController.PlayerClips.DeathClip;
        myStateMachine.ThePlayerPawn.PlayerAudioController.PlayerSFX.Play();
        GameInstanceManager.Main.GameOver();
        //LogMsg("The player is now dead.");
        // Switch to the "dead" sprite.
    }
}
