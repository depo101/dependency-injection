namespace lib.dependency.inject.constructor;

public class DatabaseLogger : ILogger
{
    public void Log(string msg)
    {
        Console.WriteLine($"The message has been log to database \n {msg}");
    }
}