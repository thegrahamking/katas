using System;
using System.Collections;
using System.Collections.Generic;

namespace Katas;

/// <summary>
/// https://www.codewars.com/kata/54da539698b8a2ad76000228/train/csharp
/// </summary>
public class TakeATenMinuteWalk
{
    private static Dictionary<string, int> latitudes = new() { { "e", 1 }, { "w", -1 } };

    private static Dictionary<string, int> longitudes = new() { { "n", 1 }, { "s", -1 } };

    public static bool IsValidWalk(string[] walk)
    {
        if (walk.Length != 10)
        {
            return false;
        }

        var latitude = 0;
        var longitude = 0;
        foreach (var direction in walk)
        {
            if (latitudes.TryGetValue(direction, out var latitudeMovementSize))
            {
                latitude += latitudeMovementSize;
                continue;
            }

            if (longitudes.TryGetValue(direction, out var longitudeMovementSize))
            {
                longitude += longitudeMovementSize;
                continue;
            }
        }

        return latitude == 0 && longitude == 0;
    }
}
