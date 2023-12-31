﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Threading.Channels;

namespace DP.DesignPatterns.Behavioral.Observer
{
    internal class Client
    {
        public static void Execute()
        {
            var sub1 = new SubscriberA();
            var sub2 = new SubscriberB();

            using (var publisher = new Publisher())
            {
                sub1.Subscription = publisher.Subscribe(sub1);
                sub2.Subscription = publisher.Subscribe(sub2);

                _ = Task.Delay(7000).ContinueWith(x => sub2.Subscription.Dispose());

                _ = Task.Delay(12000).ContinueWith(x => sub2.Subscription = publisher.Subscribe(sub2));

                publisher.Work().Wait();
            }


        }
    }
}
