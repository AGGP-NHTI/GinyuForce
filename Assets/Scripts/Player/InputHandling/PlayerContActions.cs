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
                    ""name"": ""AttackDirections"",
                    ""type"": ""Button"",
                    ""id"": ""899b8c6e-4222-4546-86dd-efdfc7b0b06d"",
                    ""expectedControlType"": ""Button"",
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
                    ""name"": ""ArrowDirections"",
                    ""id"": ""ec262a0d-2b3f-4aab-b0ba-d87fda499f94"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackDirections"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7edadf62-c1c1-47cc-80c7-84812b292bc5"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackDirections"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b0d6fed5-a835-443a-92de-c7e5c1d71675"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackDirections"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5c3d15cc-021c-44c6-a7d5-62accd4406fe"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackDirections"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5ad8f93d-b85c-4922-b7a3-6087806d1d73"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackDirections"",
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
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerActiveInput
        m_PlayerActiveInput = asset.FindActionMap("PlayerActiveInput", throwIfNotFound: true);
        m_PlayerActiveInput_HorizontalMovement = m_PlayerActiveInput.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_PlayerActiveInput_AttackDirections = m_PlayerActiveInput.FindAction("AttackDirections", throwIfNotFound: true);
        m_PlayerActiveInput_Jump = m_PlayerActiveInput.FindAction("Jump", throwIfNotFound: true);
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
    private readonly InputAction m_PlayerActiveInput_AttackDirections;
    private readonly InputAction m_PlayerActiveInput_Jump;
    public struct PlayerActiveInputActions
    {
        private @PlayerContActions m_Wrapper;
        public PlayerActiveInputActions(@PlayerContActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_PlayerActiveInput_HorizontalMovement;
        public InputAction @AttackDirections => m_Wrapper.m_PlayerActiveInput_AttackDirections;
        public InputAction @Jump => m_Wrapper.m_PlayerActiveInput_Jump;
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
                @AttackDirections.started -= m_Wrapper.m_PlayerActiveInputActionsCallbackInterface.OnAttackDirections;
                @AttackDirections.performed -= m_Wrapper.m_PlayerActiveInputActionsCallbackInterface.OnAttackDirections;
                @AttackDirections.canceled -= m_Wrapper.m_PlayerActiveInputActionsCallbackInterface.OnAttackDirections;
                @Jump.started -= m_Wrapper.m_PlayerActiveInputActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActiveInputActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActiveInputActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerActiveInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                @AttackDirections.started += instance.OnAttackDirections;
                @AttackDirections.performed += instance.OnAttackDirections;
                @AttackDirections.canceled += instance.OnAttackDirections;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerActiveInputActions @PlayerActiveInput => new PlayerActiveInputActions(this);
    public interface IPlayerActiveInputActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnAttackDirections(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
