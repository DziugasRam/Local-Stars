using System;

namespace Models
{
    public class Location
    {
        public (double, double) Position { get; set; }
        public string Address { get; set; }

        public double SquareDistanceTo(Location location)
        {
            var xDiff = Position.Item1 - location.Position.Item1;
            var yDiff = Position.Item2 - location.Position.Item2;
            return (xDiff * xDiff) + (yDiff * yDiff);
        }

        public double DistanceTo(Location location)
        {
            return Math.Sqrt(SquareDistanceTo(location));
        }
    }
}
