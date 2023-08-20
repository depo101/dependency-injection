using lib.dependency.inject.constructor;

#region Constructor Injection

IConnectionManager connectionManager = new ConnectionManager(ConnType.SqlServer);
IConnectionResult connectionResult = connectionManager.Connect().Connected(()=>true);

Console.WriteLine($"Connection result message : {connectionResult.ConnectionStatus}");
#endregion


