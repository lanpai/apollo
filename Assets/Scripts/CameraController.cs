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
    }
}
