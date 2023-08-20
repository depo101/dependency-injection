namespace lib.dependency.inject.constructor;

public class LogConsumeOne
{
    private readonly ILogManager _logManager;
    public LogConsumeOne(ILogManager logManager)
    {
        _logManager = logManager;
    }

    public void Test()
    {
        _logManager.Log("Hello Log");
    }
}