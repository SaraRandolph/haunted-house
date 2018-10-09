using hauntedHouseClassLibrary.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hauntedHouseClassLibrary
{
    public class SpookyApi
    {
        Game currentGame;
     
        private void StartGame()
        {
            currentGame = new Game();
            currentGame.Setup();
        }

        public IGameState ProccessCommand(string inputMessage)
        {
            string[] inputArr = inputMessage.ToLower().Split(' ');
            string command = "";
            string options = "";

            string response = "Ah! YOU scared ME!! That is not a valid input";

            switch (inputArr.Length)
            {
                case 1:
                    command = inputArr[0];
                    break;
                case 2:
                    command = inputArr[0];
                    options = inputArr[1];
                    break;
            }

            switch (command)
            {
                case "yes":
                    StartGame();
                    break;
                case "no":
                    response = "Hahahah too scared?? Thats what I thought!!";
                    break;
                case "go":
                    currentGame.Go(options);
                    break;
                case "quit":
                    currentGame.Quit();
                    break;
                default:
                    break;

            }

            return new GameState(currentGame, response);


        }
    }
}
