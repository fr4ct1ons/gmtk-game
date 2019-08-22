// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerControls : IInputActionCollection
{
    private InputActionAsset asset;
    public PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""d6aba934-fc0e-4663-bb69-2fa404c11d07"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""85d23b74-e10f-4d49-b4f9-07fa8c87122d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BasicAttack"",
                    ""type"": ""Button"",
                    ""id"": ""16f9d2fe-9bfb-475b-a9e4-b196931adcf0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BILADA"",
                    ""type"": ""Button"",
                    ""id"": ""66cb79dd-6482-407b-886e-9d570fda6b1c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""85bcfb56-4c1b-4209-a3eb-dcbe46d2464e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb883706-ab0f-4e5d-8b8e-f877e3d4fecc"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BasicAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9bc6fd48-f12e-490e-92a3-07960e38651b"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BILADA"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7e71d75-ddc2-4208-a107-32e7f6e7b1b8"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BILADA"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0b0f1d2-3f76-43ae-bc08-f35142fd9823"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BILADA"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""id"": ""94bb68fa-dd59-4cb2-8840-c60cd058262f"",
            ""actions"": [
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""efb3868f-43cf-4d18-b5a3-49c231853a17"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""e51faab4-b6c7-42d9-8281-c7974acf3b92"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9e500d1a-5203-4458-89df-2f4ee793417a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e86a7811-717a-46d5-922b-5b0959f57a73"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.GetActionMap("Gameplay");
        m_Gameplay_Move = m_Gameplay.GetAction("Move");
        m_Gameplay_BasicAttack = m_Gameplay.GetAction("BasicAttack");
        m_Gameplay_BILADA = m_Gameplay.GetAction("BILADA");
        // Keyboard
        m_Keyboard = asset.GetActionMap("Keyboard");
        m_Keyboard_MoveRight = m_Keyboard.GetAction("MoveRight");
        m_Keyboard_MoveLeft = m_Keyboard.GetAction("MoveLeft");
    }

    ~PlayerControls()
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
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_BasicAttack;
    private readonly InputAction m_Gameplay_BILADA;
    public struct GameplayActions
    {
        private PlayerControls m_Wrapper;
        public GameplayActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @BasicAttack => m_Wrapper.m_Gameplay_BasicAttack;
        public InputAction @BILADA => m_Wrapper.m_Gameplay_BILADA;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                BasicAttack.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBasicAttack;
                BasicAttack.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBasicAttack;
                BasicAttack.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBasicAttack;
                BILADA.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBILADA;
                BILADA.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBILADA;
                BILADA.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBILADA;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                BasicAttack.started += instance.OnBasicAttack;
                BasicAttack.performed += instance.OnBasicAttack;
                BasicAttack.canceled += instance.OnBasicAttack;
                BILADA.started += instance.OnBILADA;
                BILADA.performed += instance.OnBILADA;
                BILADA.canceled += instance.OnBILADA;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Keyboard
    private readonly InputActionMap m_Keyboard;
    private IKeyboardActions m_KeyboardActionsCallbackInterface;
    private readonly InputAction m_Keyboard_MoveRight;
    private readonly InputAction m_Keyboard_MoveLeft;
    public struct KeyboardActions
    {
        private PlayerControls m_Wrapper;
        public KeyboardActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveRight => m_Wrapper.m_Keyboard_MoveRight;
        public InputAction @MoveLeft => m_Wrapper.m_Keyboard_MoveLeft;
        public InputActionMap Get() { return m_Wrapper.m_Keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardActions instance)
        {
            if (m_Wrapper.m_KeyboardActionsCallbackInterface != null)
            {
                MoveRight.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMoveRight;
                MoveRight.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMoveRight;
                MoveRight.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMoveRight;
                MoveLeft.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMoveLeft;
                MoveLeft.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMoveLeft;
                MoveLeft.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMoveLeft;
            }
            m_Wrapper.m_KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                MoveRight.started += instance.OnMoveRight;
                MoveRight.performed += instance.OnMoveRight;
                MoveRight.canceled += instance.OnMoveRight;
                MoveLeft.started += instance.OnMoveLeft;
                MoveLeft.performed += instance.OnMoveLeft;
                MoveLeft.canceled += instance.OnMoveLeft;
            }
        }
    }
    public KeyboardActions @Keyboard => new KeyboardActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnBasicAttack(InputAction.CallbackContext context);
        void OnBILADA(InputAction.CallbackContext context);
    }
    public interface IKeyboardActions
    {
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
    }
}
