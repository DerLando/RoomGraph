using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoomGraphLibrary.Parsing;

namespace RoomGraph.Tests
{
    [TestClass]
    public class ParserTests
    {
        [TestMethod]
        public void BuildingParserShouldWork()
        {
            // Arrange
            var path = "D:\\GoogleDrive\\Bachelor\\Planungsgrundlagen\\Raumplan.md";

            // Act
            var building = MarkdownParser.ParseRoomListToBuilding(path);
            var actual = building.Count;

            // Assert
            var notExpected = 0;
            Assert.AreNotEqual(notExpected, actual);
        }
    }
}
