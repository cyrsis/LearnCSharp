namespace CarShop
{
    class CarToStringVisitor: ICarVisitor
    {
        private string report;
        private int seatsCount;

        public void Visit(Car car)
        {
            // ???
        }

        public void Visit(Engine engine)
        {
            this.report += string.Format(" {0}cc {1}kW",
                                         engine.CylinderVolume, engine.Power);
        }

        public void Visit(Seat seat)
        {
            this.seatsCount++;
        }

        public string GetCarDescription()
        {
            return this.report + string.Format(" {0} seat(s)", this.seatsCount);
        }
    }
}
