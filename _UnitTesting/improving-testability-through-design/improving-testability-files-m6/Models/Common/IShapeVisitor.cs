namespace Models.Common
{
    public interface IShapeVisitor
    {
        void VisitCircle(Location center, decimal radius);
        void VisitRectangle(Rectangle rect);
    }
}
