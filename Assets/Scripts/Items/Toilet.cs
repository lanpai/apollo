using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet : MonoBehaviour, Item
{
    private int count;
    public Toilet(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        return "What happened to the fly on the toilet seat? It got pissed off.";
    }

    public int getCount()
    {
        return count;
    }

    public Element[] getElements()
    {
        Element[] elm = {new Silicon(1), new Aluminum(2), new Oxygen(5)};
        return elm;
    }
}