using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    internal class DbCommand : SqlConnection
    {
        string? _sentData;
        public DbCommand(string connectionString, string sentData) : base(connectionString)
        {
            _sentData = sentData;
        }
        public void Execute(string key)
        {
            Console.WriteLine(base.ConnectionOpened(key));
            if (_disposed == true)
            {
                Console.WriteLine("Sent data");
            }
            if (_disposed == true)
            {
                Console.WriteLine(base.ConnectionClosed());
            }
        }
    }
}
