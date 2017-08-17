using System;
namespace Models.Common
{
    public interface ICircle: IEquatable<ICircle>
    {
        decimal X { get; set; }
        decimal Y { get; set; }
        decimal Radius { get; set; }

        void Draw();
    }
}
