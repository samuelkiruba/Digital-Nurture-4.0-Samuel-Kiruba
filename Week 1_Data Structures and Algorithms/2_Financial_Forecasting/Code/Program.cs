using System;

class FinancialForecast
{
    public static double PredictFutureValue(double presentValue, double rate, int years)
    {
        if (years == 0)
            return presentValue;
        return PredictFutureValue(presentValue, rate, years - 1) * (1 + rate);
    }

    static void Main()
    {
        double presentValue = 10000;
        double rate = 0.05;
        int years = 5;

        double futureValue = PredictFutureValue(presentValue, rate, years);
        Console.WriteLine($"Future Value after {years} years will be {futureValue:F2}");
        Console.WriteLine("\nThe time complexity of this recursive function is O(n), where n is the number of years. This is because the function makes a recursive call for each year, leading to a linear number of calls in relation to the input years.\nProblem of excessive computation can be fixed with the help of mathematical formula for compound interest.");
    }
}
