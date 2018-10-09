using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hauntedHouseClassLibrary.models
{
    internal class GameState : IGameState
    {
        public string RoomDescription { get; private set; }
        public IRoom CurrentRoom { get; private set; }
        public string CommandResponse { get; private set; }
        public bool Playing { get; private set; }

        public GameState(Game game, string responseMessage)
        {
            RoomDescription = game.currentRoom.SpookyMessage;
            CommandResponse = responseMessage;
            Playing = game.PlayingGame;
        }
    }
}
