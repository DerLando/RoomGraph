﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomGraphLibrary.Core
{
    public class RoomGroup : List<Room>
    {
        public string Name { get; set; }
        public double TotalArea => (from room in this select room.Area).Sum();

        public void AddRoom(Room room)
        {
            Add(room);
        }

        public void RemoveRoom(Room room)
        {
            Remove(room);
        }
    }
}
