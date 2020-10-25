using System;

namespace Models
{
    public abstract class Locatable
    {
        public abstract double Longitude { get; set; }
        public abstract double Latitude { get; set; }
        public abstract string Address { get; set; }

        public double SquareDistanceTo(Locatable locatable)
        {
            var xDiff = Latitude - locatable.Latitude;
            var yDiff = Longitude - locatable.Longitude;
            return (xDiff * xDiff) + (yDiff * yDiff);
        }

        public double DistanceTo(Locatable locatable)
        {
            return Math.Sqrt(SquareDistanceTo(locatable));
        }
    }
}
