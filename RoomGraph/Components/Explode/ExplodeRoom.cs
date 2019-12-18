using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;
using RoomGraphLibrary.Core;

namespace RoomGraph.Components.Explode
{
    public class ExplodeRoom : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the ExplodeRoom class.
        /// </summary>
        public ExplodeRoom()
          : base("ExplodeRoom", "ExpldRm",
              "Explodes a room in its components",
              Settings.MAIN_CATEGORY, Settings.SUB_CATEGORY_EXPLODE)
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddGenericParameter("Room", "R", "Room to explode", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddTextParameter("Name", "N", "Name of room", GH_ParamAccess.item);
            pManager.AddNumberParameter("Area", "A", "Area of room", GH_ParamAccess.item);
            pManager.AddPointParameter("Center", "C", "Center of room", GH_ParamAccess.item);
            pManager.AddNumberParameter("Radius", "R", "Radius of room", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            Room room = null;

            if (!DA.GetData("Room", ref room)) return;

            DA.SetData("Name", room.Name);
            DA.SetData("Area", room.Area);
            DA.SetData("Center", room.Centroid.ToGH_Point());
            DA.SetData("Radius", room.Radius);
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
            get { return new Guid("4dbfaa5c-a9fe-4118-897e-ea8406c5af6a"); }
        }
    }
}