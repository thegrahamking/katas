using System;

namespace Katas;

/// <summary>
/// https://www.codewars.com/kata/578553c3a1b8d5c40300037c/train/csharp
/// </summary>
public class OnesAndZeros
{
    public static int binaryArrayToNumber(int[] BinaryArray)
    {
        return Convert.ToInt32(string.Join(string.Empty, BinaryArray), 2);
    }
}
