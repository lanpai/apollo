using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUI : MonoBehaviour
{
    public TextMesh text;
    public GameObject player;

    public Dictionary<List<ItemType>, List<ItemType>> recipes;

    private void Start() 
    {
        text = GetComponentInChildren<TextMesh>();

        text.text = GetComponent<Radio>().getDescription();
        text.GetComponent<Renderer>().enabled = false;

        //recipes = Resources.Load("Scripts/Recipes");
    }
    private void Update() 
    {
        activateText();
    }
    public void activateText()
    {
        Transform closestTransformToPlayer = player.GetComponent<PlayerController>().getClosestTransform();

        Debug.Log(closestTransformToPlayer);

        if (closestTransformToPlayer == this.transform)
        {
            text.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            text.GetComponent<Renderer>().enabled = false;
        }
    }
}
