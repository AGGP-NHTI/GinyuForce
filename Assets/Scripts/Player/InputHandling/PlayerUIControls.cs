// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/InputHandling/PlayerUIControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerUIControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerUIControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerUIControls"",
    ""maps"": [
        {
            ""name"": ""PlayerInterfaceInput"",
            ""id"": ""55ab0167-e5ab-41dd-8f0c-31d7cdd4e238"",
            ""actions"": [
                {
                    ""name"": ""PauseGame"",
                    ""type"": ""Button"",
                    ""id"": ""831590bb-d492-4487-ac5d-ac20c343b740"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c28cbb6d-8664-4075-b0ca-d0a8b336e41b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerInterfaceInput
        m_PlayerInterfaceInput = asset.FindActionMap("PlayerInterfaceInput", throwIfNotFound: true);
        m_PlayerInterfaceInput_PauseGame = m_PlayerInterfaceInput.FindAction("PauseGame", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // PlayerInterfaceInput
    private readonly InputActionMap m_PlayerInterfaceInput;
    private IPlayerInterfaceInputActions m_PlayerInterfaceInputActionsCallbackInterface;
    private readonly InputAction m_PlayerInterfaceInput_PauseGame;
    public struct PlayerInterfaceInputActions
    {
        private @PlayerUIControls m_Wrapper;
        public PlayerInterfaceInputActions(@PlayerUIControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PauseGame => m_Wrapper.m_PlayerInterfaceInput_PauseGame;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInterfaceInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInterfaceInputActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerInterfaceInputActions instance)
        {
            if (m_Wrapper.m_PlayerInterfaceInputActionsCallbackInterface != null)
            {
                @PauseGame.started -= m_Wrapper.m_PlayerInterfaceInputActionsCallbackInterface.OnPauseGame;
                @PauseGame.performed -= m_Wrapper.m_PlayerInterfaceInputActionsCallbackInterface.OnPauseGame;
                @PauseGame.canceled -= m_Wrapper.m_PlayerInterfaceInputActionsCallbackInterface.OnPauseGame;
            }
            m_Wrapper.m_PlayerInterfaceInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PauseGame.started += instance.OnPauseGame;
                @PauseGame.performed += instance.OnPauseGame;
                @PauseGame.canceled += instance.OnPauseGame;
            }
        }
    }
    public PlayerInterfaceInputActions @PlayerInterfaceInput => new PlayerInterfaceInputActions(this);
    public interface IPlayerInterfaceInputActions
    {
        void OnPauseGame(InputAction.CallbackContext context);
    }
}
