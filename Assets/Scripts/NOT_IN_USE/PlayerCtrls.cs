// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/InputHandling/PlayerCtrls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerCtrls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerCtrls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerCtrls"",
    ""maps"": [
        {
            ""name"": ""PlayerGameplayControls"",
            ""id"": ""70591aa0-4574-4a7c-ad21-7ea2c5b30bbb"",
            ""actions"": [
                {
                    ""name"": ""DirectionalInput"",
                    ""type"": ""Value"",
                    ""id"": ""15f08aa9-045e-418d-8c21-c19aa26a39db"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackDirections"",
                    ""type"": ""Button"",
                    ""id"": ""cfc75398-70d8-4017-8ac9-d8961580a853"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UpDownInput"",
                    ""type"": ""Button"",
                    ""id"": ""6da674be-87b3-45e3-a94a-def0c0c44c76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AKey_DKey"",
                    ""id"": ""0534839b-e122-40b2-9472-51827f2c8356"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DirectionalInput"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3a1b4782-6db9-41dc-b2db-320f13077138"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""DirectionalInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7658552c-fdc6-4b14-8419-984d298b03b1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""DirectionalInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""2ea61fad-726f-4c66-9dcc-f25f920d0d46"",
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
                    ""id"": ""b78c3f30-c1e2-4c0f-8466-d90ce7d489e4"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""AttackDirections"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ffa33bed-09ea-42e6-88fb-bd19a43f35ba"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""AttackDirections"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""023b8260-519f-4814-81c9-7ec68ab78a60"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""AttackDirections"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""29a18bd1-ed0d-4224-95ea-c31419d97f52"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""AttackDirections"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Wkey_SKey"",
                    ""id"": ""24cc735d-695e-41a5-b614-caf585bde0f3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDownInput"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9200393f-6e0f-43c2-a711-ec22d544aed6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""UpDownInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""86e218a4-4fdb-4b25-87cc-299c273004a8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard/Mouse"",
                    ""action"": ""UpDownInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard/Mouse"",
            ""bindingGroup"": ""Keyboard/Mouse"",
            ""devices"": []
        }
    ]
}");
        // PlayerGameplayControls
        m_PlayerGameplayControls = asset.FindActionMap("PlayerGameplayControls", throwIfNotFound: true);
        m_PlayerGameplayControls_DirectionalInput = m_PlayerGameplayControls.FindAction("DirectionalInput", throwIfNotFound: true);
        m_PlayerGameplayControls_AttackDirections = m_PlayerGameplayControls.FindAction("AttackDirections", throwIfNotFound: true);
        m_PlayerGameplayControls_UpDownInput = m_PlayerGameplayControls.FindAction("UpDownInput", throwIfNotFound: true);
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

    // PlayerGameplayControls
    private readonly InputActionMap m_PlayerGameplayControls;
    private IPlayerGameplayControlsActions m_PlayerGameplayControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerGameplayControls_DirectionalInput;
    private readonly InputAction m_PlayerGameplayControls_AttackDirections;
    private readonly InputAction m_PlayerGameplayControls_UpDownInput;
    public struct PlayerGameplayControlsActions
    {
        private @PlayerCtrls m_Wrapper;
        public PlayerGameplayControlsActions(@PlayerCtrls wrapper) { m_Wrapper = wrapper; }
        public InputAction @DirectionalInput => m_Wrapper.m_PlayerGameplayControls_DirectionalInput;
        public InputAction @AttackDirections => m_Wrapper.m_PlayerGameplayControls_AttackDirections;
        public InputAction @UpDownInput => m_Wrapper.m_PlayerGameplayControls_UpDownInput;
        public InputActionMap Get() { return m_Wrapper.m_PlayerGameplayControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerGameplayControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerGameplayControlsActions instance)
        {
            if (m_Wrapper.m_PlayerGameplayControlsActionsCallbackInterface != null)
            {
                @DirectionalInput.started -= m_Wrapper.m_PlayerGameplayControlsActionsCallbackInterface.OnDirectionalInput;
                @DirectionalInput.performed -= m_Wrapper.m_PlayerGameplayControlsActionsCallbackInterface.OnDirectionalInput;
                @DirectionalInput.canceled -= m_Wrapper.m_PlayerGameplayControlsActionsCallbackInterface.OnDirectionalInput;
                @AttackDirections.started -= m_Wrapper.m_PlayerGameplayControlsActionsCallbackInterface.OnAttackDirections;
                @AttackDirections.performed -= m_Wrapper.m_PlayerGameplayControlsActionsCallbackInterface.OnAttackDirections;
                @AttackDirections.canceled -= m_Wrapper.m_PlayerGameplayControlsActionsCallbackInterface.OnAttackDirections;
                @UpDownInput.started -= m_Wrapper.m_PlayerGameplayControlsActionsCallbackInterface.OnUpDownInput;
                @UpDownInput.performed -= m_Wrapper.m_PlayerGameplayControlsActionsCallbackInterface.OnUpDownInput;
                @UpDownInput.canceled -= m_Wrapper.m_PlayerGameplayControlsActionsCallbackInterface.OnUpDownInput;
            }
            m_Wrapper.m_PlayerGameplayControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DirectionalInput.started += instance.OnDirectionalInput;
                @DirectionalInput.performed += instance.OnDirectionalInput;
                @DirectionalInput.canceled += instance.OnDirectionalInput;
                @AttackDirections.started += instance.OnAttackDirections;
                @AttackDirections.performed += instance.OnAttackDirections;
                @AttackDirections.canceled += instance.OnAttackDirections;
                @UpDownInput.started += instance.OnUpDownInput;
                @UpDownInput.performed += instance.OnUpDownInput;
                @UpDownInput.canceled += instance.OnUpDownInput;
            }
        }
    }
    public PlayerGameplayControlsActions @PlayerGameplayControls => new PlayerGameplayControlsActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard/Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IPlayerGameplayControlsActions
    {
        void OnDirectionalInput(InputAction.CallbackContext context);
        void OnAttackDirections(InputAction.CallbackContext context);
        void OnUpDownInput(InputAction.CallbackContext context);
    }
}
