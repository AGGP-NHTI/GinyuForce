﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClipContainer : AudioClipContainer
{
    [SerializeField]
    protected AudioClip[] _damageClips;

    [SerializeField]
    protected AudioClip _playerJump;

    [SerializeField]
    protected AudioClip _deathClip;

    public AudioClip DamageClip
    {
        get { return _damageClips[Random.Range(0, _damageClips.Length)]; }
    }

    public AudioClip JumpClip
    {
        get { return _playerJump; }
    }

    public AudioClip DeathClip
    {
        get { return _deathClip; }
    }
}
