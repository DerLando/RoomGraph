using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grasshopper.Kernel.Types;
using Rhino.Geometry;
using RoomGraphLibrary.Core;

namespace RoomGraph
{
    public static class Extensions
    {
        public static Point3d ToPoint3d(this RoomCentroid pt)
        {
            return new Point3d(pt.X, pt.Y, 0);
        }

        public static GH_Point ToGH_Point(this RoomCentroid pt)
        {
            return new GH_Point(pt.ToPoint3d());
        }
    }
}
