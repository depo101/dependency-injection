using lib.dependency.inject.constructor;

#region Constructor Injection
//sqlserver sample
var sqlConnResult = new ConnectionResultSqlServer();
var sqlConn = new ConnectionSqlServer<IConnectionResult>(sqlConnResult);
var cm = new ConnectionManager<IConnectionResult>(sqlConn);
string connStatus = cm.ConnectDb().Connected(()=> true).ConnectionStatus;
Console.WriteLine(connStatus);

//mongodb sample
var mongoConnResult = new ConnectionResultMongoDb();
var mongoConn = new ConnectionMongoDb<IConnectionResult>(mongoConnResult);
cm = new ConnectionManager<IConnectionResult>(mongoConn);
connStatus = cm.ConnectDb().ConnectionStatus;
Console.WriteLine(connStatus);
#endregion


