namespace DP.DesignPatterns.Behavioral.Visitor.II
{
    public interface IVisitor
    {
        void Visit(Product product);
        void Visit(BoxedProduct boxedProduct);
    }
}