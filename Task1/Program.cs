using System.Diagnostics;
using Task1.Classes;


SqlConnection sqlConnection = new SqlConnection("hello");
OracleConnection oracleConnection = new OracleConnection("key");
var sqlConnection1 = new DbCommand("k", "hello");
Thread.Sleep(0);
sqlConnection1.Execute("k");
//Console.WriteLine(oracleConnection.ConnectionOpened("ke"));
//Console.WriteLine(sqlConnection.ConnectionOpened());
Console.BackgroundColor = ConsoleColor.Black;
