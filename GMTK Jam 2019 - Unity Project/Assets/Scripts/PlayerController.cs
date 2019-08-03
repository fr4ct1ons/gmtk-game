using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] string controllerNumber = "0";
    [SerializeField] int speed;

    Rigidbody myRigidbody;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        cPrint(Input.GetAxisRaw("Joy" + controllerNumber + "Horizontal"));
        //transform.Translate(transform.forward * Input.GetAxisRaw("Joy" + controllerNumber + "Horizontal") * speed * Time.deltaTime, Space.World);
        myRigidbody.MovePosition(transform.position + (transform.forward * Input.GetAxisRaw("Joy" + controllerNumber + "Horizontal") * speed * Time.deltaTime));
    }

    void cPrint(object mymessage)
    {
        if (controllerNumber == "1")
            Debug.Log("<color=red>" + mymessage + "</color>");
        else if (controllerNumber == "2")
            Debug.Log("<color=green>" + mymessage + "</color>");
    }
}
