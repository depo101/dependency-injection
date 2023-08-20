namespace lib.dependency.inject.constructor;

public class FileLogger : ILogger
{
    public void Log(string msg)
    {
        Console.WriteLine($"The message has been logged to file. \n {msg} ");
    }
}