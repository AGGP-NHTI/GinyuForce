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
