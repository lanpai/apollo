using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    public GameObject itemPrefab;

    public void dropItem(Transform player)
    {
        print("dropitem");
        GameObject item = Instantiate(itemPrefab) as GameObject;
        item.transform.position = player.position;
        item.GetComponent<Rigidbody>().velocity += Vector3.forward;
    }
}
