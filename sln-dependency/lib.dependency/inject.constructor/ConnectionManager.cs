namespace lib.dependency.inject.constructor;

public class ConnectionManager
{
    private readonly IConnection<IConnectionResult> _conn;
    public ConnectionManager(IConnection<IConnectionResult> conn)
    {
        _conn = conn;
    }

    public IConnectionResult ConnectDb()
    {
        return _conn.Connect();
    }
}