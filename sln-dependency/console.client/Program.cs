using lib.dependency.inject.constructor;

#region Constructor Injection
//sql server concrete objects
var sqlConnResult = new ConnectionResultSqlServer();
var sqlConn = new ConnectionSqlServer<IConnectionResult>(sqlConnResult);
//mongodb concrete objects
var mongoConnResult = new ConnectionResultMongoDb();
var mongoConn = new ConnectionMongoDb<IConnectionResult>(mongoConnResult);
//app settings
bool useSqlServer = false;

var cm = new ConnectionManager<IConnectionResult>(useSqlServer ? sqlConn : mongoConn);
string connStatus = cm.ConnectDb().Connected(()=> true).ConnectionStatus;
Console.WriteLine(connStatus);

#endregion


