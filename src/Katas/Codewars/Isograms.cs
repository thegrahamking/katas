using System;
using System.Collections.Generic;

namespace Katas;

public class Isograms
{
    /// <summary>
    /// https://www.codewars.com/kata/54ba84be607a92aa900000f1/csharp
    /// </summary>
    public static bool IsIsogram(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return true;
        }

        var letters = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
        foreach (var letter in str)
        {
            if (!letters.Add(letter.ToString()))
            {
                return false;
            }
        }

        return true;
    }
}
