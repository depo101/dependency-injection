namespace lib.dependency.inject.property;

public class PayWithCash : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment has been made by cash");
    }
}