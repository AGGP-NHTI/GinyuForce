using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : Core
{
    /// <summary>
    /// Boolean value. Determines how damage will be processed by this actor. Default value is false.
    /// </summary>
    public bool TakesDamage = false;

    /// <summary>
    /// The name of the actor.
    /// </summary>
    private string _actorName = "ActorName_Default";

    /// <summary>
    /// Gets name of the actor as a string.
    /// </summary>
    /// <returns></returns>
    public string ActorName
    {
        get { return _actorName; }
        set { _actorName = value; }
    }
    
    /// <summary>
    /// If true, upon Actor initialization will set Actor Name to the name of the parent game object.
    /// </summary>
    [SerializeField]
    private bool GetsActorNameFromCore = true;

    // TODO !!![Put controller here]!!!

    // TODO !!![Put take/process damage here]!!!
}
