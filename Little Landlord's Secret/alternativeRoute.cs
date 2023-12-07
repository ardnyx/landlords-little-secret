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
            GoHome();
            
        }
        public static void GoHome()
        {
            say($"(Anyway, you decided to go home and treat what you saw as a bad dream. Although, it's not something that is easily forgettable.)");
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
        public static void crazyPrank()
        {
            Clear();
            say($"You received a call from an unknown number. Chills run down your spine as you suspect someone observing you.");
            ChoiceSelector.phoneCall();
        }
        public static void phoneCall()
        {
            Clear();
            say($"[Filtered voice] You have to understand that this isn't some sick joke. We have already failed, you need to do your part as the grandchild, only you can do it.");
            ChoiceSelector.choiceLetterContent();
        }
        static void say(string message)
        {
            WriteLine($"{message}\n");
            ReadKey();
        }
    }
}
