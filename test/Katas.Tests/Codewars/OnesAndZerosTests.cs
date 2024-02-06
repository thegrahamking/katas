using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Katas;

public class OnesAndZerosTests
{
    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData((object?)new int[]{0,0,0,0}).Returns(0);
            yield return new TestCaseData((object?)new int[]{1,1,1,1}).Returns(15);
            yield return new TestCaseData((object?)new int[]{0,1,1,0}).Returns(6);
            yield return new TestCaseData((object?)new int[]{0,1,0,1}).Returns(5);
        }
    }


    [Test, TestCaseSource(nameof(TestCases))]
    public int Test(int[] binaryArray) => OnesAndZeros.binaryArrayToNumber(binaryArray);
}
