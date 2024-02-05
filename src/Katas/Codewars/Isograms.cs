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
        return str.Length == new HashSet<char>(str.ToLowerInvariant().ToCharArray()).Count;
    }
}
