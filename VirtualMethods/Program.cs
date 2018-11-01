using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlserver = new SqlServer();
            sqlserver.Add();
            MySql mysql = new MySql();
            mysql.Delete();

            Console.Read();
        }
    }
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }
    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added sql code");
            //base.Add();
        }
    }
    class MySql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted mysql code");
            //base.Delete();
        }
    }
}
