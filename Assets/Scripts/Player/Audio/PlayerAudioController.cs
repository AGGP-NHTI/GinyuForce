using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : AudioController
{
    [SerializeField]
    protected AudioSource _playerSFX;
    
    /// <summary>
    /// The audio source for the player's secondary sound effects.
    /// </summary>
    public AudioSource PlayerSFX
    {
        get { return _playerSFX; }
    }

    [SerializeField]
    protected PlayerClipContainer _playerClips;

    public PlayerClipContainer PlayerClips
    {
        get { return _playerClips; }
    }
}
