using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSynthesisController : MonoBehaviour
{
    public List<Collider> elements = new List<Collider>();

    private void Update() 
    {
        foreach (Collider i in elements)
        {
            if (i == null)
            {
                elements.Remove(i);
            }
        }
    }
    private void OnTriggerEnter(Collider other) {
        elements.Add(other);
        Destroy(other);
        foreach (Collider i in elements)
        {
            print(i);            
        }
    }
}
