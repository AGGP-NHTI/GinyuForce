using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlungeHitbox : PlayerSwordHitbox
{
    protected override void Update()
    {
        base.Update();
        if (player.MainStateMachine.CurrentMoveState is PlayerMState_OnGround || player.MainStateMachine.CurrentConditionState is PlayerCState_Dying)
        {
            Destroy(gameObject);
        }
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        Actor otherActor = collision.GetComponent<Actor>();

        if (otherActor)
        {
            otherActor.TakeDamage(this, damageValue, Owner, thisDamageInfo);

            Vector2 vel = new Vector2(player.GetVelocity().x, 0f);

            player.PawnRB_SetVelocity(vel);

            player.MainStateMachine.ChangeMoveState<PlayerMState_Idle>();

            player.MainStateMachine.CurrentMoveState.PlayerJump(10);
        }
    }
}
