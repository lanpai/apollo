using System.Collections.Generic;
using UnityEngine;

public class Recipes : MonoBehaviour
{

    public static Dictionary<List<ItemType>, List<ItemType>> recipes = new Dictionary<List<ItemType>, List<ItemType>>();

    static Recipes()
    {
        recipes.Add( //radio
            new List<ItemType> { ItemType.Copper, ItemType.Lithium, ItemType.Gold, ItemType.Aluminum }, //output
            new List<ItemType> { ItemType.Radio }); //input

        recipes.Add( //oven
            new List<ItemType> { ItemType.Iron, ItemType.Iron, ItemType.Iron, ItemType.Carbon, ItemType.Carbon, ItemType.Copper },
            new List<ItemType> { ItemType.Oven });

        recipes.Add( //book
            new List<ItemType> { ItemType.Carbon, ItemType.Oxygen, ItemType.Hydrogen },
            new List<ItemType> { ItemType.Book });

        recipes.Add( //fuel tank
            new List<ItemType> { ItemType.FuelStorage },
            new List<ItemType> { ItemType.Carbon, ItemType.Aluminum, ItemType.Carbon, ItemType.Aluminum, ItemType.Iron, ItemType.Iron });

        recipes.Add(
            new List<ItemType> { ItemType.Silicon, ItemType.Oxygen, ItemType.Oxygen, ItemType.Aluminum },
            new List<ItemType> { ItemType.GlassCup });
    }

    public static List<List<ItemType>> CheckRecipes(List<ItemType> items)
    {
        List<List<ItemType>> results = new List<List<ItemType>>();

        Debug.Log("check");

        foreach (KeyValuePair<List<ItemType>, List<ItemType>> i in recipes)
        {
            bool recipeValid = true;
            foreach (ItemType requirement in i.Value)
            {
                bool reqFound = false;
                foreach (ItemType item in items)
                {
                    if (item == requirement)
                    {
                        reqFound = true;
                        break;
                    }
                }

                if (!reqFound)
                {
                    recipeValid = false;
                    break;
                }
            }

            if (recipeValid)
                results.Add(i.Key);
        }

        return results;
    }
}
