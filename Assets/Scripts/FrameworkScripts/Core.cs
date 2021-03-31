using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base class that holds information all Actors should have access to. Based on the "Info" class from the AG131 example.
/// </summary>
public class Core : MonoBehaviour 
{
    /// <summary>
    /// Spawning function to instantiate new Actors or objects. Once again based on the "Info" class "factory" method.
    /// </summary>
    /// <returns></returns>
    public static GameObject Spawner(GameObject SpawnPrefab, Vector3 SpawnLocation, Quaternion SpawnRotation, Controller ObjectOwner = null)
    {
        GameObject spawnedActor = Instantiate(SpawnPrefab, SpawnLocation, SpawnRotation);

        return null; // Temporary return value.
    }

    /// <summary>
    /// The object's name.
    /// </summary>
    public string ObjectName
    {
        get { return gameObject.name; }
        set { gameObject.name = value; }
    }

    /// <summary>
    /// The object's current location.
    /// </summary>
    public Vector3 Location
    {
        get { return gameObject.transform.position; }
    }

    /// <summary>
    /// The object's rotation values.
    /// </summary>
    public Quaternion Rotation
    {
        get { return gameObject.transform.rotation; }
    }

    /// <summary>
    /// The object's transform component.
    /// </summary>
    public Transform Transform
    {
        get { return gameObject.transform; }
    }

    /// <summary>
    /// Logs a message to the debug console and reports what object the message came from.
    /// </summary>
    /// <param name="msgString">Message to be logged to the console.</param>
    public virtual void LogMsg(string msgString)
    {
        Debug.Log("Log from " + ObjectName + ". Message: " + msgString);
    }
}
