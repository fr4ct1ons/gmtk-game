// GENERATED AUTOMATICALLY FROM 'Assets/MenuInputs.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class MenuInputs : IInputActionCollection
{
    private InputActionAsset asset;
    public MenuInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MenuInputs"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""b679f06b-4ae2-443f-922d-79f574e92887"",
            ""actions"": [
                {
                    ""name"": ""Connect"",
                    ""type"": ""Button"",
                    ""id"": ""3189410a-1ac9-463e-bfbb-4f00f953d6f3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0455fbed-248c-4075-be9d-bac3b68cc7bf"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Connect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Menu
        m_Menu = asset.GetActionMap("Menu");
        m_Menu_Connect = m_Menu.GetAction("Connect");
    }

    ~MenuInputs()
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

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Connect;
    public struct MenuActions
    {
        private MenuInputs m_Wrapper;
        public MenuActions(MenuInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Connect => m_Wrapper.m_Menu_Connect;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                Connect.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnConnect;
                Connect.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnConnect;
                Connect.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnConnect;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                Connect.started += instance.OnConnect;
                Connect.performed += instance.OnConnect;
                Connect.canceled += instance.OnConnect;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IMenuActions
    {
        void OnConnect(InputAction.CallbackContext context);
    }
}
