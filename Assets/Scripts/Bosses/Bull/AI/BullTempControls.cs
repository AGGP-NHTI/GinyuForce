// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Bosses/Bull/AI/BullTempControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @BullTempControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @BullTempControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BullTempControls"",
    ""maps"": [
        {
            ""name"": ""BullTempCtrlMap"",
            ""id"": ""bc34259a-e8f7-436a-978a-6d5aa7e7b59f"",
            ""actions"": [
                {
                    ""name"": ""BullJump"",
                    ""type"": ""Button"",
                    ""id"": ""d0bcefa1-091f-4cbe-9fae-cba7445b9dac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BullSing"",
                    ""type"": ""Button"",
                    ""id"": ""0ed883af-c915-47c1-92e2-0f654272ad2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BullCharge"",
                    ""type"": ""Value"",
                    ""id"": ""79b4b589-fe49-48d0-b44a-68341964d651"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""239d9436-f1f5-47f6-a231-793351eb3ccc"",
                    ""path"": ""<Keyboard>/equals"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BullJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c15fc77-5d9c-444f-8d4e-8f8906e5e9b6"",
                    ""path"": ""<Keyboard>/minus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BullSing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""LeftRightMovement"",
                    ""id"": ""763740c9-9382-42e3-a518-55dc4bfceab8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BullCharge"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e719bf86-807b-4851-8139-292df1b93b18"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BullCharge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9a8ae83b-edf7-4a93-b05d-8e8be759c34b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BullCharge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1dd08a21-2d98-4aca-9f86-3dd93b2debb2"",
                    ""path"": ""<Keyboard>/leftBracket"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BullCharge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ad2a177c-add0-4b74-9cb4-7ce71cf4f981"",
                    ""path"": ""<Keyboard>/rightBracket"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BullCharge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BullTempCtrlMap
        m_BullTempCtrlMap = asset.FindActionMap("BullTempCtrlMap", throwIfNotFound: true);
        m_BullTempCtrlMap_BullJump = m_BullTempCtrlMap.FindAction("BullJump", throwIfNotFound: true);
        m_BullTempCtrlMap_BullSing = m_BullTempCtrlMap.FindAction("BullSing", throwIfNotFound: true);
        m_BullTempCtrlMap_BullCharge = m_BullTempCtrlMap.FindAction("BullCharge", throwIfNotFound: true);
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

    // BullTempCtrlMap
    private readonly InputActionMap m_BullTempCtrlMap;
    private IBullTempCtrlMapActions m_BullTempCtrlMapActionsCallbackInterface;
    private readonly InputAction m_BullTempCtrlMap_BullJump;
    private readonly InputAction m_BullTempCtrlMap_BullSing;
    private readonly InputAction m_BullTempCtrlMap_BullCharge;
    public struct BullTempCtrlMapActions
    {
        private @BullTempControls m_Wrapper;
        public BullTempCtrlMapActions(@BullTempControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @BullJump => m_Wrapper.m_BullTempCtrlMap_BullJump;
        public InputAction @BullSing => m_Wrapper.m_BullTempCtrlMap_BullSing;
        public InputAction @BullCharge => m_Wrapper.m_BullTempCtrlMap_BullCharge;
        public InputActionMap Get() { return m_Wrapper.m_BullTempCtrlMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BullTempCtrlMapActions set) { return set.Get(); }
        public void SetCallbacks(IBullTempCtrlMapActions instance)
        {
            if (m_Wrapper.m_BullTempCtrlMapActionsCallbackInterface != null)
            {
                @BullJump.started -= m_Wrapper.m_BullTempCtrlMapActionsCallbackInterface.OnBullJump;
                @BullJump.performed -= m_Wrapper.m_BullTempCtrlMapActionsCallbackInterface.OnBullJump;
                @BullJump.canceled -= m_Wrapper.m_BullTempCtrlMapActionsCallbackInterface.OnBullJump;
                @BullSing.started -= m_Wrapper.m_BullTempCtrlMapActionsCallbackInterface.OnBullSing;
                @BullSing.performed -= m_Wrapper.m_BullTempCtrlMapActionsCallbackInterface.OnBullSing;
                @BullSing.canceled -= m_Wrapper.m_BullTempCtrlMapActionsCallbackInterface.OnBullSing;
                @BullCharge.started -= m_Wrapper.m_BullTempCtrlMapActionsCallbackInterface.OnBullCharge;
                @BullCharge.performed -= m_Wrapper.m_BullTempCtrlMapActionsCallbackInterface.OnBullCharge;
                @BullCharge.canceled -= m_Wrapper.m_BullTempCtrlMapActionsCallbackInterface.OnBullCharge;
            }
            m_Wrapper.m_BullTempCtrlMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @BullJump.started += instance.OnBullJump;
                @BullJump.performed += instance.OnBullJump;
                @BullJump.canceled += instance.OnBullJump;
                @BullSing.started += instance.OnBullSing;
                @BullSing.performed += instance.OnBullSing;
                @BullSing.canceled += instance.OnBullSing;
                @BullCharge.started += instance.OnBullCharge;
                @BullCharge.performed += instance.OnBullCharge;
                @BullCharge.canceled += instance.OnBullCharge;
            }
        }
    }
    public BullTempCtrlMapActions @BullTempCtrlMap => new BullTempCtrlMapActions(this);
    public interface IBullTempCtrlMapActions
    {
        void OnBullJump(InputAction.CallbackContext context);
        void OnBullSing(InputAction.CallbackContext context);
        void OnBullCharge(InputAction.CallbackContext context);
    }
}
