namespace lib.dependency.inject.constructor;

public class ConnectionMongoDb<TResult> : IConnection<TResult>
{
    private readonly TResult _connectionResult;
    public ConnectionMongoDb(TResult connectionResult)
    {
        _connectionResult = connectionResult;
    }
    public TResult Connect()
    {
        //MongoDb connection operations starts.
        return _connectionResult;
    }
}