using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.TemplateMethod
{
    internal class DatabaseLogger : Logger<DbLog, DatabaseService>
    {
        protected override void Save(DbLog item, DatabaseService service)
        {
            service.Insert(item);
        }

        protected override DbLog CreateItem(string message)
        {
            Console.WriteLine("Serializing message");
            return new DbLog() { DateTime = DateTime.Now, Message = message };
        }

        protected override DatabaseService GetService()
        {
            Console.WriteLine("Connecting to Database.");
            return new DatabaseService();
        }

        protected override string PrepareMessage(string message)
        {
            return message;
        }
    }
}
