﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{
    [SerializeField] float damageToDeal, stun;
    [SerializeField] Vector3 knockback;
    [SerializeField] GameObject owner;

    Vector3 bufferVector = new Vector3(0, 0, 0);

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.Equals(owner))
            DealDamage(other.gameObject);
    }

    public void DealDamage(GameObject target)
    {
        if (target.GetComponent<PlayerController>())
        {
            target.GetComponent<PlayerController>().AddDamage(damageToDeal, stun);
            bufferVector.Set(knockback.x * owner.GetComponent<PlayerController>().GetBodyRotation(), knockback.y, knockback.y);
            //bufferVector *= owner.GetComponent<PlayerController>().GetBodyRotation();
            Debug.Log(owner.transform.localEulerAngles);
            target.GetComponent<Rigidbody>().AddForce(bufferVector * target.GetComponent<PlayerController>().GetDamage());
        }
    }
}
