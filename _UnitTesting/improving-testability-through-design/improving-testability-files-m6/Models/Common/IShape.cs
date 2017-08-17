namespace Models.Common
{
    public interface IShape
    {
        void Accept(IShapeVisitor visitor);
    }
}
