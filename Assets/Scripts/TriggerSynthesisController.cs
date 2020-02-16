using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSynthesisController : MonoBehaviour
{
    public List<Collider> elements = new List<Collider>();
    public Dictionary<ItemType, List<ItemType>> recipes;
    public List<ItemType> items = new List<ItemType>();

    private void Start() {
        recipes = Recipes.getDictionary();
    }
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
        items.Add((other.gameObject.GetComponent(typeof(Item)) as Item).getType());
        Destroy(other.gameObject);

        List<ItemType> validRecipes = Recipes.CheckRecipes(items);
        if (validRecipes.Count == 1) {
            Debug.Log(validRecipes[0]);

            switch (validRecipes[0]) {
                case ItemType.Radio:
                    GameObject prefab = Resources.Load("Prefabs/Radio") as GameObject;
                    Instantiate(prefab, Vector3.zero + Vector3.up * 5.0f, Quaternion.identity);
                    break;
            }
        }
        else if (validRecipes.Count == 0)
        {
            Debug.Log("No Recipes Found!");
        }
    }
}
