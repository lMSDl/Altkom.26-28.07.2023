﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Threading.Channels;

namespace DP.DesignPatterns.Behavioral.Strategy
{
    internal class Client
    {
        public static void Execute()
        {
            var calculator = new Calculator();

            while (true)
            {
                var line = Console.ReadLine();
                var split = line.Split(' '); // 2 + 4
                if (split.Length < 3)
                    continue;

                calculator.Strategy = GetStrategy(split[1]);

                if (float.TryParse(split[0], out var a) && float.TryParse(split[2], out var b))
                {
                    Console.WriteLine(calculator.Operate(a, b));
                    Console.WriteLine(GetFunc(split[1]).Invoke(a, b));
                }
            }
        }

        private static ICalcStrategy GetStrategy(string param)
        {
            switch (param)
            {
                case "+":
                    return new PlusStrategy();
                case "-":
                    return new MinusStrategy();
                case "*":
                    return new MultiplyStrategy();
                case "/":
                    return new DivideStrategy();
            }

            return null;
        }

        private static Func<float, float, float> GetFunc(string param)
        {
            switch (param)
            {
                case "+":
                    return (a, b) => a + b;
                case "-":
                    return (a, b) => a - b;
                case "*":
                    return (a, b) => a * b;
                case "/":
                    return (a, b) => a / b;
            }

            return null;
        }
    }
}
