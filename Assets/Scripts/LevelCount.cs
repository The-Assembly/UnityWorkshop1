using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCount
{
    static public int levelCount = 1;

    public static void SetCount(int newCount)
    {
        levelCount = newCount;
    }

    public static int GetCount()
    {
        return levelCount;
    }
}