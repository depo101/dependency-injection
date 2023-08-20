namespace lib.dependency.inject.constructor;

public class ConnectionManager : IConnectionManager
{
    private readonly IConnection<IConnectionResult> _conn;
    private readonly ConnType _connType;
    public ConnectionManager(ConnType connType)
    {
        _connType = connType;
        _conn = GetConnection();
    }
    IConnection<IConnectionResult> GetSqlServerConnection()
    {
        var sqlConnResult = new ConnectionResultSqlServer();
        var sqlConn = new ConnectionSqlServer<IConnectionResult>(sqlConnResult);
        return sqlConn;
    }

    IConnection<IConnectionResult> GetMongoDbConnection()
    {
        var mongoConnResult = new ConnectionResultMongoDb();
        var mongoConn = new ConnectionMongoDb<IConnectionResult>(mongoConnResult);
        return mongoConn;
    }

    IConnection<IConnectionResult> GetConnection()
    {
        switch (_connType)
        {
            case ConnType.MongoDb:
                return GetMongoDbConnection();
            case ConnType.SqlServer:
                return GetSqlServerConnection();
            default:
                return GetSqlServerConnection();
        }
    }

    public IConnectionResult Connect()
    {
        return _conn.Connect();
    }
}

public enum ConnType
{
    SqlServer,
    MongoDb
}