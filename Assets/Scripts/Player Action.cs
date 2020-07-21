// GENERATED AUTOMATICALLY FROM 'Assets/Player Action.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Action"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""d1ef30c3-8054-4b4e-8e8c-9009d0f7f99d"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""c6bf5986-391e-4d8b-aff7-c1053d1a9957"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""94ee39d1-c179-4b8f-8093-13f60a6b6c9c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""55f17f0f-4461-41cf-89ee-e80c05aef105"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Health"",
                    ""type"": ""Button"",
                    ""id"": ""09a71a71-db7d-4f7f-a59d-806cdd6e772a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Energy"",
                    ""type"": ""Button"",
                    ""id"": ""dfa9331f-c2f7-4320-852e-128d866ba7aa"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""VerticalMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bf402c96-4ccc-4976-bcb1-404ec043540a"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ec1e265d-abe8-48d7-80d7-d4b7042cf7e6"",
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
                    ""id"": ""c5837b89-e0c5-44b3-8077-3746109a0dbd"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis Keyboard"",
                    ""id"": ""b8d76ce7-a059-4698-b361-1805ba5f0ae0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""71049813-32c9-4a61-a9ea-e95aaa52a22f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""599aa34f-b3d8-43ef-9dca-bf625e93c73f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis GamePad"",
                    ""id"": ""f8c3d0f2-f448-4aa8-a60a-310b1fce352e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""59ba07a4-de73-4152-8696-a64b80181f92"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fc1c2a82-1550-4ed1-984a-2c06ed054a77"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""114f9067-1eaf-4d72-ab74-0c2cc6e80366"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11cfe96e-442c-4575-894d-bee2d9e7dfdf"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a8b6eaa-67b5-4947-8510-ea1377a8c68a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Health"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d6d95dd-2e25-4dbe-8cd1-dac2336be42d"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Energy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""40313a40-6a60-4e6e-a719-4c48ad2a7564"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""385287c6-928e-4b0b-8468-b7cee224f641"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""212c1459-1915-4ec4-9a28-bd6e8159ff0e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Weapon Menu"",
            ""id"": ""3870d1eb-4b58-4cc7-8a70-05a40b330ffb"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""63988762-3fe4-4eb4-8b6d-5e247249f9d1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""8f66c5ef-4947-4321-941c-84b74cb51d21"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EnableMenu"",
                    ""type"": ""Button"",
                    ""id"": ""ebda64b2-10f3-4c2f-850c-d726e05afd23"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""7b6cffb9-1beb-4363-865e-154e0c66ed8b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""55b8b0a0-42f3-4695-9e45-85738e98aa24"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""687f3282-c9fc-42f7-836c-d78bb81323d4"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1f9faf3-ff38-473c-8eb1-9caa8379b320"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5d89e57-350c-413a-9954-d226451d9f3a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""704717fb-06bb-4b15-8058-cdea02b1ca57"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5525a395-37fe-49a0-b2f3-5b552bb78a4b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf33cb19-879d-49a4-9005-b489ea5092c3"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnableMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b94fc3d1-7a70-463f-b27c-d1f75e3a769a"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnableMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d538430e-d3c8-4c83-9150-2149be1e8387"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e3def9a-0665-46a1-8076-9cde5de63b36"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Stage Select"",
            ""id"": ""192c0bf1-f496-4195-8317-a052e3423011"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""01aa43f9-e0c8-4499-bd74-22e473264548"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""5066cec4-5715-42ea-b71c-dfa55a0b01ef"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""7032e34d-798e-4af3-8138-3e4441c33fd1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""858fd192-d3db-45e7-9720-b9c6da87e05f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""2cf943e8-680d-4b1e-8adc-e1193cebe678"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fa2bbb0c-d059-4aa0-9137-44ad0b6200e4"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04fbbd3a-2b48-4310-9b1c-139431b9ee19"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7a4a755-de21-4964-85be-734a32b291ba"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cac83aaa-ec1c-4fab-951f-fd18ab6ca37b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02a22238-449d-4c12-b103-970608a27a2d"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_Movement = m_Gameplay.FindAction("Movement", throwIfNotFound: true);
        m_Gameplay_Shoot = m_Gameplay.FindAction("Shoot", throwIfNotFound: true);
        m_Gameplay_Health = m_Gameplay.FindAction("Health", throwIfNotFound: true);
        m_Gameplay_Energy = m_Gameplay.FindAction("Energy", throwIfNotFound: true);
        m_Gameplay_VerticalMovement = m_Gameplay.FindAction("VerticalMovement", throwIfNotFound: true);
        // Weapon Menu
        m_WeaponMenu = asset.FindActionMap("Weapon Menu", throwIfNotFound: true);
        m_WeaponMenu_Up = m_WeaponMenu.FindAction("Up", throwIfNotFound: true);
        m_WeaponMenu_Down = m_WeaponMenu.FindAction("Down", throwIfNotFound: true);
        m_WeaponMenu_EnableMenu = m_WeaponMenu.FindAction("EnableMenu", throwIfNotFound: true);
        m_WeaponMenu_SelectWeapon = m_WeaponMenu.FindAction("SelectWeapon", throwIfNotFound: true);
        // Stage Select
        m_StageSelect = asset.FindActionMap("Stage Select", throwIfNotFound: true);
        m_StageSelect_Up = m_StageSelect.FindAction("Up", throwIfNotFound: true);
        m_StageSelect_Down = m_StageSelect.FindAction("Down", throwIfNotFound: true);
        m_StageSelect_Left = m_StageSelect.FindAction("Left", throwIfNotFound: true);
        m_StageSelect_Right = m_StageSelect.FindAction("Right", throwIfNotFound: true);
        m_StageSelect_Confirm = m_StageSelect.FindAction("Confirm", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_Movement;
    private readonly InputAction m_Gameplay_Shoot;
    private readonly InputAction m_Gameplay_Health;
    private readonly InputAction m_Gameplay_Energy;
    private readonly InputAction m_Gameplay_VerticalMovement;
    public struct GameplayActions
    {
        private @PlayerAction m_Wrapper;
        public GameplayActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @Movement => m_Wrapper.m_Gameplay_Movement;
        public InputAction @Shoot => m_Wrapper.m_Gameplay_Shoot;
        public InputAction @Health => m_Wrapper.m_Gameplay_Health;
        public InputAction @Energy => m_Wrapper.m_Gameplay_Energy;
        public InputAction @VerticalMovement => m_Wrapper.m_Gameplay_VerticalMovement;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Movement.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                @Shoot.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Health.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHealth;
                @Health.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHealth;
                @Health.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHealth;
                @Energy.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEnergy;
                @Energy.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEnergy;
                @Energy.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEnergy;
                @VerticalMovement.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnVerticalMovement;
                @VerticalMovement.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnVerticalMovement;
                @VerticalMovement.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnVerticalMovement;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Health.started += instance.OnHealth;
                @Health.performed += instance.OnHealth;
                @Health.canceled += instance.OnHealth;
                @Energy.started += instance.OnEnergy;
                @Energy.performed += instance.OnEnergy;
                @Energy.canceled += instance.OnEnergy;
                @VerticalMovement.started += instance.OnVerticalMovement;
                @VerticalMovement.performed += instance.OnVerticalMovement;
                @VerticalMovement.canceled += instance.OnVerticalMovement;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Weapon Menu
    private readonly InputActionMap m_WeaponMenu;
    private IWeaponMenuActions m_WeaponMenuActionsCallbackInterface;
    private readonly InputAction m_WeaponMenu_Up;
    private readonly InputAction m_WeaponMenu_Down;
    private readonly InputAction m_WeaponMenu_EnableMenu;
    private readonly InputAction m_WeaponMenu_SelectWeapon;
    public struct WeaponMenuActions
    {
        private @PlayerAction m_Wrapper;
        public WeaponMenuActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_WeaponMenu_Up;
        public InputAction @Down => m_Wrapper.m_WeaponMenu_Down;
        public InputAction @EnableMenu => m_Wrapper.m_WeaponMenu_EnableMenu;
        public InputAction @SelectWeapon => m_Wrapper.m_WeaponMenu_SelectWeapon;
        public InputActionMap Get() { return m_Wrapper.m_WeaponMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WeaponMenuActions set) { return set.Get(); }
        public void SetCallbacks(IWeaponMenuActions instance)
        {
            if (m_Wrapper.m_WeaponMenuActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_WeaponMenuActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_WeaponMenuActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_WeaponMenuActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_WeaponMenuActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_WeaponMenuActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_WeaponMenuActionsCallbackInterface.OnDown;
                @EnableMenu.started -= m_Wrapper.m_WeaponMenuActionsCallbackInterface.OnEnableMenu;
                @EnableMenu.performed -= m_Wrapper.m_WeaponMenuActionsCallbackInterface.OnEnableMenu;
                @EnableMenu.canceled -= m_Wrapper.m_WeaponMenuActionsCallbackInterface.OnEnableMenu;
                @SelectWeapon.started -= m_Wrapper.m_WeaponMenuActionsCallbackInterface.OnSelectWeapon;
                @SelectWeapon.performed -= m_Wrapper.m_WeaponMenuActionsCallbackInterface.OnSelectWeapon;
                @SelectWeapon.canceled -= m_Wrapper.m_WeaponMenuActionsCallbackInterface.OnSelectWeapon;
            }
            m_Wrapper.m_WeaponMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @EnableMenu.started += instance.OnEnableMenu;
                @EnableMenu.performed += instance.OnEnableMenu;
                @EnableMenu.canceled += instance.OnEnableMenu;
                @SelectWeapon.started += instance.OnSelectWeapon;
                @SelectWeapon.performed += instance.OnSelectWeapon;
                @SelectWeapon.canceled += instance.OnSelectWeapon;
            }
        }
    }
    public WeaponMenuActions @WeaponMenu => new WeaponMenuActions(this);

    // Stage Select
    private readonly InputActionMap m_StageSelect;
    private IStageSelectActions m_StageSelectActionsCallbackInterface;
    private readonly InputAction m_StageSelect_Up;
    private readonly InputAction m_StageSelect_Down;
    private readonly InputAction m_StageSelect_Left;
    private readonly InputAction m_StageSelect_Right;
    private readonly InputAction m_StageSelect_Confirm;
    public struct StageSelectActions
    {
        private @PlayerAction m_Wrapper;
        public StageSelectActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_StageSelect_Up;
        public InputAction @Down => m_Wrapper.m_StageSelect_Down;
        public InputAction @Left => m_Wrapper.m_StageSelect_Left;
        public InputAction @Right => m_Wrapper.m_StageSelect_Right;
        public InputAction @Confirm => m_Wrapper.m_StageSelect_Confirm;
        public InputActionMap Get() { return m_Wrapper.m_StageSelect; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StageSelectActions set) { return set.Get(); }
        public void SetCallbacks(IStageSelectActions instance)
        {
            if (m_Wrapper.m_StageSelectActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_StageSelectActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_StageSelectActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_StageSelectActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_StageSelectActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_StageSelectActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_StageSelectActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_StageSelectActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_StageSelectActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_StageSelectActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_StageSelectActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_StageSelectActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_StageSelectActionsCallbackInterface.OnRight;
                @Confirm.started -= m_Wrapper.m_StageSelectActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_StageSelectActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_StageSelectActionsCallbackInterface.OnConfirm;
            }
            m_Wrapper.m_StageSelectActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
            }
        }
    }
    public StageSelectActions @StageSelect => new StageSelectActions(this);
    public interface IGameplayActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnHealth(InputAction.CallbackContext context);
        void OnEnergy(InputAction.CallbackContext context);
        void OnVerticalMovement(InputAction.CallbackContext context);
    }
    public interface IWeaponMenuActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnEnableMenu(InputAction.CallbackContext context);
        void OnSelectWeapon(InputAction.CallbackContext context);
    }
    public interface IStageSelectActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
    }
}
