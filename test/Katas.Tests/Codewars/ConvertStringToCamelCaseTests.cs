using System;
using Katas.Codewars;
using NUnit.Framework;

namespace Katas.Tests.Codewars;

[TestFixture]
public class ConvertStringToCamelCaseTests
{
    [TestCase("the_stealth_warrior", "theStealthWarrior")]
    [TestCase("The-Stealth-Warrior", "TheStealthWarrior")]
    [TestCase("The_Stealth-Warrior", "TheStealthWarrior")]
    public void KataTests(string input, string expected)
    {
        Assert.That(expected, Is.EqualTo(ConvertStringToCamelCase.ToCamelCase(input)));
    }
}