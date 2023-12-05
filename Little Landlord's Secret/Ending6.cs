using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Little_Landlord_s_Secret
{
    internal class Ending6
    {
        public void Ending6Part1()
        {
            say($"{Program.player}: Can you hear her? She's absurd! Why are you still not arresting her? I'm going to sue you incompetent police as well!");
            say($"(Your threat did not make the officers happy, they started seeing you in the same light as the landlady as your agitated look made it seem like you're guilty)");
            say($"Police Officer: Don't worry, sir, we'll serve justice to those who deserve it..");
            //You better! Do your job properly yand don't listen to a senile
            // old lady, this is why everyone sees your force as corrupt! Can't even do
            //do your jobs properly!
        }
        public void angryToOfficer()
        {
            say($"Police Officer: I think you've had enough time to sort yourself out. You're just disrespecting us at this point. \n" +
                $"Now, regardless if you're the suspect or not, you need to go to the police station first!");
            say($"(When you were taken into custody  by the police, the landlady made sure to plant evidences including your fingerprints in the corpses in the garden, because of this, every single person doubted you. \n" +
                $"Because of the accusations, you experienced a severe mental breakdown and even believed the accusations that were put to you yourself. \n" +
                $"The landlady is still free, and your incarceration buried the the doubts that are lingering around that boarding house.)");
        }
        static void say(string message)
        {
            WriteLine($"{message}\n");
            ReadKey();
        }
    }
}
