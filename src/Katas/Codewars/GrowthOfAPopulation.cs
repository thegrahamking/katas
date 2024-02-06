using System;

namespace Katas;

/// <summary>
/// https://www.codewars.com/kata/563b662a59afc2b5120000c6/train/csharp
/// </summary>
public class GrowthOfAPopulation
{
    public static int NbYear(int p0, double percent, int aug, int p)
    {
        int currentPopulation = p0;
        var migrantsInPerYear = aug;
        var percentageIncreasePerYear = percent / 100;

        var expectedPopulation = p;

        var years = 0;

        while (currentPopulation < expectedPopulation)
        {
            var populationGrowth = (int)(currentPopulation * percentageIncreasePerYear);
            currentPopulation = currentPopulation + populationGrowth + migrantsInPerYear;
            years++;
        }

        return years;
    }
}
