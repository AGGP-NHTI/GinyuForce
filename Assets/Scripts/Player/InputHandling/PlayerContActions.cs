// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/InputHandling/PlayerContActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerContActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerContActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerContActions"",
    ""maps"": [
        {
            ""name"": ""PlayerActiveInput"",
            ""id"": ""be198b09-3cae-43f4-ae16-bfe24a7e741f"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""Value"",
                    ""id"": ""1ad53284-2a38-467d-8012-592097351222"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""95527e48-be7d-40c5-b1f2-a88350a97394"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackDirectional"",
                    ""type"": ""Value"",
                    ""id"": ""f8da679a-01c4-453c-a841-8b436a85c0f4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9595de5e-b38a-4486-8406-fbce48e3cf81"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2b6771ed-3c16-4263-9a28-cf432398cca6"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ec50bb50-b073-4228-b499-9be224c021f7"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5b5b1483-28ab-4ddf-8726-13dc945a990d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a8e651ab-fc51-4cba-90bf-3912aa7084b4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f594e48a-b1fe-4258-b409-58b3205eff8b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c3d592a-1dbb-489d-ba9d-0f5d3146918d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AttackDirs"",
                    ""id"": ""a7d05196-c3fc-46ed-8dc3-cec669b8e90c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackDirectional"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5e44cbd3-b263-4a83-b07b-b6ed0ce3fd85"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackDirectional"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3b8712c7-4047-4f7e-b0cf-0a9c48726189"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackDirectional"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8058cac4-724b-413c-a73a-bdc80b6c4a3e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackDirectional"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5cea7946-b6bf-49ad-bffb-1d0d05e519b2"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackDirectional"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""PlayerInterfaceInput"",
            ""id"": ""c2c2f435-4842-413a-bd66-54f47d651bd7"",
            ""actions"": [
                {
                    ""name"": ""PauseGame"",
                    ""type"": ""Button"",
                    ""id"": ""f58f39c7-95c7-4d94-a140-55e8a749a74a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""edb90f20-f942-47d4-a1cf-4e8245ecc36e"",
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
        // PlayerActiveInput
        m_PlayerActiveInput = asset.FindActionMap("PlayerActiveInput", throwIfNotFound: true);
        m_PlayerActiveInput_HorizontalMovement = m_PlayerActiveInput.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_PlayerActiveInput_Jump = m_PlayerActiveInput.FindAction("Jump", throwIfNotFound: true);
        m_PlayerActiveInput_AttackDirectional = m_PlayerActiveInput.FindAction("AttackDirectional", throwIfNotFound: true);
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

    // PlayerActiveInput
    private readonly InputActionMap m_PlayerActiveInput;
    private IPlayerActiveInputActions m_PlayerActiveInputActionsCallbackInterface;
    private readonly InputAction m_PlayerActiveInput_HorizontalMovement;
    private readonly InputAction m_PlayerActiveInput_Jump;
    private readonly InputAction m_PlayerActiveInput_AttackDirectional;
    public struct PlayerActiveInputActions
    {
        private @PlayerContActions m_Wrapper;
        public PlayerActiveInputActions(@PlayerContActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_PlayerActiveInput_HorizontalMovement;
        public InputAction @Jump => m_Wrapper.m_PlayerActiveInput_Jump;
        public InputAction @AttackDirectional => m_Wrapper.m_PlayerActiveInput_AttackDirectional;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActiveInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActiveInputActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActiveInputActions instance)
        {
            if (m_Wrapper.m_PlayerActiveInputActionsCallbackInterface != null)
            {
                @HorizontalMovement.started -= m_Wrapper.m_PlayerActiveInputActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_PlayerActiveInputActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_PlayerActiveInputActionsCallbackInterface.OnHorizontalMovement;
                @Jump.started -= m_Wrapper.m_PlayerActiveInputActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActiveInputActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActiveInputActionsCallbackInterface.OnJump;
                @AttackDirectional.started -= m_Wrapper.m_PlayerActiveInputActionsCallbackInterface.OnAttackDirectional;
                @AttackDirectional.performed -= m_Wrapper.m_PlayerActiveInputActionsCallbackInterface.OnAttackDirectional;
                @AttackDirectional.canceled -= m_Wrapper.m_PlayerActiveInputActionsCallbackInterface.OnAttackDirectional;
            }
            m_Wrapper.m_PlayerActiveInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @AttackDirectional.started += instance.OnAttackDirectional;
                @AttackDirectional.performed += instance.OnAttackDirectional;
                @AttackDirectional.canceled += instance.OnAttackDirectional;
            }
        }
    }
    public PlayerActiveInputActions @PlayerActiveInput => new PlayerActiveInputActions(this);

    // PlayerInterfaceInput
    private readonly InputActionMap m_PlayerInterfaceInput;
    private IPlayerInterfaceInputActions m_PlayerInterfaceInputActionsCallbackInterface;
    private readonly InputAction m_PlayerInterfaceInput_PauseGame;
    public struct PlayerInterfaceInputActions
    {
        private @PlayerContActions m_Wrapper;
        public PlayerInterfaceInputActions(@PlayerContActions wrapper) { m_Wrapper = wrapper; }
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
    public interface IPlayerActiveInputActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAttackDirectional(InputAction.CallbackContext context);
    }
    public interface IPlayerInterfaceInputActions
    {
        void OnPauseGame(InputAction.CallbackContext context);
    }
}
