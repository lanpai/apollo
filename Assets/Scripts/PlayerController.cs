using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody player;

    public float moveSpeed;
    public float speedLimit;

    public float rotationSpeed;

    public Animator animator;

    private void FixedUpdate() {

        Vector3 finalMovement = new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, Input.GetAxisRaw("Vertical"));

        if (Input.GetKeyDown("q"))
            GetComponent<PlayerInteractions>().dropItem(player.transform);

        player.AddForce(moveSpeed * finalMovement.normalized * Time.deltaTime);
        if (finalMovement.magnitude > 0.01) {
            Quaternion to = Quaternion.LookRotation(-player.velocity.normalized, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, to, Time.deltaTime * rotationSpeed);
            //transform.rotation = to;
        }

        animator.SetFloat("Speed", player.velocity.magnitude / 5.0f);
        
        //player.velocity = Vector3.ClampMagnitude(player.velocity, speedLimit);
    }
}
