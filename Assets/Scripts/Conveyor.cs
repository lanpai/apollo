using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision obj)
    {
        (obj.gameObject.GetComponent(typeof(Rigidbody)) as Rigidbody).velocity = speed * Time.deltaTime * transform.forward;
    }
}
