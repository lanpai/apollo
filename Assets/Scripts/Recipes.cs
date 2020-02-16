using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipes : MonoBehaviour
{

    public static Dictionary<ItemType, List<ItemType>> recipes = new Dictionary<ItemType, List<ItemType>>();

    static Recipes() 
    {
        recipes.Add(ItemType.Radio, new List<ItemType>{ 
            ItemType.Radio});
    }
    public static Dictionary<ItemType, List<ItemType>> getDictionary()
    {
        return recipes;
    }

    public static List<ItemType> CheckRecipes(List<ItemType> items) {
        List<ItemType> results = new List<ItemType>();

        Debug.Log(recipes.Count);

        foreach (KeyValuePair<ItemType, List<ItemType>> i in recipes) {

            Debug.Log(i.Key);
            Debug.Log(i.Value);
            
            bool recipeValid = true;
            foreach (ItemType requirement in i.Value) {
                bool reqFound = false;
                foreach (ItemType item in items) {
                    if (item == requirement) {
                        reqFound = true;
                        break;
                    }
                }
                
                if (!reqFound) {
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
