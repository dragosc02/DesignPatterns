namespace VisitorExample
{
    public interface IElement
    {
        string GetDetails();

        void Accept(IVisitor visitor);
        
    }
}