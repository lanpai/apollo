using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour, Item
{
    private int count;
    public Window(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        return "Watch you gaze at the abyss of nothingness before you and realize your irrelevancy to the rest of the universe. Oh hey, a star.";
    }

    public int getCount()
    {
        return count;
    }

    public Element[] getElements()
    {
        Element[] elm = {new Silicon(1), new Oxygen(2)};
        return elm;
    }
}