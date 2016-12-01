namespace CarShop
{
    class CarToStringVisitor: ICarVisitor
    {
        private string carDetails;
        private string engineDetails;
        private int seatsCount;

        public void VisitCar(string make, string model)
        {
            this.carDetails = string.Format("{0} {1}", make, model);
        }

        public void VisitEngine(float power, float cylinderVolume,
                                float temperatureC)
        {
            this.engineDetails = string.Format("{0}cc {1}kW", cylinderVolume, power);
        }

        public void VisitSeat(string name, int capacity)
        {
            this.seatsCount += capacity;
        }

        public string GetCarDescription()
        {
            return string.Format("{0} {1} {2} seat(s)",
                                 this.carDetails, this.engineDetails,
                                 this.seatsCount);
        }
    }
}
