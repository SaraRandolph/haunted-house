using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hauntedHouseClassLibrary.models
{
    class Room : IRoom
    {
        public string Name { get; }
        internal Dictionary<string, Room> DirectionsCanTravel { get; private set; }
        internal string SpookyMessage { get; set; }

        string IRoom.SpookyMessage { get; }

        public Room(string name, string spookyMessage)
        {
            Name = name;
            SpookyMessage = spookyMessage;
            DirectionsCanTravel = new Dictionary<string, Room>();
        }
    }
}
