using System.Collections.Generic;
using UnityEngine;

public class Recipes : MonoBehaviour
{

    public static Dictionary<List<ItemType>, List<ItemType>> recipes = new Dictionary<List<ItemType>, List<ItemType>>();

    static Recipes()
    {

        recipes.Add( //kerosene
            new List<ItemType> { ItemType.Carbon, ItemType.Carbon, ItemType.Carbon, ItemType.Carbon, ItemType.Carbon, ItemType.Hydrogen, ItemType.Hydrogen, ItemType.Hydrogen, ItemType.Hydrogen, ItemType.Hydrogen, ItemType.Hydrogen },
            new List<ItemType> { ItemType.Kerosene });
        recipes.Add( //kerosene
            new List<ItemType> { ItemType.Kerosene },
            new List<ItemType> { ItemType.Carbon, ItemType.Carbon, ItemType.Carbon, ItemType.Carbon, ItemType.Carbon, ItemType.Hydrogen, ItemType.Hydrogen, ItemType.Hydrogen, ItemType.Hydrogen, ItemType.Hydrogen, ItemType.Hydrogen });

        recipes.Add( //antenna
            new List<ItemType> { ItemType.Iron, ItemType.Iron, ItemType.Iron },
            new List<ItemType> { ItemType.Antenna });
        recipes.Add( //antenna
            new List<ItemType> { ItemType.Antenna },
            new List<ItemType> { ItemType.Iron, ItemType.Iron, ItemType.Iron });

        recipes.Add( //radio
            new List<ItemType> { ItemType.Copper, ItemType.Lithium, ItemType.Gold, ItemType.Aluminum }, //output
            new List<ItemType> { ItemType.Radio }); //input
        recipes.Add( //radio
            new List<ItemType> { ItemType.Radio },
            new List<ItemType> { ItemType.Copper, ItemType.Lithium, ItemType.Gold, ItemType.Aluminum }); //output

        recipes.Add( //pillow
            new List<ItemType> { ItemType.Carbon, ItemType.Hydrogen, ItemType.Hydrogen, ItemType.Oxygen },
            new List<ItemType> { ItemType.Pillow });
        recipes.Add( //pillow
            new List<ItemType> { ItemType.Pillow },
            new List<ItemType> { ItemType.Carbon, ItemType.Hydrogen, ItemType.Hydrogen, ItemType.Oxygen });

        recipes.Add( //flag
            new List<ItemType> { ItemType.Carbon, ItemType.Carbon, ItemType.Carbon, ItemType.Hydrogen, ItemType.Hydrogen, ItemType.Oxygen },
            new List<ItemType> { ItemType.Flag });
        recipes.Add( //flag
            new List<ItemType> { ItemType.Flag },
            new List<ItemType> { ItemType.Carbon, ItemType.Carbon, ItemType.Carbon, ItemType.Hydrogen, ItemType.Hydrogen, ItemType.Oxygen });

        recipes.Add( //laptop
            new List<ItemType> { ItemType.Carbon, ItemType.Carbon, ItemType.Aluminum, ItemType.Germanium, ItemType.Silicon, ItemType.Silicon },
            new List<ItemType> { ItemType.Laptop });
        recipes.Add( //laptop
           new List<ItemType> { ItemType.Laptop },
           new List<ItemType> { ItemType.Carbon, ItemType.Carbon, ItemType.Aluminum, ItemType.Germanium, ItemType.Silicon, ItemType.Silicon });

        recipes.Add( //seats
            new List<ItemType> { ItemType.Carbon, ItemType.Carbon, ItemType.Hydrogen, ItemType.Hydrogen },
            new List<ItemType> { ItemType.Seats });
        recipes.Add( //seats
           new List<ItemType> { ItemType.Seats },
           new List<ItemType> { ItemType.Carbon, ItemType.Carbon, ItemType.Hydrogen, ItemType.Hydrogen });

        recipes.Add( //Inner Wall
            new List<ItemType> { ItemType.Aluminum, ItemType.Aluminum, ItemType.Titanium, ItemType.Titanium },
            new List<ItemType> { ItemType.InnerWall });
        recipes.Add( //Inner Wall
            new List<ItemType> { ItemType.InnerWall },
            new List<ItemType> { ItemType.Aluminum, ItemType.Aluminum, ItemType.Titanium, ItemType.Titanium });

        recipes.Add( //mattress
            new List<ItemType> { ItemType.Carbon, ItemType.Carbon, ItemType.Hydrogen, ItemType.Hydrogen },
            new List<ItemType> { ItemType.Mattress });
        recipes.Add( //mattress
            new List<ItemType> { ItemType.Mattress },
            new List<ItemType> { ItemType.Carbon, ItemType.Carbon, ItemType.Hydrogen, ItemType.Hydrogen });

        recipes.Add( //oven
            new List<ItemType> { ItemType.Iron, ItemType.Iron, ItemType.Iron, ItemType.Carbon, ItemType.Carbon, ItemType.Copper },
            new List<ItemType> { ItemType.Oven });
        recipes.Add( //oven
            new List<ItemType> { ItemType.Oven },
            new List<ItemType> { ItemType.Iron, ItemType.Iron, ItemType.Iron, ItemType.Carbon, ItemType.Carbon, ItemType.Copper });

        recipes.Add( //clothing
            new List<ItemType> { ItemType.Carbon, ItemType.Carbon, ItemType.Hydrogen, ItemType.Carbon, ItemType.Carbon },
            new List<ItemType> { ItemType.Clothing });
        recipes.Add( //clothing
            new List<ItemType> { ItemType.Clothing },
            new List<ItemType> { ItemType.Carbon, ItemType.Carbon, ItemType.Hydrogen, ItemType.Carbon, ItemType.Carbon });

        recipes.Add( //glass cup
            new List<ItemType> { ItemType.Silicon, ItemType.Oxygen, ItemType.Oxygen, ItemType.Aluminum },
            new List<ItemType> { ItemType.GlassCup });
        recipes.Add( //glass cup
            new List<ItemType> { ItemType.GlassCup },
            new List<ItemType> { ItemType.Silicon, ItemType.Oxygen, ItemType.Oxygen, ItemType.Aluminum });

        recipes.Add( //book
            new List<ItemType> { ItemType.Carbon, ItemType.Oxygen, ItemType.Hydrogen },
            new List<ItemType> { ItemType.Book });
        recipes.Add( //book
            new List<ItemType> { ItemType.Book },
            new List<ItemType> { ItemType.Carbon, ItemType.Oxygen, ItemType.Hydrogen });

        recipes.Add( //cell phone
            new List<ItemType> { ItemType.Aluminum, ItemType.Lithium, ItemType.Silicon, ItemType.Nickel, ItemType.Gold },
            new List<ItemType> { ItemType.CellPhone });
        recipes.Add( //cell phone
            new List<ItemType> { ItemType.CellPhone },
            new List<ItemType> { ItemType.Aluminum, ItemType.Lithium, ItemType.Silicon, ItemType.Nickel, ItemType.Gold });

        recipes.Add( //water bottle
            new List<ItemType> { ItemType.Iron, ItemType.Carbon, ItemType.Carbon, ItemType.Hydrogen, ItemType.Hydrogen },
            new List<ItemType> { ItemType.WaterBottle });
        recipes.Add( //water bottle
            new List<ItemType> { ItemType.WaterBottle },
            new List<ItemType> { ItemType.Iron, ItemType.Carbon, ItemType.Carbon, ItemType.Hydrogen, ItemType.Hydrogen });

        recipes.Add( //utensil
            new List<ItemType> { ItemType.Carbon, ItemType.Hydrogen },
            new List<ItemType> { ItemType.Utensil });
        recipes.Add( //utensil
            new List<ItemType> { ItemType.Utensil },
            new List<ItemType> { ItemType.Carbon, ItemType.Hydrogen });

        recipes.Add( //server
            new List<ItemType> { ItemType.Carbon, ItemType.Carbon, ItemType.Carbon, ItemType.Carbon, ItemType.Aluminum, ItemType.Aluminum, ItemType.Germanium, ItemType.Silicon, ItemType.Silicon, ItemType.Silicon, ItemType.Silicon },
            new List<ItemType> { ItemType.Server });

        recipes.Add( //liquid oxygen
            new List<ItemType> { ItemType.Oxygen, ItemType.Oxygen, ItemType.Oxygen, ItemType.Oxygen, ItemType.Oxygen, ItemType.Oxygen },
            new List<ItemType> { ItemType.LiquidOx });
        recipes.Add( //liquid oxygen
            new List<ItemType> { ItemType.LiquidOx },
            new List<ItemType> { ItemType.Oxygen, ItemType.Oxygen, ItemType.Oxygen, ItemType.Oxygen, ItemType.Oxygen, ItemType.Oxygen });

        recipes.Add( //oxygen tank
            new List<ItemType> { ItemType.Iron, ItemType.Iron, ItemType.Carbon, ItemType.Hydrogen },
            new List<ItemType> { ItemType.OxygenTank });
        recipes.Add( //oxygen tank
            new List<ItemType> { ItemType.OxygenTank },
            new List<ItemType> { ItemType.Iron, ItemType.Iron, ItemType.Carbon, ItemType.Hydrogen });

        recipes.Add( //fuel tank
            new List<ItemType> { ItemType.Iron, ItemType.Aluminum, ItemType.Carbon, ItemType.Iron, ItemType.Aluminum, ItemType.Carbon, ItemType.Iron, ItemType.Aluminum, ItemType.Carbon, ItemType.Iron, ItemType.Aluminum, ItemType.Carbon },
            new List<ItemType> { ItemType.FuelStorage });
        recipes.Add( //fuel tank
            new List<ItemType> { ItemType.FuelStorage },
            new List<ItemType> { ItemType.Iron, ItemType.Aluminum, ItemType.Carbon, ItemType.Iron, ItemType.Aluminum, ItemType.Carbon, ItemType.Iron, ItemType.Aluminum, ItemType.Carbon, ItemType.Iron, ItemType.Aluminum, ItemType.Carbon });

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
