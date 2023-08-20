namespace lib.dependency.inject.property;

public class PayWithCreditCard : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment has been made by credit card");
    }
}