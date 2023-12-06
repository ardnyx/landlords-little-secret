using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Little_Landlord_s_Secret
{
    class alternativeRoute
    {
        public static void altRouteStart()
        {
            Clear();
            say($"The anonymous man screamed at you using his last remaining strength.");
            say($" (You decided to go home and treat what you saw as a bad dream. Although, it's not something that is easily forgettable.)\n");
            say($"-- Press any key to continue --");
            slept();
        }
        public static void slept()
        {
            Clear();
            say($"You just woke up from a not so good sleep when you suddenly heard a subtle knock on your door.");
            ChoiceSelector.subtleKnock();
        }
        public static void outsideDoor()
        {
            Clear();
            WriteLine($"You didn't see anyone outside your door, the only thing there is a small envelope at the edge of the door.\n");
            WriteLine($" -- Press Spacebar to read the letter --\n");
            ConsoleKey keyPressed;
            do
            {
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
            } while (keyPressed != ConsoleKey.Spacebar);
            normalEnding.ReadEnvelope();
        }
        static void say(string message)
        {
            WriteLine($"{message}\n");
            ReadKey();
        }
    }
}
