using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullAudioController : AudioController
{
    protected BullClipContainer _bullClips;

    public BullClipContainer BullClips
    {
        get { return _bullClips; }
    }

    [SerializeField]
    protected AudioSource _bullSFX = null;

    /// <summary>
    /// Used for Bull's dashing/revving/etc noises, so that they can layer with him taking damage.
    /// </summary>
    public AudioSource BullSFX
    {
        get { return _bullSFX; }
    }

    protected override void Awake()
    {
        base.Awake();

        if(_clips is BullClipContainer)
        {
            _bullClips = (BullClipContainer)_clips;
        }
        else
        {
            LogMsg("Bull has an audio container but it does not have his audio clips in it. This WILL cause errors.");
        }
    }
}
