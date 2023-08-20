namespace lib.dependency.inject.method;

public class SendMessageBySms : IMessage
{
    public void SendMessage()
    {
        Console.WriteLine("The message has been send by SMS");
    }
}