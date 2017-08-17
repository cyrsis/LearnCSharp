using System;

namespace Demo
{
    public class LocationManualEquals : IEquatable<LocationManualEquals>
    {
        public int Altitude { get; set; }
        public int Lat { get; set; }
        public int Long { get; set; }

        public bool Equals(LocationManualEquals other)
        {
            if (!ReferenceEquals(null, other))
            {
                if (!ReferenceEquals(this, other))
                {
                    return EqualsInternal(this, other);
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }


        public override bool Equals(object obj)
        {
            if (!ReferenceEquals(null, obj))
            {
                if (!ReferenceEquals(this, obj))
                {
                    if (GetType() != obj.GetType())
                    {
                        return false;
                    }
                    else
                    {
                        bool flag = EqualsInternal(this, (LocationManualEquals)obj);
                        return flag;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }


        private static bool EqualsInternal(LocationManualEquals left, LocationManualEquals right)
        {
            if (left.Lat == right.Lat)
            {
                if (left.Long == right.Long)
                {
                    if (left.Altitude == right.Altitude)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            int lat = Lat;
            lat = lat*397 ^ Long;
            lat = lat*397 ^ Altitude;
            return lat;
        }


        public static bool operator ==(LocationManualEquals left, LocationManualEquals right)
        {
            return Equals(left, right);
        }


        public static bool operator !=(LocationManualEquals left, LocationManualEquals right)
        {
            return !Equals(left, right);
        }
    }
}