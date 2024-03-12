using ExInterfacesAndDepInfection.Entities;

namespace ExInterfacesAndDepInfection.Services;
internal class ContractService
{
    private IPaymentService _paymentService;

    public ContractService(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    public void ProcessContract(Contract contract, int months)
    {
        double bQuota = contract.TotalValue / months;

        for (int i = 1; i <= months; i++)
        {
            double uQuota = bQuota + _paymentService.MonthlyInterest(bQuota, i);
            double fQuota = uQuota + _paymentService.PaymentTax(uQuota);
            DateTime date = contract.Date.AddMonths(i);
            contract.Installments.Add(new Installment(date, fQuota));
        }
    }
}
