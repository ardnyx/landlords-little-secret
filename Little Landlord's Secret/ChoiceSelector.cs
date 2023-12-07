using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Landlords_Little_Secret;
using Little_Landlord_s_Secret;
using System.Net.Mail;

public static class ChoiceSelector
{
    /* ALTERNATIVE ENDING */
    public static void subtleKnock()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Answer the door",
            "B. Sleep Again\n"
        });
        if (choice == 1)
        {
            alternativeRoute.outsideDoor();
        }
        else
        {
            WriteLine($"You wake up to three loud knocks coming from outside!");
            ReadKey();
            WriteLine("\nYou need to do something about the noise!");
            ReadKey();
            alternativeRoute.outsideDoor();
            //You wake up to three loud knocks coming from outside.
        }
    }
    /* NORMAL ENDING (PERFECT RUN)
 _   _  ___  ____  __  __    _    _       _____ _   _ ____ ___ _   _  ____ 
| \ | |/ _ \|  _ \|  \/  |  / \  | |     | ____| \ | |  _ \_ _| \ | |/ ___|
|  \| | | | | |_) | |\/| | / _ \ | |     |  _| |  \| | | | | ||  \| | |  _ 
| |\  | |_| |  _ <| |  | |/ ___ \| |___  | |___| |\  | |_| | || |\  | |_| |
|_| \_|\___/|_| \_\_|  |_/_/   \_\_____| |_____|_| \_|____/___|_| \_|\____|*/
    public static void choice_abandonedAlleyway()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Try to help the anonymous man.",
            "B. Continue going home.\n" });
        switch (choice)
        {
            case 1:
                normalEnding.HelpAnonymousMan();
                break;
            case 2:
                alternativeRoute.altRouteStart();
                break;
        }
    }
    public static void choice_holdingSomething()
    {
        int choice = choiceTemplate(2, 2, new List<string> {
            "A. Run away from the man, what he's holding might be dangerous!",
            "B. **Ask him about the thing that he's trying to give you as well as his identity.\n" });
        if (choice == 2)
        {
            normalEnding.AskAnonymousMan();
        }
        else
        {
            alternativeRoute.altRouteStart();
        }
    }
    public static void choiceEnvelope()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Pick up the sealed envelope and read the content.",
            "B. Destroy the sealed envelope without reading its content.\n" });
        if (choice == 1)
        {
            normalEnding.ReadEnvelope();
        }
        else
        {
            alternativeRoute.GoHome();
        }
    }
    public static void choiceLetterContent()
    {
        int choice = choiceTemplate(2, 2, new List<string> {
            "A. This is some crazy prank, my grandfather ran away; he had dementia and the landlady was already nice enough to dedicate her time to taking care of him. She cried so much when she told us the news!",
            "B. I guess I’ll try to go, I need to get gramps’ belongings from there anyway. I doubt there will be anything to see.\n" });
        if (choice == 2)
        {
            normalEnding.GoToHouse();
        }
        else
        {
            alternativeRoute.crazyPrank();
        }
    }
    public static void phoneCall()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Answer the phone call",
            "B. Throw your phone away and hide in your house.\n"
        });
        if (choice == 1)
        {
            alternativeRoute.phoneCall();
        }
        else
        {
            alternativeRoute.GoHome();
        }
    }

    public static void choiceHouseArrived()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Push the doorbell and try to look approachable towards the elderly landlady as much as possible.",
            "B. Knock on the door and wait with a straight face, trying to look as unaware as possible.\n" });
        if (choice == 1)
        {
            normalEnding.pushDoorbell();
        }
        else
        {
            normalEnding.pushDoorbell();
        }
    }

    public static void choiceMeetLandlady()
    {
        int choice = choiceTemplate(2, 2, new List<string> {
            "A. Check in on her instead, just in case she says something confirming the contents of the letter.",
            "B. Confirm her guess, lest she suspects something.\n" });
        if (choice == 2)
        {
            normalEnding.confirmGuess();
        }
        else
        {
            normalEnding.checkInOnHer();
        }
    }

    public static void choiceInsideHouse()
    {
        int choice = choiceTemplate(4, 1, new List<string> {
            "A. Sit in the living room and observe the house as a whole.",
            "B. Follow her into the kitchen and offer some help.",
            "C. Go to [Tenant 1]’s room, perhaps you can ask her some things.",
            "D. Go to [Tenant 2]’s room, his weird tendencies may help reveal some things.\n" });
        if (choice == 1)
        {
            normalEnding.sitLivingRoom();
        }
        else if (choice == 2)
        {
            Ending4.helpLandlady();
        }
        else if (choice == 3)
        {
            Ending2.kateRoom();
        }
        else
        {
            Ending4.tenant2Room();
        }
    }
    public static void choiceSomethingHollow()
    {
        int choice = choiceTemplate(3, 1, new List<string> {
            "A. There must be a reason why there’s some hollow spots in this sofa. I need to look into this more.",
            "B. This is a very old sofa after all, I just take a look and if there’s nothing suspicious, then it’s just me being paranoid.",
            "C. It’s nothing, if there’s anything suspicious, it has to be in my grandfather’s room, not in some place like the living room sofa.\n" });
        if (choice == 1)
        {
            normalEnding.investigateSofa();
        }
        else if (choice == 2)
        {
            //This is a very old sofa after all, I just take a look and if there’s nothing suspicious, then it’s just me being paranoid
        }
        else
        {
            Ending2.investigateSofa();
        }
    }
    public static void choiceInvestigateSofa()
    {
        int choice = choiceTemplate(3, 2, new List<string> {
            "A. Act composed, this basically confirms that something dark is happening here. But this isn’t my grandfather’s fingernail at all!",
            "B. Something dark is happening here. I need to confront the landlady about this.",
            "C. Hm? Ah this fingernail might be from [Tenant 2], I've heard he does disgusting things all the time. I'll inform the landlady just in case." });
        if (choice == 2)
        {
            normalEnding.confrontOldLady();
        }
        else if (choice == 1)
        {
            Ending3.Ending3P2();
        }
        else
        {
            Ending4.doesntSuspect();
        }
    }
    public static void choiceConfrontLady()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Let’s see who can pull out a knife first. She’s senile, being a psychopath won’t help her.",
            "B. This… I need more time to prepare.\n" });
        if (choice == 1)
        {
            normalEnding.pullKnife();
        }
        else
        {
            //This… I need more time to prepare.
        }
    }
    public static void choiceHearOtherSide()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Answer ambiguously, suggest something that can make her show her true colors. I need to hear her side first.",
            "B. I don’t need to walk around the bush, she’s definitely some type of crazy.\n" });
        if (choice == 1)
        {
            normalEnding.listenToLady();
        }
        else
        {
            //I don’t need to walk around the bush, she’s definitely some type of crazy.
        }
    }
    public static void choiceContinueTalking()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. I need to continue talking to her, I need more answers before I end her myself!",
            "B. One stab, and we’re done with this nightmare!\n" });
        if (choice == 1)
        {
            normalEnding.investigateLadyFurther();
        }
        else
        {
            //One stab, and we’re done with this nightmare!
        }
    }
    public static void choiceInvestigateFurther()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. I’ll just ask her when she’s half dead, I got to get rid of this woman!",
            "B. I need her to experience what she did to her victims.\n" });
        if (choice == 1)
        {
            normalEnding.attackAttempt();
        }
        else
        {
            //I need her to experience what she did to her victims.
        }
    }
    public static void choiceAttackAttempt()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Try to reach the knife near the kitchen entrance to stab the landlady. You might be able to inflict a serious injury, but your back will be open.",
            "B. Take advantage of the time and smash her head yourself, regardless of her disgusting pain tolerance, she will be dizzy.\n" });
        if (choice == 1)
        {
            normalEnding.grabKnifeToAttack();
        }
        else
        {
            //Take advantage of the time and smash her head yourself, regardless of her disgusting pain tolerance, she will be dizzy.
        }
    }
    public static void choiceNormalEnding()
    {
        WriteLine("Bonus for finishing the game perfectly! How do you want this confrontation to end?\n\n");
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Tie the landlady up, and ask her where your grandfather’s remains are as well as your doubts." +
            "B. Just kill her! I want to end this nightmare!\n" });
        if (choice == 1)
        {
            normalEnding.perfectrunEnding();
        }
        else
        {
            //Just kill her! I want to end this nightmare!
        }
    }

    /* ENDING 1 */
    public static void choiceNextMove()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "A. Confront the landlord about what you saw.",
            "B. Report to the Police, they have to be the ones to give justice.\n"
        });
        if (choice == 2)
        {
            Ending1.reportPolice();
        }
        else
        {
            normalEnding.confrontOldLady();
        }
    }

    /* ENDING 2
 _____ _   _ ____ ___ _   _  ____   ____  
| ____| \ | |  _ \_ _| \ | |/ ___| |___ \ 
|  _| |  \| | | | | ||  \| | |  _    __) |
| |___| |\  | |_| | || |\  | |_| |  / __/ 
|_____|_| \_|____/___|_| \_|\____| |_____|*/
    public static void choiceKateRoom()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Feeling like you did something wrong, you close the door and act like nothing happened.",
            "B. Enter the room carefully and inspect the letters.\n"
        });

        if (choice == 1)
        {
            Ending2.kateRoomCaught();
        }
        else
        {
            // Enter the room carefully and inspect the letters.
        }
    }
    public static void choiceRagedUser()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "A. Continue listening to the landlady.",
            "B. Filled with rage, you lunge and tackle the landlady.\n"
        });

        if (choice == 2)
        {
            Ending2.tackleLandlady();
        }
        else
        {
            //Continue listening to the landlady.
        }
    }
    public static void choiceEscape()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "A. Wrestle with the landlady.",
            "B. Try to escape from the landlady.\n"
        });

        if (choice == 2)
        {
            Ending2.escapeLandlady();
        }
        else
        {
            //Wrestle with the landlady.
        }
    }
    public static void choiceRunOrMock()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Run towards the exit and escape the boarding house.",
            "B. Mock the landlady and piss her off, there's no way an old lady can catch up to you anyways.\n"
        });

        if (choice == 1)
        {
            Ending2.Finale();
        }
        else
        {
            Ending5.Ending5s();
        }
    }

    /* ENDING 3
 _____ _   _ ____ ___ _   _  ____   _____ 
| ____| \ | |  _ \_ _| \ | |/ ___| |___ / 
|  _| |  \| | | | | ||  \| | |  _    |_ \ 
| |___| |\  | |_| | || |\  | |_| |  ___) |
|_____|_| \_|____/___|_| \_|\____| |____/ */
    public static void choiceExitAttempt()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "Exit the boarding house quietly and report to the authorities.",
            "Confront the landlady about your suspicion\n" });
        if (choice == 1)
        {
            Ending3.Ending3P3();
        }
        else
        {
            normalEnding.confrontOldLady();
        }
    }
    public static void choiceFollowOrders()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "Run towards the exit",
            "Follow the landlady's orders\n"});
        if (choice == 2)
        {
            Ending3.Ending3P4();
        }
        else
        {
            Ending2.escapeLandlady();
        }
    }
    public static void choicePanicked()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "I have nothing to do with my grandfather’s disappearance! In fact, I was even trying to find my grandfather in this establishment!",
            "Don’t listen to her! She is making stuff up!\n"});
        if (choice == 1)
        {
            Ending3.Ending3P5();
        }
        else
        {
            Ending6.Ending6Part1();
        }
    }
    public static void choiceAskforInvestigation()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "Ask the officer to investigate what happened inside the boarding house and look at the sofa.",
            "Continue framing the landlady, distracting the officer from the investigation.\n" });
        if (choice == 2)
        {
            Ending3.Ending3Finale();
        }
        else
        {
            Ending6.Ending6Part1();
        }
    }


    /* ENDING 4
 _____ _   _ ____ ___ _   _  ____   _  _   
| ____| \ | |  _ \_ _| \ | |/ ___| | || |  
|  _| |  \| | | | | ||  \| | |  _  | || |_ 
| |___| |\  | |_| | || |\  | |_| | |__   _|
|_____|_| \_|____/___|_| \_|\____|    |_|  */

    public static void choiceGrabVeggies()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Sure, what should I get?",
            "B. I'm sorry, I am very scared of the insects from your garden. Can I help you with something else?\n"
        });

        if (choice == 1)
        {
            Ending4.youShouldGet();
        }
        else
        {
            Ending4.littleRascal();
        }
    }
    public static void choiceMadalingAraw()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "A. Probably just neighborhood cats",
            "B. What was that? I should check it out.\n"
        });

        if (choice == 2)
        {
            Ending4.peepGarden();
        }
        else
        {
            //Probably just neighborhood cats.
        }
    }
    public static void choiceSusGarden()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Hurry up and run back to room before landlord sees me here.",
            "B. I should leave no evidence i was here and go to my room\n"
        });

        if (choice == 1)
        {
            Ending4.footprintEvidence();
        }
        else
        {
            Ending1.removeEvidence();
        }
    }
    public static void choiceEatBreakfast()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "A. I'm already late for work i should get going",
            "B. That's great! i'll be down in a bit\n"
        });

        if (choice == 2)
        {
            Ending4.susBreakfast();
        }
        else
        {
            //I'm already late for work, I should get going
        }
    }
    public static void choiceDishes()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. I'm running a bit late, but a quick bite shouldn't hurt.",
            "B. This breakfast looks amazing, and I'm really tempted to dive in, but I'm running a bit late.\n"
        });

        if (choice == 1)
        {
            Ending4.poisonedFood();
        }
        else
        {
            //This breakfast looks amazing, and I'm really tempted to dive in, but I'm running a bit late.
        }
    }
    public static void choiceTrytoKill()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. (While still having a little strength) I WILL KILL YOU! You deserve to die!!!",
            "B. Grab a knife and charge at the landlady.\n"
        });

        if (choice == 1 || choice == 2)
        {
            Ending4.Finale();
        }
    }



    /* ENDING 5
 _____ _   _ ____ ___ _   _  ____   ____  
| ____| \ | |  _ \_ _| \ | |/ ___| | ___| 
|  _| |  \| | | | | ||  \| | |  _  |___ \ 
| |___| |\  | |_| | || |\  | |_| |  ___) |
|_____|_| \_|____/___|_| \_|\____| |____/ */


    /* ENDING 6
 _____ _   _ ____ ___ _   _  ____    __   
| ____| \ | |  _ \_ _| \ | |/ ___|  / /_  
|  _| |  \| | | | | ||  \| | |  _  | '_ \ 
| |___| |\  | |_| | || |\  | |_| | | (_) |
|_____|_| \_|____/___|_| \_|\____|  \___/ */

    public static void choiceAngrytoPolice()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Thank you officer, I'll keep your promise to heart. You can call me if you need anything for the investigation",
            "B. You better! Do your job properly and don't listen to a senile old lady, this is why everyone sees your force as corrupt! Can't even do your jobs properly!\n"
        });
        if (choice == 2)
        {
            Ending6.angryToOfficer();
        }
        else
        {
            Ending3.Ending3Finale();
        }
    }


    private static int choiceTemplate(int maxChoice, int correctAnswer, List<string> choices)
    {
        for (int x = 0; x < maxChoice; x++)
        {
            WriteLine($"{choices[x]}");
        }
        return GetChoice(maxChoice);
    }
    private static int GetChoice(int maxChoice)
    {
        int choice;
        while (true)
        {
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice <= maxChoice)
            {
                break;
            }
            else
            {
                WriteLine($"Invalid choice. Please enter a number between 1 and {maxChoice}");
            }
        }
        return choice;
    }
}
