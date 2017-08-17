namespace Demo
{
    [Equals]
    public class LocationAutoEquals
    {
        #region
        // [IgnoreDuringEquals] 
        #endregion
        public int Altitude { get; set; }
        public int Lat { get; set; }
        public int Long { get; set; }


        #region
        // [CustomEqualsInternal]
        private bool CustomEqualsLogic(LocationAutoEquals other)
        {
            // this method is evaluated if the other auto-equal properties are equal

            if (this.Altitude == other.Altitude)
            {
                return true;
            }

            if (this.Altitude == -1 || other.Altitude == -1)
            {
                return true;
            }

            return false;
        } 
        #endregion
    }
}