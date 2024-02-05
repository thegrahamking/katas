using System;
using System.Collections.Generic;
using Katas.Codewars;
using NUnit.Framework;

namespace Katas.Tests.Codewars;

[TestFixture]
public class IsogramsTests
{
    private static IEnumerable<TestCaseData> TestCases
    {
      get
      {
        yield return new TestCaseData("Dermatoglyphics").Returns(true);
        yield return new TestCaseData("isogram").Returns(true);
        yield return new TestCaseData("moose").Returns(false);
        yield return new TestCaseData("isIsogram").Returns(false);
        yield return new TestCaseData("aba").Returns(false);
        yield return new TestCaseData("moOse").Returns(false);
        yield return new TestCaseData("thumbscrewjapingly").Returns(true);
        yield return new TestCaseData("").Returns(true);
      }
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool Test(string str) => Isograms.IsIsogram(str);
}