using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : Core
{
    /// <summary>
    /// Controllers can be either Player or AI, with a Default option included that can be used to detect
    /// improperly initialized controllers.
    /// </summary>
    public enum ControllerType
    {
        Default,
        Player,
        AI
    };

    /// <summary>
    /// The type of this controller. Default value is "Default"
    /// </summary>
    protected ControllerType _ownType = ControllerType.Default;

    /// <summary>
    /// Gets the type of this controller. Note: if this returns "Default", the controller is improperly initialized.
    /// </summary>
    /// <returns></returns>
    public ControllerType GetControllerType()
    {
        return _ownType;
    }

    /// <summary>
    /// The name of the controller. This is a private variable, accessed primarily through ControllerName.
    /// </summary>
    [SerializeField]
    private string _controllerInternalName = "ControllerName_Default";

    /// <summary>
    /// Gets or sets the name of this controller.
    /// </summary>
    public string ControllerName
    {
        get { return _controllerInternalName; }
        set { _controllerInternalName = value; }
    }

    protected virtual void Awake()
    {
        _ownType = ControllerType.Default;
    }
}
