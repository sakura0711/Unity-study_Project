using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataBase
{
    public static int score;
    public static int spawnAppleAmount;
    static DataBase()
    {
        score = 0;
        spawnAppleAmount = 50;
    }
}