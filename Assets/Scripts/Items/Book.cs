using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : Item
{
    private int count;
    public Book(int c)
    {
        count = c;
    }
    public string getDescription()
    {
        return "";
    }

    public int getCount()
    {
        return count;
    }
}