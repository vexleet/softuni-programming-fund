using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double currentPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double newPrice = double.Parse(Console.ReadLine());
            double differenceBetweenPrices = GetTheDifferenceBetweenPrices(currentPrice, newPrice);
            bool isSignificantDifference = CheckForDifference(differenceBetweenPrices, threshold);

            string message = MessageUser(newPrice, currentPrice, differenceBetweenPrices, isSignificantDifference);
            Console.WriteLine(message);

            currentPrice = newPrice;
        }
    }

    private static string MessageUser(double price, double currentPrice, double difference, bool checkForDifference)
    {
        string message = "";
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", price);
        }
        else if (!checkForDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", currentPrice, price, difference * 100);
        }
        else if (checkForDifference && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", currentPrice, price, difference * 100);
        }
        else if (checkForDifference && (difference < 0))
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", currentPrice, price, difference * 100);
        return message;
    }
    private static bool CheckForDifference(double thresholdPrice, double isDiff)
    {
        if (Math.Abs(thresholdPrice) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double GetTheDifferenceBetweenPrices(double currentPrice, double newPrice)
    {
        double differenceInPrices = (newPrice - currentPrice) / currentPrice;
        return differenceInPrices;
    }
}






//    {
//        string to = "";
//        if (razlika == 0)
//        {
//            to = string.Format("NO CHANGE: {0}", c);
//        }
//        else if (!etherTrueOrFalse)
//        {
//            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, razlika);
//        }
//        else if (etherTrueOrFalse && (razlika > 0))
//        {
//            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, razlika);
//        }
//        else if (etherTrueOrFalse && (razlika < 0))
//            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, razlika);
//        return to;
//    }
//    private static bool imaliDif(double granica, double isDiff)
//    {
//        if (Math.Abs(granica) >= isDiff)
//        {
//            return true;
//        }
//        return false;
//    }

//    private static double Proc(double l, double c)
//    {
//        double r = (c - l) / l;
//        return r;
//    }
//}
