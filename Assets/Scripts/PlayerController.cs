﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody player;

    public float moveSpeed;
    public float speedLimit;

    public float rotationSpeed;

    public Animator animator;

    public Rigidbody carriedItem;
    public Rigidbody leftHand;
    public Rigidbody rightHand;

    public TextMesh text;
    public TextMesh element;

    public ParticleSystem particle;

    public Transform closestItemPos;

    public Camera camera;

    public AudioSource audio;

    private void Start() {
        carriedItem = null;
        particle.Stop();
    }

    private void FixedUpdate() {
        if (carriedItem != null && !Input.GetKey("space")) {
            carriedItem.useGravity = true;
            //carriedItem.GetComponent<Renderer>().material.shader = Shader.Find("Diffuse");
            particle.Stop();
            carriedItem = null;
            text.text = "";
            element.text = "";
        }

        Vector3 finalMovement = new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, Input.GetAxisRaw("Vertical"));

        if (Input.GetKey("space")) {
            Vector3 position = 0.5f * (leftHand.transform.position + rightHand.transform.position) +
                (player.transform.forward * -2.0f) +
                (player.transform.up * 1.0f);
            
            if (carriedItem == null) {
                audio.Play();
                float minDistance = 0.0f;
                GameObject closest = null;

                foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Item")) {
                    float distance = (position - obj.transform.position).magnitude;

                    if (closest == null || distance < minDistance) {
                        closest = obj;
                        carriedItem = obj.GetComponent(typeof(Rigidbody)) as Rigidbody;
                        minDistance = distance;
                    }
                }

                (closest.GetComponent(typeof(Rigidbody)) as Rigidbody).useGravity = false;
            }

            leftHand.AddForce(player.transform.forward * -20000.0f * Time.deltaTime);
            rightHand.AddForce(player.transform.forward * -20000.0f * Time.deltaTime);

            carriedItem.transform.position = Vector3.Lerp(carriedItem.transform.position, position, 10.0f * Time.deltaTime);
            text.text = (carriedItem.GetComponent(typeof(Item)) as Item).getDescription();
            element.text = (carriedItem.GetComponent(typeof(Item)) as Item).toString();
            
            closestItemPos = carriedItem.transform;

            if (!particle.isPlaying)
                particle.Play();
        }

        player.AddForce(moveSpeed * finalMovement.normalized * Time.deltaTime);
        if (finalMovement.magnitude > 0.01) {
            Quaternion to = Quaternion.LookRotation(-player.velocity.normalized, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, to, Time.deltaTime * rotationSpeed);
        }

        animator.SetFloat("Speed", player.velocity.magnitude / 5.0f);

        text.transform.rotation = Quaternion.LookRotation(-(camera.transform.position - text.transform.position).normalized, Vector3.up);
        element.transform.rotation = Quaternion.LookRotation(-(camera.transform.position - element.transform.position).normalized, Vector3.up);
    }
    public Transform getClosestTransform()
    {
        return closestItemPos;
    }
}
