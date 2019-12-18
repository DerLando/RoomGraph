using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomGraphLibrary.Exceptions
{
    public class RoomGroupAlreadyInBuildingError : ArgumentException
    {
        public override string Message => "Roomgroup already present in building, try calling RemoveRoomGroup first!";
    }
}
