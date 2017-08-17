using System;

namespace Models.Common
{
    public interface ICircle: IEquatable<ICircle>
    {
        bool IsInsideOf(Rectangle rect);
        void Draw();
        ICircle Move(Location center);
        ICircle Resize(decimal radius);
    }
}
