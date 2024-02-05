using System;
using System.Collections;
using System.Collections.Generic;

namespace Katas;

/// <summary>
/// https://www.codewars.com/kata/54da539698b8a2ad76000228/train/csharp
/// </summary>
public class TakeATenMinuteWalk
{
    private static Dictionary<string, int> lookup = new() { { "e", 1 }, { "w", -1 }, { "n", 10 }, { "s", -10 } };

    public static bool IsValidWalk(string[] walk)
    {
        if (walk.Length != 10)
        {
            return false;
        }

        var coordinates = 0;
        foreach (var direction in walk)
        {
            if (lookup.TryGetValue(direction, out var movement))
            {
                coordinates += movement;
            }
        }

        return coordinates == 0;
    }
}
