using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Little_Landlord_s_Secret
{
    internal class Ending4
    {
        public void helpLandlady()
        {
            say($"Landlady: Sure I could use some help? Well, will you please get some vegetables from my garden? I need them for the thing that I'm cooking for you");
            //Sure, what should I get?
        }
        public void whatShouldGet()
        {
            //NEED REVISIONS
        }
        public void informedLandlady()
        {
            //NEED REVISIONS
        }
        public void middleOfTheNight()
        {
            say($"(In the middle of the night, you hear something strange in the garden shed.)");
            //What was that? I should check it out.
        }
        public void peepGarden()
        {
            say($"(Peeping in the garden shed door you saw the landlady burying a human body, conforming your suspicions and due to the shock, you knocked down garden tools letting out a loud crash.)");
            //hurry up and run back to room before landlord sees me here.
        }
        public void footprintEvidence()
        {
            say($"(The landlord sees footprints and suspects that you saw her. But then shouting “these damn cats! Always messing with my tools”. \n" +
                $"Player thinks she is non the wiser and continues to sleep. Morning comes the landlady knocks on your door.)");
            say($"Landlady: Time for breakfast. I’ve prepared a special meal for my new tenant.");
            //that's great! i'll be down in a bit
        }
        public void susBreakfast()
        {
            say($"(You open the door to the kitchen, and the sight before you are nothing short of a breakfast masterpiece. The table is adorned with an array of mouthwatering dishes.)");
            //i'm running a bit late, but a quick bite shouldn't hurt
        }
        public void poisonedFood()
        {
            say($"Halfway through the meal you feel something in your stomach, An aching pain."); ReadKey(); Write($"THE LANDLADY POISONED THE FOOD!");
            //*while still having a little strength you grab her* “I WILL KILL YOU; you deserve to die!!!”
            //grab a knife and charge at the land lady
        }
        public void Finale()
        {
            say($" (With so little strength you were unable to overpower her. Laying on the ground the landlady whispered)");
            say($"Landlady: You had the chance to escape, yet you opted to linger and tamper with my affairs. \n" +
                $"Now, look at yourself on the ground, gasping for your final breath.");
            say($" (The last thing you saw was the grim reflection of your own tormented face in the mirror. \n" +
                $"Your eyes, once filled with deceit and cunning, now held only a look of abject terror.) \n" +
                $"You had become a victim of her, consumed by the darkness she had created.");
            say($" (And as you took your final breath, the secrets of the building remained buried beneath the weight of the floor. \n" +
                $"The tenants, unaware of the sinister truth that lurked within their walls, continued their daily lives, oblivious to the darkness that is reigning among them.)");
        }
        static void say(string message)
        {
            WriteLine($"{message}\n");
            ReadKey();
        }
    }
}
