﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Little_Landlord_s_Secret
{
    class Ending1
    {
        public static void removeEvidence()
        {
            Clear();
            say($"You were able to get rid of your own presence in the garden, and you were able to make a quick break to the police station.");
            say($"You have to plan for your next move. What do you want to do next?");
            ChoiceSelector.choiceNextMove();
        }
        public static void reportPolice()
        {
            Clear();
            say($"You were able to inform the authorities on time, without arousing any suspicion from the landlady, you were able to get justice for your grandfather without being harmed, you were rewarded by your city for your bravery and were thanked by the families of the other victims");
        }
        static void say(string message)
        {
            WriteLine($"{message}\n");
            ReadKey();
        }
    }
}