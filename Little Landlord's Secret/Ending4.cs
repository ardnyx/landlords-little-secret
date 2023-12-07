using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Little_Landlord_s_Secret
{
    internal class Ending4
    {
        public static void helpLandlady()
        {
            Clear();
            say($"Landlady: Sure I could use some help? Well, will you please get some vegetables from my garden? I need them for the thing that I'm cooking for you");
            ChoiceSelector.choiceGrabVeggies();
        }
        public static void youShouldGet()
        {
            Clear();
            say($"Landlady: I want you to fetch me some corns from the garden. I remembered planting some a few weeks ago, check them out if they're already ripe.");
            say($"{Program.player}:Alright then.");
            say($"(While you were harvesting, something odd caught your eye which doesn't look like a... corn..?");
            say($"{Program.player}: This.. is..");
            ChoiceSelector.choiceInvestigateSofa();
        }
        public static void tenant2Room()
        {
            Clear();
            say($" (You went up the second floor)");
            say($" (You have reached the hallways)");
            for(int x = 0; x < 3; x++)
            {
                say($".");
            }
            say($"Finger...nails..?");
            ChoiceSelector.choiceInvestigateSofa();
        }
        public static void littleRascal()
        {
            Clear();
            say($"Landlady: Oh you little rascal! You're already  an adult but you're still scared of some dirt! \n" +
                $"Just sit in the living room and wait then, lunch will be ready in a while.");
        }
        public static void doesntSuspect()
        {
            Clear();
            say($" (Despite spotting a fingernail on the garden, you dismissed it even though you felt a bit stressed and uncomfortable)");
            say($"{Program.player}: A-ah.. Well I guess this is just some of the disgusting things the other tenant usually does. Anyway, I have to bring these corns back to landlady.");
            say($" (You walk back to the house)");
            Clear();
            say($"{Program.player}: I'm back. here's your corns.");
            say($"Landlady: Great! The dish will be almost done. Just stay in touch for now.");
            say($"{Program.player}: Thanks! And oh, I saw a fingernail.. or was it a fingernail, anyway, I saw it on your garden when I was picking up corns. \n" +
                $"I think it's from the other tenant, I heard he usually has this weird disgusting hobbies.. right?");
            say($"Landlady: O-oh! haha, I'm so sorry about that, I'll talk to him later on, my gosh he needs some scolding!");
            say($" (After helping the landlady, nothing much happened aftwardds.)");
            Write($" (It's already night. You came back to your room and slept. The first day...");
            Write($" isn't done.");
            ReadKey();
            middleOfTheNight();
        }
        public static void middleOfTheNight()
        {
            Clear();
            say($" (In the middle of the night, you hear something strange in the garden shed.)");
            ChoiceSelector.choiceMadalingAraw();
        }
        public static void peepGarden()
        {
            say($"(Peeping in the garden shed door you saw the landlady burying a human body, conforming your suspicions and due to the shock, you knocked down garden tools letting out a loud crash.)");
            ChoiceSelector.choiceSusGarden();
        }
        public static void footprintEvidence()
        {
            say($"(The landlord sees footprints and suspects that you saw her. But then shouting “these damn cats! Always messing with my tools”. \n" +
                $"Player thinks she is non the wiser and continues to sleep. Morning comes the landlady knocks on your door.)");
            say($"Landlady: Time for breakfast. I’ve prepared a special meal for my new tenant.");
            ChoiceSelector.choiceEatBreakfast();
        }
        public static void susBreakfast()
        {
            say($"(You open the door to the kitchen, and the sight before you are nothing short of a breakfast masterpiece. The table is adorned with an array of mouthwatering dishes.)");
            ChoiceSelector.choiceDishes();
        }
        public static void poisonedFood()
        {
            say($"Halfway through the meal you feel something in your stomach, An aching pain."); ReadKey(); Write($"THE LANDLADY POISONED THE FOOD!");
            ChoiceSelector.choiceTrytoKill();
        }
        public static void Finale()
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
