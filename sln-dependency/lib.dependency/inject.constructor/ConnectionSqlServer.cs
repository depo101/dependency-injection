namespace lib.dependency.inject.constructor;

public class ConnectionSqlServer : IConnection<IConnectionResult>
{
    private readonly IConnectionResult _connectionResult;
    public ConnectionSqlServer(IConnectionResult connectionResult)
    {
        _connectionResult = connectionResult;
    }

    public IConnectionResult Connect()
    {
        //Sql server connection operation starts here.
        return _connectionResult;
    }
}