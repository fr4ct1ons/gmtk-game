using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] string controllerNumber = "0";
    [SerializeField] int speed;
    [SerializeField] TextMeshProUGUI damageView;
    
    Vector3 bufferVector;
    Rigidbody myRigidbody;
    Animator myAnimator;
    int bodyRotation = 1;
    [SerializeField] float damagePercentage = 0;
    bool canMove = true;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myAnimator = GetComponent<Animator>();
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

    // Update is called once per frame
    void Update()
    {
        //cPrint(Input.GetAxisRaw("Joy" + controllerNumber + "Horizontal"));
        if (canMove)
        {
            if (GetAxisUni("Joy" + controllerNumber + "Horizontal") != bodyRotation && GetAxisUni("Joy" + controllerNumber + "Horizontal") != 0)
            {
                cPrint("Input is " + GetAxisUni("Joy" + controllerNumber + "Horizontal") + " bodyRotation is" + bodyRotation);
                cPrint("Rotating.");
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

            myRigidbody.MovePosition(transform.position + (transform.forward * GetAxisUni("Joy" + controllerNumber + "Horizontal") * speed * Time.deltaTime * bodyRotation));
            if (Input.GetButton("Joy" + controllerNumber + "BasicPunch"))
            {
                myAnimator.SetTrigger("BasicPunch");
                cPrint("Basic Punch");
            }
        }
    }

    void cPrint(object mymessage)
    {
        if (controllerNumber == "1")
            Debug.Log("<color=red>" + mymessage + "</color>");
        else if (controllerNumber == "2")
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
    public void UnallowMovement() { canMove = false; }
    public void AllowMovement() { canMove = true; }
}
