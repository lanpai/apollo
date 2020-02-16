using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCheck : MonoBehaviour
{
    public Rigidbody rb;

    void Start() {
        rb = this.GetComponent(typeof(Rigidbody)) as Rigidbody;
    }

    private void FixedUpdate() {
        int count = 0;
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Item")) {
            if (obj.GetComponent(typeof(Oxygen)) as Oxygen != null)
                count++;
        }
        if (count >= 3)
            rb.velocity += Vector3.up * 5.0f;
    }
}
