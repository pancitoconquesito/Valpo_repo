//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.1.1
//     from Assets/Control/NewControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @NewControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""NewControls"",
    ""maps"": [
        {
            ""name"": ""PLAYER"",
            ""id"": ""20486ec7-27c0-46b7-983a-83831f218c07"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""0f987dee-d861-47f7-b2c3-a3184b20e82a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement_X"",
                    ""type"": ""Value"",
                    ""id"": ""c548b493-4d9d-4e2a-ac5c-3c99c37579e7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""8324cb40-b0e9-4427-b439-db76aca23207"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""a0d9ff1d-7502-42e8-b8f9-2d66b2467c98"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""613b6ebb-d295-4ced-bce8-dbed5f663aea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Magnesis"",
                    ""type"": ""Button"",
                    ""id"": ""cecb5c8a-145e-4ac2-95eb-e58675ea10dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Inventary"",
                    ""type"": ""Button"",
                    ""id"": ""6320f0a3-335e-4da3-92ba-ceabdeed8f22"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interactuar"",
                    ""type"": ""Button"",
                    ""id"": ""b099fc29-50a4-4d8a-9273-0bc1437e21c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4fdc2867-b678-4532-8ca8-3acba96e3ee5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7209e661-579c-47e4-8e84-640c9d365742"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GAMEPAD"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Move"",
                    ""id"": ""e6a5a876-bf60-4d62-b823-6b71faf419cc"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_X"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""c078dd10-045f-42e1-b308-e9c6e2d857a4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""256283ca-eb45-4d7a-b790-1f3ecc9fd1dc"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a86560ab-e7ad-45ad-8c9f-57bf7b22dd8f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": ""Press(pressPoint=1.401298E-45,behavior=2)"",
                    ""processors"": ""NormalizeVector2,StickDeadzone(max=1)"",
                    ""groups"": ""GAMEPAD"",
                    ""action"": ""Movement_X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a55b63c-dc8b-46fb-a999-571a0b128453"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2120744-9bfc-4b1c-b7bc-30f0862594bd"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GAMEPAD"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94555322-45a4-4af0-b4bd-9b61961b6694"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a3473f6-88e3-4e34-8ba0-89ed4d4a0203"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1cc54c8b-ba3c-443f-9434-213557e4f4ae"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Magnesis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""343ef31a-b1a7-427c-9d7f-f3d98c2ef498"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bfaa5aae-9571-4b60-b15c-5b72ba95f5d2"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interactuar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""GAMEPAD"",
            ""bindingGroup"": ""GAMEPAD"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PLAYER
        m_PLAYER = asset.FindActionMap("PLAYER", throwIfNotFound: true);
        m_PLAYER_Jump = m_PLAYER.FindAction("Jump", throwIfNotFound: true);
        m_PLAYER_Movement_X = m_PLAYER.FindAction("Movement_X", throwIfNotFound: true);
        m_PLAYER_Run = m_PLAYER.FindAction("Run", throwIfNotFound: true);
        m_PLAYER_Dash = m_PLAYER.FindAction("Dash", throwIfNotFound: true);
        m_PLAYER_Shoot = m_PLAYER.FindAction("Shoot", throwIfNotFound: true);
        m_PLAYER_Magnesis = m_PLAYER.FindAction("Magnesis", throwIfNotFound: true);
        m_PLAYER_Inventary = m_PLAYER.FindAction("Inventary", throwIfNotFound: true);
        m_PLAYER_Interactuar = m_PLAYER.FindAction("Interactuar", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PLAYER
    private readonly InputActionMap m_PLAYER;
    private IPLAYERActions m_PLAYERActionsCallbackInterface;
    private readonly InputAction m_PLAYER_Jump;
    private readonly InputAction m_PLAYER_Movement_X;
    private readonly InputAction m_PLAYER_Run;
    private readonly InputAction m_PLAYER_Dash;
    private readonly InputAction m_PLAYER_Shoot;
    private readonly InputAction m_PLAYER_Magnesis;
    private readonly InputAction m_PLAYER_Inventary;
    private readonly InputAction m_PLAYER_Interactuar;
    public struct PLAYERActions
    {
        private @NewControls m_Wrapper;
        public PLAYERActions(@NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_PLAYER_Jump;
        public InputAction @Movement_X => m_Wrapper.m_PLAYER_Movement_X;
        public InputAction @Run => m_Wrapper.m_PLAYER_Run;
        public InputAction @Dash => m_Wrapper.m_PLAYER_Dash;
        public InputAction @Shoot => m_Wrapper.m_PLAYER_Shoot;
        public InputAction @Magnesis => m_Wrapper.m_PLAYER_Magnesis;
        public InputAction @Inventary => m_Wrapper.m_PLAYER_Inventary;
        public InputAction @Interactuar => m_Wrapper.m_PLAYER_Interactuar;
        public InputActionMap Get() { return m_Wrapper.m_PLAYER; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PLAYERActions set) { return set.Get(); }
        public void SetCallbacks(IPLAYERActions instance)
        {
            if (m_Wrapper.m_PLAYERActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnJump;
                @Movement_X.started -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnMovement_X;
                @Movement_X.performed -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnMovement_X;
                @Movement_X.canceled -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnMovement_X;
                @Run.started -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnRun;
                @Dash.started -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnDash;
                @Shoot.started -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnShoot;
                @Magnesis.started -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnMagnesis;
                @Magnesis.performed -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnMagnesis;
                @Magnesis.canceled -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnMagnesis;
                @Inventary.started -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnInventary;
                @Inventary.performed -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnInventary;
                @Inventary.canceled -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnInventary;
                @Interactuar.started -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnInteractuar;
                @Interactuar.performed -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnInteractuar;
                @Interactuar.canceled -= m_Wrapper.m_PLAYERActionsCallbackInterface.OnInteractuar;
            }
            m_Wrapper.m_PLAYERActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Movement_X.started += instance.OnMovement_X;
                @Movement_X.performed += instance.OnMovement_X;
                @Movement_X.canceled += instance.OnMovement_X;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Magnesis.started += instance.OnMagnesis;
                @Magnesis.performed += instance.OnMagnesis;
                @Magnesis.canceled += instance.OnMagnesis;
                @Inventary.started += instance.OnInventary;
                @Inventary.performed += instance.OnInventary;
                @Inventary.canceled += instance.OnInventary;
                @Interactuar.started += instance.OnInteractuar;
                @Interactuar.performed += instance.OnInteractuar;
                @Interactuar.canceled += instance.OnInteractuar;
            }
        }
    }
    public PLAYERActions @PLAYER => new PLAYERActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GAMEPADSchemeIndex = -1;
    public InputControlScheme GAMEPADScheme
    {
        get
        {
            if (m_GAMEPADSchemeIndex == -1) m_GAMEPADSchemeIndex = asset.FindControlSchemeIndex("GAMEPAD");
            return asset.controlSchemes[m_GAMEPADSchemeIndex];
        }
    }
    public interface IPLAYERActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMovement_X(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnMagnesis(InputAction.CallbackContext context);
        void OnInventary(InputAction.CallbackContext context);
        void OnInteractuar(InputAction.CallbackContext context);
    }
}
