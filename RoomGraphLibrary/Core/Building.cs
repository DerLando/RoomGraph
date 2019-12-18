using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoomGraphLibrary.Exceptions;

namespace RoomGraphLibrary.Core
{
    public class Building : Dictionary<string, RoomGroup>
    {
        public void AddRoomGroup(RoomGroup group)
        {
            if (ContainsKey(group.Name))
            {
                throw new RoomGroupAlreadyInBuildingError();
            }

            this[group.Name] = group;
        }

        public void RemoveRoomGroup(RoomGroup group)
        {
            if (!ContainsKey(group.Name)) return;

            Remove(group.Name);
        }

        public void AddRoom(Room room, RoomGroup group)
        {
            if (!ContainsKey(group.Name))
            {
                AddRoomGroup(group);
            }

            this[group.Name].AddRoom(room);
        }

        public void RemoveRoom(Room room, RoomGroup group)
        {
            if (!ContainsKey(group.Name)) return;

            this[group.Name].RemoveRoom(room);
        }
    }
}
