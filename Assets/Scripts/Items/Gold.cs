using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Element
{
    private int count;

    public Gold(int c)
    {
        count = c;
    }

    public string getDescription()
    {
        return "Fun Fact: If you bite gold, you might break your teeth!\nAtomic Number: 79  Atomic Mass: 196.97";
    }

    public string getSymbol()
    {
        return "Au";
    }

    public int getCount()
    {
        return count;
    }
}
