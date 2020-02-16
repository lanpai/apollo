using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour, Item
{
    public Color color = new Color(0.57f, 0.36f, 0.05f);
    private int count;

    public Book(int c) => count = c;

    public string getDescription() => "What do you call 2000 mockingbirds? Two kilo mockingbird.";

    public int getCount() => count;

    public Element[] getElements()
    {
        Element[] elm = { new Carbon(6), new Hydrogen(10), new Oxygen(5) };
        return elm;
    }
}