using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    public GameObject itemPrefab;

    public void dropItem(Transform player)
    {
        float playerRadius = player.GetComponent<CapsuleCollider>().radius;
        float playerHeight = player.GetComponent<CapsuleCollider>().height;

        Vector3 itemDropOffset = (player.transform.position - player.transform.forward * playerRadius * 1.5f) + (0.5f * new Vector3(0, playerHeight, 0));

        GameObject item = Instantiate(itemPrefab, itemDropOffset, transform.rotation) as GameObject;
    }
}
