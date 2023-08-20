namespace lib.dependency.inject.method;

public class SendMessageByWhatsApp : IMessage
{
    public void SendMessage()
    {
        Console.WriteLine("The message has been sent by WhatsApp");
    }
}