using System;
using hauntedHouseClassLibrary;


namespace hauntedHousePresLayer
{
    class Program
    {
        static void Main(string[] args)
        {

            SpookyApi spookyApi = new SpookyApi();
            IGameState gameState;
            Console.WriteLine("Welcome to your worst nightmare!!! Would you like to play a game with me? (yes/no)");
            var playGame = Console.ReadLine();
            gameState = spookyApi.ProccessCommand(playGame);

            while (gameState.Playing)
            {
                PrintSpookyMessage(gameState);
                var userInput = Console.ReadLine();
                gameState = spookyApi.ProccessCommand(userInput);

            }

        }
        private static void PrintSpookyMessage(IGameState gameState)
        {

            Console.Clear();
            Console.WriteLine($@"
--------------------------------------------------------------------------------
|
{gameState.RoomDescription}
|
--------------------------------------------------------------------------------
", 0, Console.WindowWidth);
                       
        }



    }
}
