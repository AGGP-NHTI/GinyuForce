using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : AudioController
{
    protected PlayerClipContainer _playerClips;

    public PlayerClipContainer PlayerClips
    {
        get { return _playerClips; }
    }
}
