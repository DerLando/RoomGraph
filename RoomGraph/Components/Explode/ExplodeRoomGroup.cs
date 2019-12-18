using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;
using RoomGraphLibrary.Core;

namespace RoomGraph.Components.Explode
{
    public class ExplodeRoomGroup : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the ExplodeRoomGroup class.
        /// </summary>
        public ExplodeRoomGroup()
          : base("ExplodeRoomGroup", "ExpldRmGrp",
              "Explodes a RoomGroup in its components",
              Settings.MAIN_CATEGORY, Settings.SUB_CATEGORY_EXPLODE)
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddGenericParameter("Room group", "G", "Room group to explode", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddTextParameter("Name", "N", "Name of room group", GH_ParamAccess.item);
            pManager.AddNumberParameter("Total Area", "A", "Total area of all rooms in this group",
                GH_ParamAccess.item);
            pManager.AddGenericParameter("Rooms", "R", "Rooms in this room group", GH_ParamAccess.list);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            RoomGroup group = null;

            if (!DA.GetData("Room group", ref group)) return;

            DA.SetData("Name", group.Name);
            DA.SetData("Total Area", group.TotalArea);
            DA.SetDataList("Rooms", group);
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                //You can add image files to your project resources and access them like this:
                // return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("d9d4f928-a55c-491c-a869-24aca324ec99"); }
        }
    }
}