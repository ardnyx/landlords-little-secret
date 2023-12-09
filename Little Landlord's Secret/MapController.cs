using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_Landlord_s_Secret
{
    internal class MapController
    {
        private HouseMap map;
        public MapController()
        {
            map = new HouseMap();
        }
        public void StartGame()
        {
            int[] currentPosition = { 4, 3 }; // Starting position

            while (true)
            {
                map.Display(currentPosition);

                Console.Write("Enter direction (W/A/S/D to move, Q to quit): ");
                char input = char.ToUpper(Console.ReadKey().KeyChar);

                if (input == 'Q')
                    break;

                int[] newPosition = map.GetNewPosition(currentPosition, input);

                // Check if the new position is valid
                if (map.IsValidPosition(newPosition))
                {
                    currentPosition = newPosition;
                    Console.Clear(); // Clear console for a better display
                }
                else
                {
                    Console.WriteLine("\nInvalid move! Try again.");
                }
            }
        }
    }
}
