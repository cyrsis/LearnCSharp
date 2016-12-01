namespace CarShop
{
    class CarToStringVisitor: ICarVisitor<string>
    {
        private string carDetails;
        private string engineDetails;
        private int seatsCount;

        public void VisitCar(string make, string model)
        {
            this.carDetails = string.Format("{0} {1}", make, model);
        }

        public void VisitEngine(EngineStructure structure, EngineStatus status)
        {
            this.engineDetails =
                string.Format("{0}cc {1}kW",
                              structure.CylinderVolume, structure.Power);
        }

        public void VisitSeat(string name, int capacity)
        {
            this.seatsCount += capacity;
        }

        public string ProduceResult()
        {
            return string.Format("{0} {1} {2} seat(s)",
                                 this.carDetails, this.engineDetails,
                                 this.seatsCount);
        }
    }
}
