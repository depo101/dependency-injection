namespace lib.dependency.inject.constructor;

public class LogManager : ILogManager
{
    private readonly ILogger _logger;
    public LogManager(ILogger logger)
    {
        _logger = logger;
    }
    public void Log(string msg)
    {
        _logger.Log(msg);
    }
}