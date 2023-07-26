﻿namespace DP.SOLID.D
{

    interface IMessage
    {
        void Send();
    }

    class SMS : IMessage
    {
        public string Number { get; set; }
        public string Content { get; set; }

        public void Send()
        {
            SendSMS();
        }

        public void SendSMS()
        {
            Console.WriteLine("Sending SMS...");
        }
    }

    class MMS : IMessage
    {
        public string Number { get; set; }
        public byte[] Content { get; set; }

        public void SendMMS()
        {
            Console.WriteLine("Sending MMS...");
        }
        public void Send()
        {
            SendMMS();
        }
    }

    class Mail : IMessage
    {
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendMail()
        {
            Console.WriteLine("Sending Mail...");
        }
        public void Send()
        {
            SendMail();
        }
    }

    class Messenger
    {
        public IEnumerable<IMessage> Messages { get; set; }

        public Messenger(IEnumerable<IMessage> messages)
        {
            Messages = messages;
        }

        public void SendMessage(IEnumerable<IMessage> messages)
        {
            Messages = messages;
            SendMessage();
        }

        public void SendMessage()
        {
            foreach (var message in Messages)
            {
                message.Send();
            }
        }
    }
}