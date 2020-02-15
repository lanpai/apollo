using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody player;

    public float speed;
    public float speedLimit;

    public float rotationSpeed;

    private void Update() {

        Vector3 finalMovement = Vector3.zero;

        if(Input.GetKey("w"))
        {
            finalMovement.z += 1;
        }
        if(Input.GetKey("a"))
        {
            finalMovement.x -= 1;
        }
        if(Input.GetKey("s"))
        {
            finalMovement.z -= 1;
        }
        if(Input.GetKey("d"))
        {
            finalMovement.x += 1;
            if(player.transform.rotation.eulerAngles.y <= 90)
            {
                player.transform.Rotate(Vector3.ClampMagnitude(new Vector3(0, rotationSpeed, 0), 90), Space.Self);
            }
        }
        if(Input.GetKey("q"))
        {
            GetComponent<PlayerInteractions>().dropItem(player.transform);
        }

        player.AddForce(speed * finalMovement.normalized * Time.deltaTime);
        player.velocity = Vector3.ClampMagnitude(player.velocity, speedLimit);
        
    }
}
