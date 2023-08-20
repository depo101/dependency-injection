namespace lib.dependency.inject.constructor;

public class LogConsumeTwo
{
    private readonly ILogManager _logManager;
    public LogConsumeTwo(ILogManager logManager)
    {
        _logManager = logManager;
    }

    public void Test()
    {
        _logManager.Log("Hello another log");
    }
}