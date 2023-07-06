using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            
        }

        public override string ConnectionClosed()
        {
            return "Connection closed";
        }

        public override string ConnectionOpened(string key)
        {
            Thread.Sleep(50);
            Console.Write('#');
            Thread.Sleep(100);
            Console.Write('#');
            Thread.Sleep(30);
            Console.Write('#');
            Thread.Sleep(20);
            Console.Write('#');
            if (key == base.ConnectionString)
            {
                Thread.Sleep(500);
                Console.Write('#');
                Thread.Sleep(800);
                Console.Write('#');
                Thread.Sleep(500);
                Console.Write('#');
                Thread.Sleep(400);
                Console.Write('#');
                Thread.Sleep(600);
                Console.Write('#');
                Thread.Sleep(500);
                Console.Write('#');
                Thread.Sleep(2500);
                Console.Write('#');
                Console.WriteLine();
                Console.Clear();
                if (base.TimeOut.Seconds + 7 >= DateTime.Now.Second)
                {
                    _disposed = true;
                    Console.BackgroundColor = ConsoleColor.Green;
                    return "Connection succesfully";
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    return "Connection time out";
                };
            }
            else
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                return "Incorrect key";
            }
        }
    }
}
