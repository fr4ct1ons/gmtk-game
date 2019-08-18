using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int controllerNumber = 0;
    [SerializeField] int speed;
    [SerializeField] TextMeshProUGUI damageView;

    PlayerControls controls;
    
    Gamepad gamepad;
    Vector2 controllerLeftAnalog;
    InputUser myUser;
    Vector3 bufferVector;
    Rigidbody myRigidbody;
    Animator myAnimator;
    int bodyRotation = 1;
    float damagePercentage = 0;
    bool canMove = true;

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }

    private void Awake()
    {
        controls = new PlayerControls();
        //myUser = new InputUser();
        try
        {
            gamepad = Gamepad.all[controllerNumber - 1];
            myUser = InputUser.PerformPairingWithDevice(gamepad, myUser);
            myUser.AssociateActionsWithUser(controls);
            controls.Gameplay.Move.performed += ctx => controllerLeftAnalog = ctx.ReadValue<Vector2>();
            controls.Gameplay.Move.canceled += ctx => controllerLeftAnalog = Vector2.zero;
            controls.Gameplay.BasicAttack.performed += ctx => BasicAttack();
        }
        catch(System.ArgumentOutOfRangeException e)
        {
            cPrint("Controller for player " + controllerNumber + " not detected!");
            //controls.Keyboard.MoveRight.performed += ctx => MoveRight();
            //controls.Keyboard.MoveLeft.performed += ctx => MoveLeft();
            
        }
        myRigidbody = GetComponent<Rigidbody>();
        myAnimator = GetComponent<Animator>();
    }

    void Start()
    {
        bufferVector = transform.position;

        if (transform.eulerAngles.y >= 85.0f && transform.eulerAngles.y <= 95.0f)
        {
            bodyRotation = 1;
        }
        else if (transform.eulerAngles.y >= 265 && transform.eulerAngles.y <= 275)
        {
            bodyRotation = -1;
        }
    }

    void BasicAttack()
    {
        myAnimator.SetTrigger("BasicPunch");
        cPrint("Basic Punch");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("QuitGame"))
            Application.Quit();

        //cPrint(Gamepad.all[controllerNumber - 1]);

        //* 
        //cPrint("Joy " + controllerLeftAnalog.x + " Horizontal");
        if (canMove)
        {
            if (GetAxisUni(controllerLeftAnalog.x) != bodyRotation && GetAxisUni(controllerLeftAnalog.x) != 0)
            {
                //cPrint("Input is " + GetAxisUni(controllerLeftAnalog.x) + " bodyRotation is" + bodyRotation);
                //cPrint("Rotating.");
                transform.Rotate(0.0f, 180.0f, 0.0f);
            }

            if (transform.eulerAngles.y >= 85.0f && transform.eulerAngles.y <= 95.0f)
            {
                bodyRotation = 1;
            }
            else if (transform.eulerAngles.y >= 265 && transform.eulerAngles.y <= 275)
            {
                bodyRotation = -1;
            }

            myRigidbody.MovePosition(transform.position + (transform.forward * GetAxisUni(controllerLeftAnalog.x) * speed * Time.deltaTime * bodyRotation));
            /*if (Input.GetButton("Joy" + controllerNumber + "BasicPunch"))
            {
                myAnimator.SetTrigger("BasicPunch");
                cPrint("Basic Punch");
            }*/
        }
         //*/
    }

    void cPrint(object mymessage)
    {
        if (controllerNumber == 1)
            Debug.Log("<color=red>" + mymessage + "</color>");
        else if (controllerNumber == 2)
            Debug.Log("<color=green>" + mymessage + "</color>");
    }

    private float GetAxisUni(string axis)
    {
        if (Input.GetAxisRaw(axis) > 0)
            return 1;
        else if (Input.GetAxisRaw(axis) < 0)
            return -1;
        else
            return 0;
    }

    private float GetAxisUni(float value)
    {
        if (value > 0)
            return 1;
        else if (value < 0)
            return -1;
        else
            return 0;
    }

    public void AddDamage(float value, float stun)
    {
        damagePercentage += value;
        damageView.text = damagePercentage.ToString();
        if(stun != 0.0f)
        {
            StartCoroutine(Stun(stun));
        }
    }

    private IEnumerator Stun(float time)
    {
        canMove = false;
        yield return new WaitForSeconds(time);
        canMove = true;
    }

    public float GetDamage() { return damagePercentage; }
    public int GetBodyRotation() { return bodyRotation; }

    //Animator scripts

    public void UnallowMovement() { canMove = false; }
    public void AllowMovement() { canMove = true; }

    // Keyboard input methods

    public void MoveRight()
    {
        Debug.Log("Called.");
        myRigidbody.MovePosition(transform.position + (transform.forward * -1 * speed * Time.deltaTime * bodyRotation));
    }

    public void MoveLeft()
    {
        myRigidbody.MovePosition(transform.position + (transform.forward * speed * Time.deltaTime * bodyRotation));
    }
}
