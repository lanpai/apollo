using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.Log(contact.otherCollider.GetComponent<Rigidbody>());
            contact.otherCollider.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
