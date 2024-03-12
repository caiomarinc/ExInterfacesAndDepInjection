namespace ExInterfacesAndDepInfection.Services;
internal interface IPaymentService
{
    double PaymentTax(double amount);
    double MonthlyInterest(double amount, int months);
}
