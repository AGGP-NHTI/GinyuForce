using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullClipContainer : AudioClipContainer
{
    [SerializeField]
    protected AudioClip[] _damageClips;

    [SerializeField]
    protected AudioClip _bullWallCrash;

    [SerializeField]
    protected AudioClip _dashClip;

    [SerializeField]
    protected AudioClip _jumpClip;

    [SerializeField]
    protected AudioClip _singClip;

    public AudioClip DamageClip
    {
        get { return _damageClips[Random.Range(0, _damageClips.Length)]; }
    }

    public AudioClip WallCrashClip
    {
        get { return _bullWallCrash; }
    }

    public AudioClip DashClip
    {
        get { return _dashClip; }
    }

    public AudioClip JumpClip
    {
        get { return _jumpClip; }
    }

    public AudioClip SingClip
    {
        get { return _singClip; }
    }
}
