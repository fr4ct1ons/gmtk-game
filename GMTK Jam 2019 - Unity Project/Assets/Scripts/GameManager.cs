using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem.Users;
using UnityEngine.InputSystem;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager gm = null;

    public delegate void VoidDelegate();
    public static event VoidDelegate OnGameStart;
    
    [SerializeField] private TextMeshProUGUI[] controllerStatus = new TextMeshProUGUI[2];
    [SerializeField] private GameObject controllersUI, gameplayUI;
    
    
    private int currentControllerCount = -1;

    private MenuInputs[] inputs = new MenuInputs[2];
    private InputUser[] users = new InputUser[2];
    private bool[] connectedPlayers = new bool[2];
    private bool pairingControllers = false;

    private void Awake()
    {

        inputs[0] = new MenuInputs();
        inputs[1] = new MenuInputs();

        if (!gm)
            gm = this;
        else
            Destroy(gameObject);

        currentControllerCount = Gamepad.all.Count;
        inputs[0].Menu.Connect.performed += ctx =>
        {
            controllerStatus[0].SetText("READY");
            controllerStatus[0].color = new Color32(0, 255, 0, 255);
            connectedPlayers[0] = true;
            
            if(connectedPlayers[1])
                StartCoroutine(StartGame());
        };

        inputs[1].Menu.Connect.performed += ctx =>
        {
            controllerStatus[1].SetText("READY");
            controllerStatus[1].color = new Color32(0, 255, 0, 255);
            connectedPlayers[1] = true;
            
            if(connectedPlayers[0])
                StartCoroutine(StartGame());
        };
        
        controllerStatus[0].SetText("NOT CONNECTED");
        controllerStatus[0].color = new Color32(255, 0, 0, 255);
        connectedPlayers[0] = false;

        controllerStatus[1].SetText("NOT CONNECTED");
        controllerStatus[1].color = new Color32(255, 0, 0, 255);
        connectedPlayers[1] = false;

        users[0] = InputUser.CreateUserWithoutPairedDevices();
        users[1] = InputUser.CreateUserWithoutPairedDevices();
        users[0].AssociateActionsWithUser(inputs[0]);
        users[1].AssociateActionsWithUser(inputs[1]);
        
        ControllerPairing();
    }

    private void Update()
    {
        if (pairingControllers)
        {
            if (Gamepad.all.Count != currentControllerCount)
            {

                {
                    users[0].UnpairDevices();
                    controllerStatus[0].SetText("NOT CONNECTED");
                    controllerStatus[0].color = new Color32(255, 0, 0, 255);
                    connectedPlayers[0] = false;

                    users[1].UnpairDevices();
                    controllerStatus[1].SetText("NOT CONNECTED");
                    controllerStatus[1].color = new Color32(255, 0, 0, 255);
                    connectedPlayers[1] = false;
                }

                ControllerPairing();
                currentControllerCount = Gamepad.all.Count;
            }
        }
    }
    
    

    public void SetPairingControllers(bool val) { pairingControllers = val; }

    public IEnumerator StartGame()
    {
        yield return new WaitForSeconds(1.0f);
        OnGameStart?.Invoke();
        gameplayUI.SetActive(true);
        controllersUI.SetActive(false);
    }

    public void ControllerPairing()
    {
        if (Gamepad.all.Count > 0 && !connectedPlayers[0])
        {
            users[0] = InputUser.PerformPairingWithDevice(Gamepad.all[0], users[0]);
            users[0].AssociateActionsWithUser(inputs[0]);
            controllerStatus[0].SetText("DEVICE DETECTED");
            controllerStatus[0].color = new Color32(0, 0, 255, 255);
        }

        if (Gamepad.all.Count > 1 && !connectedPlayers[1])
        {
            users[1] = InputUser.PerformPairingWithDevice(Gamepad.all[1], users[1]);
            users[1].AssociateActionsWithUser(inputs[1]);
            controllerStatus[1].SetText("DEVICE DETECTED");
            controllerStatus[1].color = new Color32(0, 0, 255, 255);
        }
    }


    private void OnEnable()
    {
        inputs[0].Menu.Enable();
        inputs[1].Menu.Enable();
    }

    private void OnDisable()
    {
        inputs[0].Menu.Disable();
        inputs[1].Menu.Disable();
    }

    public void CloseGame()
    {
        Application.Quit();
    }

}