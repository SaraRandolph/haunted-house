using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hauntedHouseClassLibrary.models
{
    internal class Game
    
    {
        internal Room currentRoom { get;  private set; }
        List<Room> Rooms;
        internal bool PlayingGame { get; private set; } = false;

        internal void Setup()
        {
            PlayingGame = true;
            Rooms = new List<Room>();

            //CREATE ROOMS
            var entryWay = new Room("Entry Way", "A strange tingle trickles across your skin.  You feel lightheaded and sit down.  Feeling better you stand up again and notice your reflection in a window and jump in surprise! You're a beautiful monster! The most beautiful and ugly thing you've ever laid eyes on. After you get used to your new being and your eyes begin to adjust to the darkness you begin to look around and notice you are in the entry of an old house. To the right of you a terrible smell is wafting out of a closed door. Would you like to go right? (go right/ quit)");

            var kitchen = new Room("Kitchen", "You walk through the swinging door and the terrible smell suddenly turns into the smell of delicious pumpkin bread. You jump 20 feet in the air as a buzzzer sounds out of the silence. You realize that the timer is for the oven and cautiously walk over and take the bread out of the oven. You're amazed that the heat from the oven doesn't affect your newly scaley reptile hands. You cut yourself a slice of bread and ponder where you want to go next. At the doorway in front of you there is a soft hushing sound coming from behind a closed door. Behind you is the entry way. Would you like to go forward or go back? (go forward/ go back/ quit)");

            var diningRoom = new Room("Dining Room", "You slowly open the door and you walk into a dimly light room. A strong musky smell singes you nose hairs and as your eyes adjust you realize that somehow the ceiling is around 50 feet high and that the hushing noise you hear is from thousands of bats flying around above. Since your new monster body has wings you can decide to fly up with the bats or walk left into a quite room with a dim light under the door. Would you like to go up, go back to the kitchen or go left? (go up/ go back/ go left/ quit)");

            var loft = new Room("Loft", "Your new wings take you to the bats surprisingly fast. You spend a few minutes flying around with the bats trying to make casual conversation. You remember that bats aren't very friendly and notice that there is a doorway to the right of you! You are skeptical of what kind of room would be 50 feet up in a house but are intrigued nonetheless. Would you like to go right into the door or fly back down into the room? (go right/ go down/ quit)");

            var partyPorch = new Room("Porch", "You land softly on warm hard floor. As your eyes adjust to the brightness of the room you are suprised to see that the room is filled to the ceiling with candy machines and chocolate fountains and buckets and buckets of every type of Halloween candy you can imagine!! You immediately start towards your favorite candy and spend as much time as you can sampling every piece of candy you find. Would you like to die of a sugar coma or go left back to the loft?. (go left/ quit)" );

            var library = new Room("Library", "You slam open the door and find yourself looking onto an unusual scene. You are in a room with bookcases on all the walls filled with thousands of books. The room is bright and plush, comfortable looking chairs fill the room. The chairs are almost all occupied by various types of monsters and skeletons reading or quietly chatting over tea. You see your favorite book and take it to a free chair and start reading. After what seems like minutes you relize you fell asleep and look out the window to see that its competely dark outside! You must have been sleeping for hours! You decide you want some more pumpkin bread from the kitchen but as you try to lift yourself out of the chair you realize you're stuck!!! You can't lift yourself up and as you start to panic a vampire with kind eyes turns to you and says 'Don't waste your effort...you're never leaving that chair. Hope you're comfortable.' (quit)");

            //MAP ROOMS TOGETHER
            entryWay.DirectionsCanTravel.Add("right", kitchen);

            kitchen.DirectionsCanTravel.Add("forward", diningRoom);
            kitchen.DirectionsCanTravel.Add("behind", entryWay);

            diningRoom.DirectionsCanTravel.Add("up", loft);
            diningRoom.DirectionsCanTravel.Add("behind", kitchen);
            diningRoom.DirectionsCanTravel.Add("left", library);

            loft.DirectionsCanTravel.Add("down", diningRoom);
            loft.DirectionsCanTravel.Add("right", partyPorch);

            partyPorch.DirectionsCanTravel.Add("left", loft );

            //CREATE ITEMS

            //PLACE ITEMS IN ROOMS

            currentRoom = entryWay;

        }

        internal void Go(string direction)
        {
            if (currentRoom.DirectionsCanTravel.ContainsKey(direction))
            {
                currentRoom = currentRoom.DirectionsCanTravel[direction];
            } 
        }

        internal void Quit()
        {
            PlayingGame = false;
        }
    }
}
