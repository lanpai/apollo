using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelStorage : MonoBehaviour, Item
{
    public Color color = new Color(0.65f, 0.01f, 0.00f);

    private int count;

    public FuelStorage(int c) => count = c;

    public string getDescription() => "Stores fuel from the spacecraft.";

    public int getCount() => count;

    Element[] getElements()
    {
        Element[] e = { new Titanium(6), new Aluminum(6) };
        return e;
    }
}