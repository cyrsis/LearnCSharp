using System;

namespace CarShop
{
    class Engine
    {

        private float power;
        private float cylinderVolume;

        private const float WorkingTemperatureC = 90.0F;
        private float temperatureC = 20.0F;

        public Engine(float power, float cylinderVolume)
        {
            this.power = power;
            this.cylinderVolume = cylinderVolume;
        }

        public void Accept(Func<ICarPartVisitor> visitorFactory)
        {
            EngineStructure structure = new EngineStructure(this.power, this.cylinderVolume);
            EngineStatus status = new EngineStatus(this.temperatureC, 0);
            visitorFactory().VisitEngine(structure, status);
        }

        public void Run(TimeSpan time)
        {
            
            TimeSpan heatingTime = GetHeatingTime();

            if (time > heatingTime)
            {
                this.temperatureC = WorkingTemperatureC;
            }
            else
            {
                double temperatureDelta = WorkingTemperatureC - this.temperatureC;
                double timeRatio = time.TotalMinutes / heatingTime.TotalMinutes;
                this.temperatureC += (float)(temperatureDelta * timeRatio);
            }

        }

        private TimeSpan GetHeatingTime()
        {

            double meanPower = 180.0;
            double nominalHeatingTimeSec = 300.0;

            int seconds = (int)(nominalHeatingTimeSec * meanPower / this.power);

            return new TimeSpan(0, 0, seconds);

        }

    }
}
