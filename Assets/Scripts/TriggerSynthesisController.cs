using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSynthesisController : MonoBehaviour
{
    public List<ItemType> items = new List<ItemType>();

    private void OnTriggerEnter(Collider other) {
        items.Add((other.gameObject.GetComponent(typeof(Item)) as Item).getType());
        Destroy(other.gameObject);

        List<List<ItemType>> validRecipes = Recipes.CheckRecipes(items);
        if (validRecipes.Count == 1) {
            foreach (ItemType type in validRecipes[0]) {
                switch (type) {
                    case ItemType.Radio:
                        GameObject prefab = Resources.Load("Prefabs/Radio") as GameObject;
                        Instantiate(prefab, Vector3.zero + Vector3.up * 5.0f, Quaternion.identity);
                        break;
                }
            }
            items.Clear();
        }
        else if (validRecipes.Count == 0) {
            Debug.Log("No Recipes Found!");
        }
    }
}
