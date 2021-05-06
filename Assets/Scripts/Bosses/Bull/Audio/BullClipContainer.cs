﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullClipContainer : AudioClipContainer
{
    [SerializeField]
    protected AudioClip[] _damageClips;

    [SerializeField]
    protected AudioClip _bullWallCrash;

    public AudioClip DamageClip
    {
        get { return _damageClips[Random.Range(0, _damageClips.Length)]; }
    }

    public AudioClip WallCrashClip
    {
        get { return _bullWallCrash; }
    }
}
