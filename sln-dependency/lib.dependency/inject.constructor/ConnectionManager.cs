namespace lib.dependency.inject.constructor;

public class ConnectionManager<TConnResult> where TConnResult:IConnectionResult
{
    private readonly IConnection<TConnResult> _conn;
    public ConnectionManager(IConnection<TConnResult> conn)
    {
        _conn = conn;
    }

    public TConnResult ConnectDb()
    {
        return _conn.Connect();
    }
}