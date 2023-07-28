using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.Mediator
{
    internal interface IMediator
    {
        void Join(ChatMember chatMember);
        void Quit(ChatMember chatMember);
        void Send(string from, string message);
        void Send(string from, string to, string message);
    }
}
