using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Katas;

public class TakeATenMinuteWalkTests
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData((object)new[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }).Returns(true);
            yield return new TestCaseData((object)new[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }).Returns(false);
            yield return new TestCaseData((object)new[] { "w" }).Returns(false);
            yield return new TestCaseData((object)new[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }).Returns(false);
        }
    }


    [Test, TestCaseSource(nameof(TestCases))]
    public bool Test(string[] input) => TakeATenMinuteWalk.IsValidWalk(input);
}
