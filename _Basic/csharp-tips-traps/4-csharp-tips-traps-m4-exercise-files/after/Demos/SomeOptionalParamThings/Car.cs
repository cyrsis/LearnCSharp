namespace SomeOptionalParamThings
{
    public class Car
    {
        private readonly string _color;
        private readonly int _numberOfWheels;

        public Car(string color, int numberOfWheels = 6, int windows = 4)
        {
            _color = color;
            _numberOfWheels = numberOfWheels;
        }

    
        public override string ToString()
        {
            return string.Format("Color:{0}  Wheels:{1}", _color, _numberOfWheels);
        }
    }
}
