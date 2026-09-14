using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] responseTimes =
        {
            118, 126, 121, 135, 129,
            116, 132, 124, 127, 122
        };

        double confidenceLevel = 0.95;

        double mean = Mean(responseTimes);
        double standardDeviation = StandardDeviation(responseTimes);
        double standardError = StandardError(standardDeviation, responseTimes.Length);
        double criticalValue = CriticalValue(confidenceLevel);
        double marginOfError = criticalValue * standardError;

        double lowerBound = mean - marginOfError;
        double upperBound = mean + marginOfError;

        Console.WriteLine($"Sample size: {responseTimes.Length}");
        Console.WriteLine($"Mean: {mean:F2} ms");
        Console.WriteLine($"Standard deviation: {standardDeviation:F2} ms");
        Console.WriteLine($"Standard error: {standardError:F2} ms");
        Console.WriteLine($"Confidence level: {confidenceLevel:P0}");
        Console.WriteLine($"Critical value: {criticalValue}");
        Console.WriteLine($"Margin of error: {marginOfError:F2} ms");

        Console.WriteLine();
        Console.WriteLine(
            $"Confidence interval: [{lowerBound:F2}, {upperBound:F2}] ms"
        );
    }

    static double Mean(double[] data)
    {
        return data.Average();
    }

    static double StandardDeviation(double[] data)
    {
        double mean = Mean(data);

        double sumSquaredDifferences =
            data.Sum(value => Math.Pow(value - mean, 2));

        return Math.Sqrt(
            sumSquaredDifferences / (data.Length - 1)
        );
    }

    static double StandardError(
        double standardDeviation,
        int sampleSize)
    {
        return standardDeviation / Math.Sqrt(sampleSize);
    }

    static double CriticalValue(double confidenceLevel)
    {
        return confidenceLevel switch
        {
            0.90 => 1.645,
            0.95 => 1.96,
            0.99 => 2.576,
            _ => throw new ArgumentException(
                "Supported confidence levels: 0.90, 0.95, 0.99"
            )
        };
    }
}