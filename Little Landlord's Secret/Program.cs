using Landlords_Little_Secret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Little_Landlord_s_Secret
{
    internal class Program
    {
        public static string player;
        static void Main(string[] args)
        {
            Console.Title = 
            player = GetInput("Please Enter Your Name: ");
            Clear();
            string prompt = $@" 
              
 _____                                                                    _____ 
( ___ )                                                                  ( ___ )
 |   |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|   | 
 |   |       _                       _  _                  _  _           |   | 
 |   |      | |     __ _  _ __    __| || |  ___   _ __  __| |( )___       |   | 
 |   |      | |    / _` || '_ \  / _` || | / _ \ | '__|/ _` ||// __|      |   | 
 |   |      | |___| (_| || | | || (_| || || (_) || |  | (_| |  \__ \      |   | 
 |   |      |_____|\__,_||_| |_| \__,_||_| \___/ |_|   \__,_|  |___/      |   | 
 |   |                                                                    |   | 
 |   |   _      _  _    _    _         ____                          _    |   | 
 |   |  | |    (_)| |_ | |_ | |  ___  / ___|   ___   ___  _ __  ___ | |_  |   | 
 |   |  | |    | || __|| __|| | / _ \ \___ \  / _ \ / __|| '__|/ _ \| __| |   | 
 |   |  | |___ | || |_ | |_ | ||  __/  ___) ||  __/| (__ | |  |  __/| |_  |   | 
 |   |  |_____||_| \__| \__||_| \___| |____/  \___| \___||_|   \___| \__| |   | 
 |   |                                                                    |   | 
 |___|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|___| 
(_____)                                                                  (_____)
  Welcome, {player}. Your journey into the Landlord’s Little Secret begins now
  Your determination will guide you through the shadows of this ominous boarding house.
  Remember, every choice you make shapes the outcome of this chilling tale.
  Prepare yourself, {player}, for the secrets that lie ahead.
";
            List<string> options = new List<string> { "Play", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    break;
                case 1:
                    ExitGame();
                    break;
            }

            normalEnding.StoryIntroduction();
        }
        public static string GetInput(string input)
        {
            Write(input);
            return ReadLine();
        }
        private static void ExitGame()
        {
            Environment.Exit(0);
        }
    }
}
