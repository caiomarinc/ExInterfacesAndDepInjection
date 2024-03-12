namespace ExInterfacesAndDepInfection.Services;
internal class PayPalService : IPaymentService
{
    private const double _monthlyInterest = 0.01;
    private const double _paymentFee = 0.02;

    public double PaymentTax(double amount)
    {
        return amount * _paymentFee;
    }
    public double MonthlyInterest(double amount, int months)
    {
        return amount * _monthlyInterest * months;
    }
}
