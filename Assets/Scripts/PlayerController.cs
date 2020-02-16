using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody player;

    public float moveSpeed;
    public float moveSpeedConstant;
    public float speedLimit;

    public float rotationSpeed;

    private void FixedUpdate() {

        Vector3 finalMovement = Vector3.zero;
        float currentRotation = player.transform.rotation.eulerAngles.y;

        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKey("w"))
            finalMovement.z += moveVertical;
        if (Input.GetKey("a"))
            finalMovement.x += moveHorizontal;      
        if (Input.GetKey("s"))
            finalMovement.z += moveVertical;
        if (Input.GetKey("d"))
            finalMovement.x += moveHorizontal;
        if (Input.GetKeyDown("q"))
            GetComponent<PlayerInteractions>().dropItem(player.transform);

        player.AddForce(Vector3.ClampMagnitude(moveSpeedConstant + moveSpeed * finalMovement.normalized * Time.deltaTime, speedLimit));

        transform.rotation = Quaternion.LookRotation(-player.velocity);
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
