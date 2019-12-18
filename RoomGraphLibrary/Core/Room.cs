using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomGraphLibrary.Core
{
    public class Room
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public RoomCentroid Centroid { get; set; }

        private double m_radius = -1;
        public double Radius => GetRadius();

        private double GetRadius()
        {
            if (m_radius == -1)
            {
                m_radius = Math.Sqrt(Area / Math.PI);
            }

            return m_radius;
        }

        public Room(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public Room(string name, double area, RoomCentroid centroid) : this(name, area)
        {
            Centroid = centroid;
        }
    }
}
