using System;

class PriceChangeAlert
{
    static void Main()
    {
        int pricesCount = int.Parse(Console.ReadLine());
        double treshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < pricesCount - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double priceDiff = PriceDiff(lastPrice, currentPrice);
            bool isSignificantDifference = imaliDif(priceDiff, treshold);
            string message = GetOutput(currentPrice, lastPrice, priceDiff, isSignificantDifference);
            Console.WriteLine(message);
            lastPrice = currentPrice;
        }
    }

    private static string GetOutput(double currentPrice, double lastPrice, double priceDiff, bool isSignificantDifference)
    {
        string outputString = string.Empty;
        if (priceDiff == 0)
        {
            outputString = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificantDifference)
        {
            outputString = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, priceDiff * 100);
        }
        else if (isSignificantDifference && (priceDiff > 0))
        {
            outputString = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, priceDiff * 100);
        }
        else if (isSignificantDifference && (priceDiff < 0))
            outputString = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, priceDiff * 100);
        return outputString;
    }
    private static bool imaliDif(double granica, double isDiff)
    {
        if (Math.Abs(granica) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double PriceDiff(double lastPrice, double currentPrice)
    {
        double result = (currentPrice - lastPrice) / lastPrice;
        return result;
    }
}
