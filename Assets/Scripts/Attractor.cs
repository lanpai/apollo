using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{

    const float G = 15f;

    public static List<Attractor> Attractors;
    public Rigidbody rb;

    private void FixedUpdate() 
    {
        foreach (Attractor a in Attractors)
        {
            if (a != this)
                Attract(a);
        }
    }
    private void OnEnable() 
    {
        if (Attractors == null)
            Attractors = new List<Attractor>();
        
        Attractors.Add(this);    
    }
    private void OnDisable() 
    {
        Attractors.Remove(this);
    }
    void Attract (Attractor otherObj)
    {
        Rigidbody otherRb = otherObj.rb;

        Vector3 direction = rb.position - otherRb.position;
        float distance = direction.magnitude;

        float universalForceMagnitude = G * (rb.mass * otherRb.mass) / Mathf.Pow(distance, 2);

        Vector3 force = direction.normalized * universalForceMagnitude;

        otherRb.AddForce(force);
    }
}
