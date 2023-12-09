using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Landlords_Little_Secret;
using Little_Landlord_s_Secret;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlTypes;

public static class ChoiceSelector
{
    public static int lettercount = 0;
    public static bool answeredPhone = false;
    public static bool wentHome => alternativeRoute.wentHome;
    public static bool declinedPhone => alternativeRoute.declinedPhone;
    public static bool throwPhone { get; private set; } = false;
    public static bool destroyEnvelope { get; private set; } = false;
    public static bool wrestleLandlady { get; private set; } = false;
    public static bool map { get; private set; } = false;
    public static bool earlyStab { get; private set; } = false;

    /* ALTERNATIVE ENDING */
    public static string subtleKnock()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Answer the door\n",
            "B. Sleep Again\n"
        });
        if (choice == 1)
        {
            return alternativeRoute.outsideDoor();
        }
        else
        {
            WriteLine($"\nYou wake up to three loud knocks coming from outside!");
            ReadKey();
            WriteLine("\nYou need to do something about the noise!\n");
            ReadKey();
            return alternativeRoute.outsideDoor();
        }
    }
    /* NORMAL ENDING (PERFECT RUN)
 _   _  ___  ____  __  __    _    _       _____ _   _ ____ ___ _   _  ____ 
| \ | |/ _ \|  _ \|  \/  |  / \  | |     | ____| \ | |  _ \_ _| \ | |/ ___|
|  \| | | | | |_) | |\/| | / _ \ | |     |  _| |  \| | | | | ||  \| | |  _ 
| |\  | |_| |  _ <| |  | |/ ___ \| |___  | |___| |\  | |_| | || |\  | |_| |
|_| \_|\___/|_| \_\_|  |_/_/   \_\_____| |_____|_| \_|____/___|_| \_|\____|*/
    public static string choice_abandonedAlleyway()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Try to help the anonymous man.",
            "B. Continue going home." });
        switch (choice)
        {
            case 1:
                return normalEnding.HelpAnonymousMan();
            case 2:
                return alternativeRoute.altRouteStart();
            default:
                return "Invalid";
        }
    }
    public static string choice_holdingSomething()
    {
        int choice = choiceTemplate(2, 2, new List<string> {
            "A. Run away from the man, what he's holding might be dangerous!\n",
            "B. **Ask him about the thing that he's trying to give you as well as his identity.\n" });
        if (choice == 2)
        {
            return normalEnding.AskAnonymousMan();
        }
        else
        {
            return alternativeRoute.altRouteStart();
        }
    }
    public static string choiceEnvelope()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Pick up the sealed envelope and read the content.\n",
            "B. Destroy the sealed envelope without reading its content.\n" });
        if (choice == 1)
        {
            return normalEnding.ReadEnvelope();
        }
        else
        {
            destroyEnvelope = true;
            return alternativeRoute.GoHome();
        }
    }
    public static string choiceLetterContent()
    {
        List<string> choices;

        if (answeredPhone)
        {
            choices = new List<string>
            {
                "???!!"
            };
        }
        else if (declinedPhone && lettercount >= 2)
        {
            choices = new List<string>
            {
                "No.. way.."
            };
        }
        else if (lettercount >= 2)
        {
            choices = new List<string>
            {
                "What.. the fuck?! This letter-"
            };
        }
        else
        {
            choices = new List<string>
            {
                "A. I guess I’ll try to go, I need to get gramps’ belongings from there anyway. I doubt there will be anything to see.\n",
                "B. This is some crazy prank, my grandfather ran away; he had dementia and the landlady was already nice enough to dedicate her time to taking care of him. She cried so much when she told us the news!\n"
            };
        }
        int choice = choiceTemplate(choices.Count, 2, choices);
        if (choice == 1)
        {
            if (answeredPhone)
            {
                say($"{Program.player}: Who.. was that?");
                say($"{Program.player}: But as stupid as it sounds, I really have to go.");
            }
            else if (declinedPhone && lettercount >= 2)
            {
                say($"{Program.player}: This.. I can't.. but I have to go.");
            }
            else if (lettercount >= 2)
            {
                say($"{Program.player}: Stay calm-- stay calm.");
                say($"{Program.player}: Let's go then.");
            }
            return normalEnding.GoToHouse();
        }
        else
        {
            lettercount++;
            return alternativeRoute.crazyPrank();
        }
    }
    public static string phoneCall()
    {
        List<string> choices = new List<string>
        {
            "A. Answer the phone call",
            "B. Throw your phone away and hide in your house.\n"
        };

        if (wentHome)
        {
            choices[1] = "B. Decline the phone call\n";
        }

        int choice = choiceTemplate(2, 1, choices);

        if (choice == 1)
        {
            answeredPhone = true;
            return alternativeRoute.phoneCall();
        }
        else if (wentHome)
        {
            return alternativeRoute.threwPhoneandWentHome();
        }
        else
        {
            throwPhone = true;
            ForegroundColor = ConsoleColor.Red;
            BackgroundColor = ConsoleColor.Black;
            WriteLine("YOU THREW YOUR PHONE AWAY\n");
            ResetColor();
            ReadKey();
            return alternativeRoute.GoHome();
        }
    }

    public static string choiceHouseArrived()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Push the doorbell and try to look approachable towards the elderly landlady as much as possible.\n",
            "B. Knock on the door and wait with a straight face, trying to look as unaware as possible.\n" });
        if (choice == 1)
        {
            return normalEnding.pushDoorbell();
        }
        else
        {
            return normalEnding.pushDoorbell();
        }
    }

    public static string choiceMeetLandlady(bool clearConsole = true)
    {
        int choice = choiceTemplate(2, 2, new List<string> {
            "A. Check in on her instead, just in case she says something confirming the contents of the letter.\n",
            "B. Confirm her guess, lest she suspects something.\n" });
        if (choice == 2)
        {
            return normalEnding.confirmGuess();
        }
        else
        {
            return normalEnding.checkInOnHer();
        }
    }

    public static string choiceInsideHouse()
    {
        int choice = choiceTemplate(4, 1, new List<string> {
            "A. Sit in the living room and observe the house as a whole.\n",
            "B. Follow her into the kitchen and offer some help.\n",
            "C. Go to [Tenant 1]’s room, perhaps you can ask her some things.\n",
            "D. Go to [Tenant 2]’s room, his weird tendencies may help reveal some things.\n" });
        string result = string.Empty;
        if (choice == 1)
        {
            result = normalEnding.sitLivingRoom();
        }
        else if (choice == 2)
        {
            result = Ending4.helpLandlady();
        }
        else if (choice == 3)
        {
            //Ending2.Ending2Map();
            result = Ending2.kateRoom();
        }
        else
        {
            result = Ending4.tenant2Room();
        }
        return result;
    }
    public static string choiceSomethingHollow()
    {
        int choice = choiceTemplate(3, 1, new List<string> {
            "A. There must be a reason why there’s some hollow spots in this sofa. I need to look into this more.\n",
            "B. This is a very old sofa after all, I just take a look and if there’s nothing suspicious, then it’s just me being paranoid.\n",
            "C. It’s nothing, if there’s anything suspicious, it has to be in my grandfather’s room, not in some place like the living room sofa.\n" });
        if (choice == 1)
        {
            return normalEnding.investigateSofa();
        }
        else if (choice == 2)
        {
            return "WIP"; //This is a very old sofa after all, I just take a look and if there’s nothing suspicious, then it’s just me being paranoid
        }
        else
        {
            return Ending2.investigateSofa();
        }
    }
    public static string choiceInvestigateSofa()
    {
        int choice = choiceTemplate(3, 2, new List<string> {
            "A. Act composed, this basically confirms that something dark is happening here. But this isn’t my grandfather’s fingernail at all!\n",
            "B. Something dark is happening here. I need to confront the landlady about this.\n",
            "C. Hm? Ah this fingernail might be from [Tenant 2], I've heard he does disgusting things all the time. I'll inform the landlady just in case.\n" });
        if (choice == 2)
        {
            return normalEnding.confrontOldLady();
        }
        else if (choice == 1)
        {
            return Ending3.Ending3P2();
        }
        else
        {
            return Ending4.doesntSuspect();
        }
    }
    public static string choiceConfrontLady()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Let’s see who can pull out a knife first. She’s senile, being a psychopath won’t help her.\n",
            "B. This… I need more time to prepare.\n" });
        if (choice == 1)
        {
            return normalEnding.pullKnife();
        }
        else
        {
            return "WIP"; //This… I need more time to prepare.
        }
    }
    public static string choiceHearOtherSide()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Answer ambiguously, suggest something that can make her show her true colors. I need to hear her side first.\n",
            "B. I don’t need to walk around the bush, she’s definitely some type of crazy.\n" });
        if (choice == 1)
        {
            return normalEnding.listenToLady();
        }
        else
        {
            return "WIP"; //I don’t need to walk around the bush, she’s definitely some type of crazy.
        }
    }
    public static string choiceContinueTalking()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. I need to continue talking to her, I need more answers before I end her myself!\n",
            "B. One stab, and we’re done with this nightmare!\n" });
        if (choice == 1)
        {
            return normalEnding.investigateLadyFurther();
        }
        else
        {
            earlyStab = true;
            return normalEnding.attackAttempt();
        }
    }
    public static string choiceInvestigateFurther()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. I’ll just ask her when she’s half dead, I got to get rid of this woman!\n",
            "B. I need her to experience what she did to her victims.\n" });
        if (choice == 1)
        {
            return normalEnding.attackAttempt();
        }
        else
        {
            return "WIP"; //I need her to experience what she did to her victims.
        }
    }
    public static string choiceAttackAttempt()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Try to reach the knife near the kitchen entrance to stab the landlady. You might be able to inflict a serious injury, but your back will be open.\n",
            "B. Take advantage of the time and smash her head yourself, regardless of her disgusting pain tolerance, she will be dizzy.\n" });
        if (choice == 1)
        {
            return normalEnding.grabKnifeToAttack();
        }
        else
        {
            return Ending6.Greed();
        }
    }
    public static string choiceNormalEnding()
    {
        WriteLine("Bonus for finishing the game perfectly! How do you want this confrontation to end?\n\n");
        int choice = choiceTemplate(2, 1, new List<string> {
            "A. Tie the landlady up, and ask her where your grandfather’s remains are as well as your doubts.\n",
            "B. Just kill her! I want to end this nightmare!\n" });
        if (choice == 1)
        {
            return normalEnding.perfectrunEnding();
        }
        else
        {
            return "WIP"; //Just kill her! I want to end this nightmare!
        }
    }

    /* ENDING 1 */
    public static string choiceNextMove()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "A. Confront the landlord about what you saw.\n",
            "B. Report to the Police, they have to be the ones to give justice.\n"
        });
        if (choice == 2)
        {
            return Ending1.reportPolice();
        }
        else
        {
            return normalEnding.confrontOldLady();
        }
    }

    /* ENDING 2
 _____ _   _ ____ ___ _   _  ____   ____  
| ____| \ | |  _ \_ _| \ | |/ ___| |___ \ 
|  _| |  \| | | | | ||  \| | |  _    __) |
| |___| |\  | |_| | || |\  | |_| |  / __/ 
|_____|_| \_|____/___|_| \_|\____| |_____|*/
    public static string choiceKateRoom()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Feeling like you did something wrong, you close the door and act like nothing happened.\n",
            "B. Enter the room carefully and inspect the letters.\n"
        });

        if (choice == 1)
        {
            return Ending2.kateRoomCaught();
        }
        else
        {
            return "WIP"; // Enter the room carefully and inspect the letters.
        }
    }
    public static string choiceRagedUser()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "A. Continue listening to the landlady.\n",
            "B. Filled with rage, you lunge and tackle the landlady.\n"
        });

        if (choice == 2)
        {
            return Ending2.tackleLandlady();
        }
        else
        {
            wrestleLandlady = true;
            return Ending2.continueListening();
        }
    }
    public static string choiceEscape()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "A. Wrestle with the landlady.\n",
            "B. Try to escape from the landlady.\n"
        });

        if (choice == 2)
        {
            return Ending2.escapeLandlady();
        }
        else
        {
            wrestleLandlady = true;
            return Ending2.keepWrestling();
        }
    }
    public static string choiceRunOrMock()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Run towards the exit and escape the boarding house.\n",
            "B. Mock the landlady and piss her off, there's no way an old lady can catch up to you anyways.\n"
        });

        if (wrestleLandlady)
        {
            return Ending5.Ending5s();
        }
        else
        {
            if (choice == 1)
            {
                return Ending2.Finale();
            }
            else
            {
                return Ending2.Finale();
            }
        }
    }

    /* ENDING 3
 _____ _   _ ____ ___ _   _  ____   _____ 
| ____| \ | |  _ \_ _| \ | |/ ___| |___ / 
|  _| |  \| | | | | ||  \| | |  _    |_ \ 
| |___| |\  | |_| | || |\  | |_| |  ___) |
|_____|_| \_|____/___|_| \_|\____| |____/ */
    public static string choiceExitAttempt()
    {
        int choice = choiceTemplate(2, 1, new List<string> {
            "Exit the boarding house quietly and report to the authorities.\n",
            "Confront the landlady about your suspicion\n" });
        if (choice == 1)
        {
            return Ending3.Ending3P3();
        }
        else
        {
            return normalEnding.confrontOldLady();
        }
    }
    public static string choiceFollowOrders()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "Run towards the exit",
            "Follow the landlady's orders\n"});
        if (choice == 2)
        {
            return Ending3.Ending3P4();
        }
        else
        {
            return Ending2.escapeLandlady();
        }
    }
    public static string choicePanicked()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "I have nothing to do with my grandfather’s disappearance! In fact, I was even trying to find my grandfather in this establishment!\n",
            "Don’t listen to her! She is making stuff up!\n"});
        if (choice == 1)
        {
            return Ending3.Ending3P5();
        }
        else
        {
            return Ending6.Ending6Part1();
        }
    }
    public static string choiceAskforInvestigation()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "Ask the officer to investigate what happened inside the boarding house and look at the sofa.\n",
            "Continue framing the landlady, distracting the officer from the investigation.\n" });
        if (choice == 2)
        {
            return Ending3.Ending3Finale();
        }
        else
        {
            return Ending6.Ending6Part1();
        }
    }


    /* ENDING 4
 _____ _   _ ____ ___ _   _  ____   _  _   
| ____| \ | |  _ \_ _| \ | |/ ___| | || |  
|  _| |  \| | | | | ||  \| | |  _  | || |_ 
| |___| |\  | |_| | || |\  | |_| | |__   _|
|_____|_| \_|____/___|_| \_|\____|    |_|  */

    public static string choiceGrabVeggies()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Sure, what should I get?\n",
            "B. I'm sorry, I am very scared of the insects from your garden. Can I help you with something else?\n"
        });

        if (choice == 1)
        {
            return Ending4.youShouldGet();
        }
        else
        {
            return Ending4.littleRascal();
        }
    }
    public static string choiceMadalingAraw()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "A. Probably just neighborhood cats\n",
            "B. What was that? I should check it out.\n"
        });

        if (choice == 2)
        {
            return Ending4.peepGarden();
        }
        else
        {
            return choiceMadalingAraw();//Probably just neighborhood cats.
        }
    }
    public static string choiceSusGarden()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Hurry up and run back to room before landlord sees me here.\n",
            "B. I should leave no evidence i was here and go to my room\n"
        });

        if (choice == 1)
        {
            return Ending4.footprintEvidence();
        }
        else
        {
            return Ending1.removeEvidence();
        }
    }
    public static string choiceEatBreakfast()
    {
        int choice = choiceTemplate(2, 2, new List<string>
        {
            "A. I'm already late for work i should get going\n",
            "B. That's great! i'll be down in a bit\n"
        });

        if (choice == 2)
        {
            return Ending4.susBreakfast();
        }
        else
        {
            return choiceEatBreakfast();//I'm already late for work, I should get going
        }
    }
    public static string choiceDishes()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. I'm running a bit late, but a quick bite shouldn't hurt.\n",
            "B. This breakfast looks amazing, and I'm really tempted to dive in, but I'm running a bit late.\n"
        });

        if (choice == 1)
        {
            return Ending4.poisonedFood();
        }
        else
        {
            return choiceDishes();//This breakfast looks amazing, and I'm really tempted to dive in, but I'm running a bit late.
        }
    }
    public static string choiceTrytoKill()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. (While still having a little strength) I WILL KILL YOU! You deserve to die!!!\n",
            "B. Grab a knife and charge at the landlady.\n"
        });

        if (choice == 1 || choice == 2)
        {
            return Ending4.Finale();
        }
        else
        {
            return "Invalid Action: Only choose between 1 and 2";
        }
    }
    /* ENDING 6
 _____ _   _ ____ ___ _   _  ____    __   
| ____| \ | |  _ \_ _| \ | |/ ___|  / /_  
|  _| |  \| | | | | ||  \| | |  _  | '_ \ 
| |___| |\  | |_| | || |\  | |_| | | (_) |
|_____|_| \_|____/___|_| \_|\____|  \___/ */

    public static string choiceAngrytoPolice()
    {
        int choice = choiceTemplate(2, 1, new List<string>
        {
            "A. Thank you officer, I'll keep your promise to heart. You can call me if you need anything for the investigation\n",
            "B. You better! Do your job properly and don't listen to a senile old lady, this is why everyone sees your force as corrupt! Can't even do your jobs properly!\n"
        });
        if (choice == 2)
        {
            return Ending6.angryToOfficer();
        }
        else
        {
            return Ending3.Ending3Finale();
        }
    }
    private static int choiceTemplate(int maxChoice, int correctAnswer, List<string> choices)
    {
        int selectedIndex = 0;
        int choiceStartRow = Console.CursorTop;
        ConsoleKeyInfo key;
        bool choiceMade = false;
        do
        {
            SetCursorPosition(0, choiceStartRow);
            for (int i = 0; i < maxChoice; i++)
            {
                if (i == selectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Write(choices[i]);
                if (i == selectedIndex)
                {
                    ResetColor();
                }
                int nextCursorPosition = choiceStartRow + i + 1;
                if (nextCursorPosition < Console.WindowHeight)
                {
                    SetCursorPosition(0, nextCursorPosition);
                }
            }

            key = ReadKey();

            if (!choiceMade)
            {
                if (key.Key == ConsoleKey.UpArrow && selectedIndex > 0)
                {
                    selectedIndex--;
                }
                else if (key.Key == ConsoleKey.DownArrow && selectedIndex < maxChoice - 1)
                {
                    selectedIndex++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    choiceMade = true;
                }
            }
            ResetColor();
        } while (!choiceMade);
        SetCursorPosition(0, choiceStartRow + maxChoice);
        WriteLine();
        return selectedIndex + 1;
    }
    private static int GetChoice(int maxChoice)
    {
        int choice;
        while (true)
        {
            Write("Enter your choice: ");
            if (int.TryParse(ReadLine(), out choice) && choice > 0 && choice <= maxChoice)
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
    static void say(string message)
    {
        WriteLine($"{message}\n");
        while (ReadKey(true).Key != ConsoleKey.Spacebar)
        {
            // Continue consuming keys until Enter is pressed
        }
    }
}
