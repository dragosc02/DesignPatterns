namespace VisitorExample
{
    public interface IVisitor
    {
        string ProcessName { get;}

        bool IsValid();

        void VisitElement(IElement element);
        

    }
}