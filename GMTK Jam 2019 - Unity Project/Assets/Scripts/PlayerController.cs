using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] string controllerNumber = "0";
    [SerializeField] int speed;

    Vector3 bufferVector;
    Rigidbody myRigidbody;
    int bodyRotation = 1;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        bufferVector = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //cPrint(Input.GetAxisRaw("Joy" + controllerNumber + "Horizontal"));

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
        else if (transform.eulerAngles.y >= 265 && transform.eulerAngles.y <= 275 )
        {
            bodyRotation = -1;
        }

        myRigidbody.MovePosition(transform.position + (transform.forward * GetAxisUni("Joy" + controllerNumber + "Horizontal") * speed * Time.deltaTime * bodyRotation));
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
}
