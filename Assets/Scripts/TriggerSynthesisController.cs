using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSynthesisController : MonoBehaviour
{
    public List<ItemType> items = new List<ItemType>();
    public Transform location;
    public float radius = 2.0f;

    public AudioSource audio;

    private void OnTriggerEnter(Collider other) {
        items.Add((other.gameObject.GetComponent(typeof(Item)) as Item).getType());
        Destroy(other.gameObject);
        Debug.Log(items);

        List<List<ItemType>> validRecipes = Recipes.CheckRecipes(items);
        Debug.Log(validRecipes.Count);
        if (validRecipes.Count == 1) {
            foreach (ItemType type in validRecipes[0]) {
                GameObject prefab;
                switch (type) {
                    case ItemType.Radio:
                        prefab = Resources.Load("Prefabs/Radio") as GameObject;
                        Instantiate(prefab, location.position + new Vector3(Random.Range(-radius, radius), 0.0f, Random.Range(-radius, radius)), Quaternion.identity);
                        break;
                    case ItemType.Hydrogen:
                        prefab = Resources.Load("Prefabs/Hydrogen") as GameObject;
                        Instantiate(prefab, location.position + new Vector3(Random.Range(-radius, radius), 0.0f, Random.Range(-radius, radius)), Quaternion.identity);
                        break;
                    case ItemType.Carbon:
                        prefab = Resources.Load("Prefabs/Carbon") as GameObject;
                        Instantiate(prefab, location.position + new Vector3(Random.Range(-radius, radius), 0.0f, Random.Range(-radius, radius)), Quaternion.identity);
                        break;
                    case ItemType.Copper:
                        prefab = Resources.Load("Prefabs/Copper") as GameObject;
                        Instantiate(prefab, location.position + new Vector3(Random.Range(-radius, radius), 0.0f, Random.Range(-radius, radius)), Quaternion.identity);
                        break;
                    case ItemType.Iron:
                        prefab = Resources.Load("Prefabs/Iron") as GameObject;
                        Instantiate(prefab, location.position + new Vector3(Random.Range(-radius, radius), 0.0f, Random.Range(-radius, radius)), Quaternion.identity);
                        break;
                    case ItemType.Silicon:
                        prefab = Resources.Load("Prefabs/Silicon") as GameObject;
                        Instantiate(prefab, location.position + new Vector3(Random.Range(-radius, radius), 0.0f, Random.Range(-radius, radius)), Quaternion.identity);
                        break;
                    case ItemType.Aluminum:
                        prefab = Resources.Load("Prefabs/Aluminum") as GameObject;
                        Instantiate(prefab, location.position + new Vector3(Random.Range(-radius, radius), 0.0f, Random.Range(-radius, radius)), Quaternion.identity);
                        break;
                    case ItemType.Oxygen:
                        prefab = Resources.Load("Prefabs/Oxygen") as GameObject;
                        Instantiate(prefab, location.position + new Vector3(Random.Range(-radius, radius), 0.0f, Random.Range(-radius, radius)), Quaternion.identity);
                        break;
                    case ItemType.FuelStorage:
                        prefab = Resources.Load("Prefabs/FuelStorage") as GameObject;
                        Instantiate(prefab, location.position + new Vector3(Random.Range(-radius, radius), 0.0f, Random.Range(-radius, radius)), Quaternion.identity);
                        break;
                }
            }
            items.Clear();
            audio.Play();
        }
        else if (validRecipes.Count == 0) {
            Debug.Log("No Recipes Found!");
        }
    }
}
