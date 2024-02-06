using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Katas;

public class FindTheOddIntTests
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData((object?)new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }).Returns(5);
        }
    }


    [Test, TestCaseSource(nameof(TestCases))]
    public int Test(int[] sequence) => FindTheOddInt.find_it(sequence);
}
