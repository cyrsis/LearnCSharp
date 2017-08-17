using Xunit;

namespace Demo.Tests
{
    public class EqualsDemo
    {
        [Fact]
        public void NoEquals()
        {
            var loc1 = new LocationWithoutEquals()
                       {
                           Lat = 1,
                           Long = 2,
                           Altitude = 3
                       };

            var loc2 = new LocationWithoutEquals()
            {
                Lat = 1,
                Long = 2,
                Altitude = 3
            };

            var areEqual = loc1 == loc2;   
        }


        [Fact]
        public void WithManualEquals()
        {
            var loc1 = new LocationManualEquals
            {
                Lat = 1,
                Long = 2,
                Altitude = 3
            };

            var loc2 = new LocationManualEquals
            {
                Lat = 1,
                Long = 2,
                Altitude = 3
            };

            var areEqual = loc1 == loc2;
        }



        [Fact]
        public void WithAutoEquals()
        {
            var loc1 = new LocationAutoEquals
            {
                Lat = 1,
                Long = 2,
                Altitude = 3
            };

            var loc2 = new LocationAutoEquals
            {
                Lat = 1,
                Long = 2,
                Altitude = 3
            };

            var areEqual = loc1 == loc2;
        }


        [Fact]
        public void ExcludingPropertiesFromEqualityCheck()
        {
            var loc1 = new LocationAutoEquals
            {
                Lat = 1,
                Long = 2,
                Altitude = 88888888
            };

            var loc2 = new LocationAutoEquals
            {
                Lat = 1,
                Long = 2,
                Altitude = 44444444
            };

            var areEqual = loc1 == loc2;
        }


        [Fact]
        public void CustomEqualityLogic()
        {
            var loc1 = new LocationAutoEquals
            {
                Lat = 1,
                Long = 1,
                Altitude = -1
            };

            var loc2 = new LocationAutoEquals
            {
                Lat = 1,
                Long = 1,
                Altitude = 2
            };

            var areEqual = loc1 == loc2;
        } 
    }
}
