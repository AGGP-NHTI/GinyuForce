using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlungeHitbox : PlayerSwordHitbox
{
    private float damageScaling = 0f;

    [SerializeField]
    private float damageScaleAmount = 3.5f;

    protected override void Update()
    {
        base.Update();
        if (player.MainStateMachine.CurrentMoveState is PlayerMState_OnGround || !(player.MainStateMachine.CurrentConditionState is PlayerCState_Alive))
        {
            Destroy(gameObject);
        }
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        Actor otherActor = collision.GetComponentInParent<Actor>();

        if (otherActor)
        {
            otherActor.TakeDamage(this, damageValue + damageScaling, Owner, thisDamageInfo);

            if (otherActor is DamageHitbox)
            {
                DamageHitbox hitBox = (DamageHitbox)otherActor;                

                if(hitBox.mainActor is BossPawn)
                {
                    damageScaling += damageScaleAmount;

                    Vector2 vel = new Vector2(player.GetVelocity().x, 0f);

                    player.PawnRB_SetVelocity(vel);

                    player.MainStateMachine.ChangeMoveState<PlayerMState_Idle>();

                    player.MainStateMachine.CurrentMoveState.PlayerJump(10);
                }
            }
        }
    }
}
