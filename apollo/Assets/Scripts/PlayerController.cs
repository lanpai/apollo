using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody player;

    public float speed = 2500f;
    public float speedLimit = 12f;

    private void Update() {

        Vector3 finalMovement = Vector3.zero;

        if(Input.GetKey("w"))
        {
            finalMovement.y += 1;
        }
        if(Input.GetKey("a"))
        {
            finalMovement.x -= 1;
        }
        if(Input.GetKey("s"))
        {
            finalMovement.y -= 1;
        }
        if(Input.GetKey("d"))
        {
            finalMovement.x += 1;
        }

        player.AddForce(speed * finalMovement.normalized * Time.deltaTime);
        player.velocity = Vector3.ClampMagnitude(player.velocity, speedLimit);
    }
}
