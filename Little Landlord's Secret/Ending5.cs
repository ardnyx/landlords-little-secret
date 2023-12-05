using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Little_Landlord_s_Secret
{
    internal class Ending5
    {
        public static void Ending5s()
        {
            //added ending 5
            say("Mock the landlady and piss her off, there's no way an old lady can catch up to you anyways.");
            say($"While running without looking properly, {Program.player} was successfully trapped by the landlady, the landlady laughs.");
            say("Landlady: You must be some kind of stupid to not figure out why I can kill all those people way younger than me, I know every nook and cranny of this house. No one can just run around aimlessly");
            say("System: The landlady was able to catch up to you in no time, the sprain in your foot is not something that you experienced before, the pain as well as the fear of for the landlady made you defecate on your own clothes, that was the last moment you remember in this life.");
            say("You died full of regrets.");
        }
        static void say(string message)
        {
            WriteLine($"{message}\n");
            ReadKey();
        }
    }
}
