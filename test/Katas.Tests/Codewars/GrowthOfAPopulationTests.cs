using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Katas;

public class GrowthOfAPopulationTests
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(1500, 5, 100, 5000).Returns(15);
            yield return new TestCaseData(1500000, 2.5, 10000, 2000000).Returns(10);
            yield return new TestCaseData(1500000, 0.25, 1000, 2000000).Returns(94);
        }
    }


    [Test, TestCaseSource(nameof(TestCases))]
    public int Test(int p0, double percent, int aug, int p) => GrowthOfAPopulation.NbYear(p0, percent, aug, p);
}
