using System;
using System.Text.RegularExpressions;

namespace Katas.Codewars;

/// <summary>
///  https://www.codewars.com/kata/517abf86da9663f1d2000003/train/csharp
/// </summary>
public class ConvertStringToCamelCase
{
    private static readonly Regex regex = new("[-_]([a-zA-Z])", RegexOptions.Compiled);

    public static string ToCamelCase(string str)
    {
        return regex.Replace(str, m => m.Groups[1].Value.ToUpperInvariant());
    }
}