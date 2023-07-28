﻿namespace DP.DesignPatterns.Behavioral.Visitor.II
{
    public class Product : IElement
    {
        public virtual void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public virtual void PrintType()
        {
            Console.WriteLine("Product");
        }
    }
}