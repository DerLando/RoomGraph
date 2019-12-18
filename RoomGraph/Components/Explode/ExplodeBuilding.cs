using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;
using RoomGraphLibrary.Core;

namespace RoomGraph.Components.Explode
{
    public class ExplodeBuilding : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the ExplodeBuilding class.
        /// </summary>
        public ExplodeBuilding()
          : base("ExplodeBuilding", "ExpldBldg",
              "Explodes a building in its components",
              Settings.MAIN_CATEGORY, Settings.SUB_CATEGORY_EXPLODE)
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddGenericParameter("Building", "B", "Building to explode", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddGenericParameter("Room groups", "G", "Room groups of building", GH_ParamAccess.list);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            Building building = null;

            if (!DA.GetData("Building", ref building)) return;

            DA.SetDataList("Room groups", building.Values);
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
            get { return new Guid("af007545-ca7c-486e-bdff-f20b52289830"); }
        }
    }
}