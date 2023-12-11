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
        public static string helpLandlady()
        {
            say($"Landlady: Sure I could use some help? Well, will you please get some vegetables from my garden? I need them for the thing that I'm cooking for you");
            return ChoiceSelector.choiceGrabVeggies();
        }
        public static string youShouldGet()
        {
            say($"Landlady: I want you to fetch me some corns from the garden. I remembered planting some a few weeks ago, check them out if they're already ripe.");
            say($"{Program.player}:Alright then.");
            Clear();
            Title = "You are Currently in the Garden";
            int x = 7, y = 10;
            string[,] map = {
           { "|", "-", "-", "-", "-", "-", "-",  "-",  "-", "-", "-", "-", "-", "-", "|" },
           { "|", "O", " ", "O", " ", "O", " ",  " ",  " ", "O", " ", "O", " ", "O", "|",},
           { "|", " ", " ", " ", " ", " ", " ",  " ",  " ", " ", " ", " ", " ", " ", "|",},
           { "|", "O", " ", "O", " ", "O", " ",  " ",  " ", "O", " ", "O", " ", "O", "|",},
           { "|", " ", " ", " ", " ", " ", " ",  " ",  " ", " ", " ", " ", " ", " ", "|",},
           { "|", "O", " ", "O", " ", "O", " ",  " ",  " ", "O", " ", "O", " ", "O", "|",},
           { "|", " ", " ", " ", " ", " ", " ",  " ",  " ", " ", " ", " ", " ", " ", "|",},
           { "|", "O", " ", "O", " ", "O", " ",  " ",  " ", "O", " ", "O", " ", "O", "|",},
           { "|", " ", " ", " ", " ", " ", " ",  " ",  " ", " ", " ", " ", " ", " ", "|",},
           { "|", "O", " ", "O", " ", "O", " ",  " ",  " ", "O", " ", "O", " ", "O", "|",},
           { "|", " ", " ", " ", " ", " ", " ",  " ",  " ", " ", " ", " ", " ", " ", "|",},
           { "|", "^", "^", "^", "^", "^", "^",  "^",  "^", "^", "^", "^", "^", "^", "|" },
       };
            while (true)
            {
                Clear();
                map[y, x] = "X";
                int Rows = map.GetLength(0);
                int Cols = map.GetLength(1);
                if (map[2, 13] == "X")
                {
                    say($"(While you were harvesting, something odd caught your eye which doesn't look like a... corn..?");
                    say($"{Program.player}: This.. is..");
                    return ChoiceSelector.choiceInvestigateSofa();

                }
                else
                {
                    for (int j = 0; j < Rows; j++)
                    {
                        for (int i = 0; i < Cols; i++)
                        {
                            string element = map[j, i];
                            SetCursorPosition(i, j);
                            Write(element + "\t");
                        }
                    }
                    WriteLine("\n\nWalk beside the Corn to Collect them");
                    WriteLine("Use the Arrow Keys to Move");
                    WriteLine("\nLegend:");
                    WriteLine("O = Corn to be Harvested");
                    WriteLine("* = Corn is Harvested");
                    WriteLine("X = Player Location");
                    WriteLine("| = Fence");
                    WriteLine("- = Fence");
                    WriteLine("^ = Fence");
                    WriteLine();
                    ConsoleKeyInfo keyInfo = ReadKey(true);
                    ConsoleKey key = keyInfo.Key;
                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            if (0 < y - 2 && y - 2 < Rows)
                            {
                                if (map[y - 2, x] == " ")
                                {
                                    map[y, x] = " ";
                                    y -= 2;
                                    if (map[y - 1, x] == "O" && map[y + 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";
                                    }
                                    else if (map[y - 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";

                                    }
                                    else if (map[y + 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";
                                    }
                                }
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (0 < y + 2 && y + 2 < Rows)
                            {
                                if (map[y + 2, x] == " ")
                                {
                                    map[y, x] = " ";
                                    y += 2;
                                    if (map[y - 1, x] == "O" && map[y + 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";

                                    }
                                    else if (map[y - 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";

                                    }

                                    else if (map[y + 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";

                                    }
                                }
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            if (0 < x - 2 && x - 2 < Cols)
                            {
                                if (map[y, x - 2] == " ")
                                {
                                    map[y, x] = " ";
                                    x -= 2;
                                    if (map[y - 1, x] == "O" && map[y + 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";

                                    }
                                    else if (map[y - 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";

                                    }

                                    else if (map[y + 1, x] == "O")
                                    {
                                        map[y - 1, x] = "*";
                                        map[y + 1, x] = "*";

                                    }

                                }
                            }
                            break;

                        case ConsoleKey.RightArrow:
                            if (0 < x + 2 && x + 2 < Cols)
                            {
                                map[y, x] = " ";

                                x += 2;

                                if (map[y - 1, x] == "O" && map[y + 1, x] == "O")
                                {
                                    map[y - 1, x] = "*";
                                    map[y + 1, x] = "*";

                                }
                                else if (map[y - 1, x] == "O")
                                {
                                    map[y - 1, x] = "*";
                                    map[y + 1, x] = "*";

                                }

                                else if (map[y + 1, x] == "O")
                                {
                                    map[y - 1, x] = "*";
                                    map[y + 1, x] = "*";

                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public static string joneMap()
        {
            Game currentGame = new Game();
            currentGame.StartjoneRoom();
            return "";
        }
        public static string tenant2Room()
        {
            Clear();
            say($" (You went up the second floor)");
            say($" (You have reached the hallways)");
            for(int x = 0; x < 3; x++)
            {
                say($".");
            }
            say($"Finger...nails..?");
            return ChoiceSelector.choiceInvestigateSofa();
        }
        public static string littleRascal()
        {
            Clear();
            say($"Landlady: Oh you little rascal! You're already an adult but you're still scared of some dirt! \n" +
                $"          Just sit in the living room and wait then, lunch will be ready in a while.");
            return normalEnding.sitLivingRoom();
        }
        public static string doesntSuspect()
        {
            say($" (Despite spotting a fingernail on the garden, you dismissed it even though you felt a bit stressed and uncomfortable)");
            say($"{Program.player}: A-ah.. Well I guess this is just some of the disgusting things the other tenant usually does. Anyway, I have to bring these corns back to landlady.");
            say($" (You walk back to the house)");
            say($"{Program.player}: I'm back. here's your corns.");
            say($"Landlady: Great! The dish will be almost done. Just stay in touch for now.");
            say($"{Program.player}: Thanks! And oh, I saw a fingernail.. or was it a fingernail, anyway, I saw it on your garden when I was picking up corns. \n" +
                $"I think it's from the other tenant, I heard he usually has this weird disgusting hobbies.. right?");
            say($"Landlady: O-oh! haha, I'm so sorry about that, I'll talk to him later on, my gosh he needs some scolding!");
            say($" (After helping the landlady, nothing much happened aftwardds.)");
            say($" (It's already night. You came back to your room and slept. The first day...");
            say($" isn't done.");
            return middleOfTheNight();
        }
        public static string middleOfTheNight()
        {
            say($" (In the middle of the night, you hear something strange in the garden shed.)");
            return ChoiceSelector.choiceMadalingAraw();
        }
        public static string peepGarden()
        {
            say($"(Peeping in the garden shed door you saw the landlady burying a human body, conforming your suspicions and due to the shock, you knocked down garden tools letting out a loud crash.)");
            return ChoiceSelector.choiceSusGarden();
        }
        public static string footprintEvidence()
        {
            say($"(The landlord sees footprints and suspects that you saw her. But then shouting “these damn cats! Always messing with my tools”. \n" +
                $"Player thinks she is non the wiser and continues to sleep. Morning comes the landlady knocks on your door.)");
            say($"Landlady: Time for breakfast. I’ve prepared a special meal for my new tenant.");
            return ChoiceSelector.choiceEatBreakfast();
        }
        public static string susBreakfast()
        {
            say($"(You open the door to the kitchen, and the sight before you are nothing short of a breakfast masterpiece. The table is adorned with an array of mouthwatering dishes.)");
            return ChoiceSelector.choiceDishes();
        }
        public static string poisonedFood()
        {
            say($"Halfway through the meal you feel something in your stomach, An aching pain."); ReadKey(); Write($"THE LANDLADY POISONED THE FOOD!");
            return ChoiceSelector.choiceTrytoKill();
        }
        public static string Finale2()
        {
            Clear();
            say($" (You underestimated the mental fortitude of the psychotic landlady.");
            say($"  She never cared about her own well-being and instead just excited to torment someone.");
            say($"  Seeing you go for mutual destruction is the biggest mistake for yourself,");
            say($"  and the ultimate death for her.)");
            return "Finale2";
        }
        public static string Finale()
        {
            say($" (With so little strength you were unable to overpower her. Laying on the ground the landlady whispered)");
            say($"Landlady: You had the chance to escape, yet you opted to linger and tamper with my affairs. \n" +
                $"Now, look at yourself on the ground, gasping for your final breath.");
            say($" (The last thing you saw was the grim reflection of your own tormented face in the mirror. \n" +
                $"Your eyes, once filled with deceit and cunning, now held only a look of abject terror.) \n" +
                $"You had become a victim of her, consumed by the darkness she had created.");
            say($" (And as you took your final breath, the secrets of the building remained buried beneath the weight of the floor. \n" +
                $"The tenants, unaware of the sinister truth that lurked within their walls, continued their daily lives, oblivious to the darkness that is reigning among them.)");
            return "Ending 4 Finale";
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
}
