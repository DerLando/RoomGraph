using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RoomGraphLibrary.Core;

namespace RoomGraphLibrary.Parsing
{
    public static class MarkdownParser
    {
        private static string RoomGroupPattern = "## (?<name>\\S*)";
        private static string RoomParametersPattern = "- (?<roomname>.*): (?<roomarea>\\d*)qm";

        /// <summary>
        /// Parses a markdown file at the given filepath into a new instance of the building class
        /// structure of md needs to be as follows:
        /// - First line as heading, is ignored
        /// - Room groups starting with ##
        /// - rooms inside of room groups as bullet points "xxxxxxx: 20qm"
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Building ParseRoomListToBuilding(string path)
        {
            var lines = File.ReadAllLines(path, Encoding.UTF8);
            if (lines.Length == 0) return null;

            var building = new Building();
            var currentGroup = new RoomGroup();
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                if (line == "\n")
                {
                }

                var match = Regex.Match(line, RoomGroupPattern);
                if (match.Success)
                {
                    currentGroup = new RoomGroup {Name = match.Groups["name"].ToString()};
                    continue;
                }

                match = Regex.Match(line, RoomParametersPattern);
                if (match.Success)
                {
                    var name = match.Groups["roomname"].ToString();
                    var area = double.Parse(match.Groups["roomarea"].ToString());
                    currentGroup.AddRoom(new Room(name, area));
                    continue;
                }

                if (currentGroup.Count == 0) continue;
                building.AddRoomGroup(currentGroup);
                currentGroup = new RoomGroup();
            }

            return building;
        }
    }
}
