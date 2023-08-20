namespace lib.dependency.inject.constructor;

public class ConnectionSqlServer<TResult> : IConnection<TResult> where TResult : IConnectionResult
{
    private readonly TResult _connectionResult;
    public ConnectionSqlServer(TResult connectionResult)
    {
        _connectionResult = connectionResult;
    }

    public TResult Connect()
    {
        //Sql server connection operation starts here.
        return _connectionResult;
    }
}