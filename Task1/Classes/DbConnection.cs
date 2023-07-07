using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public abstract class DbConnection
    {
        protected bool _disposed;
        public string? ConnectionString { get; set; }
        List<string> _dataString = new List<string>();
        public TimeSpan TimeOut { get; set; } = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        public DbConnection(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public abstract string ConnectionOpened(string key);
        public abstract string ConnectionClosed();
        public void AddDataString(string dataString)
        {
            _dataString.Add(dataString);
        }
    }
}
