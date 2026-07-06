namespace FinancialForecasting
{
    public class FinancialForecast
    {
        public static double PredictFutureValue(double amount, double rate, int years)
        {
            if (years == 0)
            {
                return amount;
            }

            return PredictFutureValue(amount * (1 + rate), rate, years - 1);
        }
    }
}