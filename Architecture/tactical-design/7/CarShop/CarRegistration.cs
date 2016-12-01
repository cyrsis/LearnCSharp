namespace CarShop
{
    class CarRegistration
    {
        private readonly string make;
        private readonly string model;
        private readonly float capacity;
        private int maxPassengers;

        public CarRegistration(string make, string model, float capacity,
                               int maxPassengers)
        {
            this.make = make;
            this.model = model;
            this.capacity = capacity;
            this.maxPassengers = maxPassengers;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}cc {3} passengers",
                                 this.make, this.model, this.capacity,
                                 this.maxPassengers);
        }
    }
}
