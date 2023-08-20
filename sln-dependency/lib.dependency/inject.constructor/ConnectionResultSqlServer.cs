namespace lib.dependency.inject.constructor;

public class ConnectionResultSqlServer : IConnectionResult
{
    private static bool _connectionStatus = false;

    public string ConnectionStatus => _connectionStatus ? "Sql Server Connection established" : "Sql Server Connection failed.";

    public IConnectionResult Connected(Func<bool> f)
    {
        _connectionStatus = f();
        return this;
    }
    
}