namespace DP.DesignPatterns.Behavioral.Visitor.II
{
    public class BoxedProduct : Product
    {
        public override void PrintType()
        {
            Console.WriteLine("BoxedProduct");
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}