namespace SalesDashboard
{
    public class DistanceConverter
    {
        public static double PixelsToValue(double distanceInPixels, double containerLength, double valueRange)
        {
            return (valueRange * distanceInPixels) / containerLength;
        }

        public static double ValueToPixels(double value, double containerLength, double valueRange)
        {
            return (value * containerLength) / valueRange;
        }
    }
}
