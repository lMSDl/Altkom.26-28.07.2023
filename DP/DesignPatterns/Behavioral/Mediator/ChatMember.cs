using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.Mediator
{
    internal abstract class ChatMember
    {
        private IMediator mediator;
        public string Nick { get; }
        public IMediator Mediator
        {
            get => mediator;
            set
            {
                mediator?.Quit(this);
                mediator = value;
                mediator?.Join(this);
            }
        }

        protected ChatMember(string nick)
        {
            Nick = nick;
        }

        public abstract void Receive(string from, string message, bool isPrivate);


    }
}
