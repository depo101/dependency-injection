namespace lib.dependency.inject.constructor;

public class ConnectionResultMongoDb : IConnectionResult
{
    private static bool _connectionStatus = false;

    public string ConnectionStatus => _connectionStatus ? "MongoDb Connection established" : "MongoDb Connection failed.";

    public IConnectionResult Connected(Func<bool> f)
    {
        _connectionStatus = f();
        return this;
    }
    
}