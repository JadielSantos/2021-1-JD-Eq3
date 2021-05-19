using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public static class NameGenerator
{
    static string[] names = new string[]
    {
        ""
    };

    public static string GetRandom() => names.Random();
}
