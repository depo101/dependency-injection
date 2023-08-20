namespace lib.dependency.inject.property;

public class PayManager
{
    private static IPayment? _payment;

    public IPayment SetPayment
    {
        set => _payment = value;
    }

    public static void Pay()
    {
        _payment?.Pay();
    }
}