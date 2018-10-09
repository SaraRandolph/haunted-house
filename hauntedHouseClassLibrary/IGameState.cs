using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hauntedHouseClassLibrary
{
    public interface IGameState
    {
        string RoomDescription { get; }
        string CommandResponse { get; }
        bool Playing { get; }
    }
}
