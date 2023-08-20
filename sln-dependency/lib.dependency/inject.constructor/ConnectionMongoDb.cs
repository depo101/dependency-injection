namespace lib.dependency.inject.constructor;

public class ConnectionMongoDb : IConnection<IConnectionResult>
{
    private readonly IConnectionResult _connectionResult;
    public ConnectionMongoDb(IConnectionResult connectionResult)
    {
        _connectionResult = connectionResult;
    }
    public IConnectionResult Connect()
    {
        //MongoDb connection operations starts.
        return _connectionResult.Connected(()=>false);
    }
}