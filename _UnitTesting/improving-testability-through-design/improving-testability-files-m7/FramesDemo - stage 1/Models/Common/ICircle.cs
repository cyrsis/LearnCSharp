using System;

namespace Models.Common
{
    public interface ICircle: IShape, IEquatable<ICircle>
    {
        bool IsInsideOf(Rectangle rect);
        ICircle Move(Location center);
        ICircle Resize(decimal radius);
    }
}
