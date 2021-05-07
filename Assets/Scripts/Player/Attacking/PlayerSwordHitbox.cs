using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwordHitbox : DamageHitbox
{
    protected PlayerPawn player;

    [SerializeField]
    protected AudioClip[] _swooshClips;

    [SerializeField]
    protected AudioSource audioSrc;

    protected virtual void Awake()
    {
        player = gameObject.GetComponentInParent<PlayerPawn>();
        audioSrc.clip = _swooshClips[Random.Range(0, _swooshClips.Length)];
        audioSrc.Play();
    }

    protected override void Update()
    {
        if(!(player.MainStateMachine.CurrentConditionState is PlayerCState_Alive)) { Destroy(gameObject); }
        base.Update();
    }
}
