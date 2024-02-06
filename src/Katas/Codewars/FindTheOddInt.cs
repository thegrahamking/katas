using System;
using System.Linq;

namespace Katas;

/// <summary>
/// https://www.codewars.com/kata/54da5a58ea159efa38000836
/// </summary>
public class FindTheOddInt
{
    public static int find_it(int[] seq)
    {
        return seq
            .GroupBy(value => value)
            .Single(group => group.Count() % 2 == 1)
            .Key;
    }

}
