using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    public GameObject itemPrefab;
    
    public float forwardOffset;
    public float armSwingStrength;

    public void dropItem(Transform player)
    {
        float playerRadius = player.GetComponent<CapsuleCollider>().radius;
        float playerHeight = player.GetComponent<CapsuleCollider>().height;

        Vector3 itemDropOffset = (player.transform.position - player.transform.forward * playerRadius * forwardOffset) + (0.5f * new Vector3(0, playerHeight, 0));

        GameObject item = Instantiate(itemPrefab, itemDropOffset, transform.rotation) as GameObject;

        //player.GetChild(0).GetChild(0).GetChild(0).GetComponent<Rigidbody>().AddForce(Vector3.forward * armSwingStrength);
        //player.GetChild(0).GetChild(1).GetChild(0).GetComponent<Rigidbody>().AddForce(Vector3.forward * armSwingStrength);
    }
}
