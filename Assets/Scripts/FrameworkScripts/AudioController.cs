using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioController : Core
{
    protected AudioClipContainer _clips;

    public AudioClipContainer Clips
    {
        get { return _clips; }
    }

    protected AudioSource audioOutput;

    protected virtual void Awake()
    {
        _clips = GetComponent<AudioClipContainer>();

        audioOutput = GetComponent<AudioSource>();

        if (!_clips)
        {
            LogMsg("Missing clip container on audio controller. Audio will not play.");
        }
    }

    public void PlayAudioClip(AudioClip clip)
    {
        if (_clips && clip)
        {
            audioOutput.clip = clip;
            audioOutput.Play();
        }
    }
}
