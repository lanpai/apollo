using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;

    public float cameraEase;
    public Vector3 cameraOffset;
    
    private Camera camera;

    private void Start() {
        camera = GetComponent<Camera>();
    }
    private void FixedUpdate() {
        transform.position = Vector3.Lerp(transform.position, playerTransform.position + cameraOffset, cameraEase * Time.deltaTime);

        RaycastHit hit;
        Vector3 direction = (camera.transform.position - playerTransform.position).normalized;
        if (Physics.Raycast(playerTransform.position, direction, out hit, (camera.transform.position - playerTransform.position).magnitude, ~(LayerMask.GetMask("Ragdoll")))) {
            transform.position = hit.point - direction * 0.1f;
        }
    }
}
