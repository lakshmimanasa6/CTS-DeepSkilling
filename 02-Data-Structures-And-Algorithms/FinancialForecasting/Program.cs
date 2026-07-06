using FinancialForecasting;

double presentValue = 10000;
double growthRate = 0.10;
int years = 5;

double futureValue = FinancialForecast.PredictFutureValue(
    presentValue,
    growthRate,
    years);

Console.WriteLine("FINANCIAL FORECASTING");
Console.WriteLine("----------------------");
Console.WriteLine($"Present Value : ₹{presentValue}");
Console.WriteLine($"Growth Rate   : {growthRate * 100}%");
Console.WriteLine($"Years         : {years}");
Console.WriteLine($"Future Value  : ₹{futureValue:F2}");