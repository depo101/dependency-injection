namespace lib.dependency.inject.method;

public class MessageManager
{
    public static void SendMessage(IMessage message)
    {
        message.SendMessage();
    }
}