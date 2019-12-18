using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace RoomGraph
{
    public class RoomGraphInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "RoomGraph";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("3cf545f3-6d14-4c8b-b1fa-5c18520e2281");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
