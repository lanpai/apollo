using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody player;

    public float speed;
    public float speedLimit;

    public float rotationSpeed;

    private void FixedUpdate() {

        Vector3 finalMovement = Vector3.zero;
        float currentRotation = player.transform.rotation.eulerAngles.y;

        print(currentRotation);

        if (Input.GetKey("w"))
        {
            finalMovement.z += 1;
            if (currentRotation > 180)
            {
                ccwRotation();
            }
            else {
                cwRotation();
            }
        }
        if (Input.GetKey("a"))
        {
            finalMovement.x -= 1;
            if (currentRotation < 270 && currentRotation > 90)
            {
                ccwRotation();
            }
            else {
                cwRotation();
            }
            
        }
        if (Input.GetKey("s"))
        {
            finalMovement.z -= 1;
            if (currentRotation > 0 && currentRotation < 180)
            {
                ccwRotation();
            }
            else {
                cwRotation();
            }
        }
        if (Input.GetKey("d"))
        {
            finalMovement.x += 1;
            if (currentRotation > 270 || currentRotation < 90)
            {
                ccwRotation();
            }
            else {
                cwRotation();
            }
        }
        if (Input.GetKeyDown("q"))
        {
            GetComponent<PlayerInteractions>().dropItem(player.transform);
        }

        player.AddForce(speed * finalMovement.normalized * Time.deltaTime);
        player.velocity = Vector3.ClampMagnitude(player.velocity, speedLimit);
        
    }
    private void cwRotation()
    {
        player.transform.Rotate(Vector3.ClampMagnitude(new Vector3(0, rotationSpeed, 0), 90) * Time.deltaTime, Space.Self);
    }
    private void ccwRotation()
    {
        player.transform.Rotate(Vector3.ClampMagnitude(new Vector3(0, -rotationSpeed, 0), 90) * Time.deltaTime, Space.Self);
    }
}
