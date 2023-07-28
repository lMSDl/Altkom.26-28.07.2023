using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.TemplateMethod
{
    internal class EmailLogger : Logger<string, IDisposable>
    {
        protected override void Save(string item, IDisposable service)
        {
            Console.WriteLine("Sending Email with Log Message : " + item);
        }

        protected override string CreateItem(string message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }

        protected override IDisposable GetService()
        {
            return null;
        }
    }
}
