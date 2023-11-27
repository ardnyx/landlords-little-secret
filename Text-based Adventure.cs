using System;
using System.Security.Cryptography;

class Program
{
    static string player = GetInput("What is your name? ");

    static void Main()
    {
        clear();
        Console.WriteLine($"Welcome, {player}. Your journey into the Landlord’s Little Secret begins now. \n" +
                          $"Your determination will guide you through the shadows of this ominous boarding house. \n" +
                          $"Remember, every choice you make shapes the outcome of this chilling tale. Prepare \n" +
                          $"yourself, {player}, for the secrets that lie ahead.");

        Console.WriteLine("\nPress any key to continue!");
        Console.ReadKey();

        StoryIntroduction();
    }

    static void StoryIntroduction()
    {
        clear();
        Console.WriteLine("[In an abandoned alleyway late at night. You encounter a disheveled man clutching a sealed envelope.]");
        Console.WriteLine("\nA. **Try to help the anonymous man.**");
        Console.WriteLine("B. Continue going home.\n");

        int choice = GetChoice(2);

        if (choice == 1)
        {
            HelpAnonymousMan();
        }
        else
        {
            // Continue going home
        }
    }

    static void HelpAnonymousMan()
    {
        clear();
        Console.WriteLine($"{player}: Hey, are you okay? You look troubled.\n\n" +
            $"Anonymous Man: [Breathing heavily] Please, take this. It's for you. [Hands over the sealed envelope.]");
        Console.ReadKey();

        Console.WriteLine("\nA. Run away from the man, what he's holding might be dangerous!");
        Console.WriteLine("B. **Ask him about the thing that he's trying to give you as well as his identity.**\n");

        int choice = GetChoice(2);

        if (choice == 2)
        {
            AskAnonymousMan();
        }
        else
        {
            // Run away from the man, what he's holding might be dangerous.
        }
    }

    static void AskAnonymousMan()
    {
        clear();
        Console.WriteLine($"{player}: What's this about? Who are you?\n\n" +
            $"Anonymous Man: No time... [coughs] ...just read it. [Gasping for breath, Mr. Johnson staggers, collapsing to the ground.]\n\n" +
            $"{player}: [Startled] Hey! Are you alright? Someone help!\n\n" +
            $"Anonymous Man: [Weakly] No use... [struggles to speak] ...it's... too late for me. Find... truth. [passes out]\n\n" +
            $"{player}: [Urgently] Hold on! I'll call for an ambulance!\n\n" +
            $"Anonymous Man: [Whispers] No... [closes eyes, breathes his last]\n\n" +
            $"{player}: [Panicked, checking pulse] No, no, please... [Realizing the Anonymous Man has passed away, {player} notices the sealed envelope clutched tightly in his hand.]\n");
        Console.ReadKey();
        Console.WriteLine("A. **Pick up the sealed envelope and read the content.**\n" +
            "B. Destroy the sealed envelope without reading its content.\n");
        int choice = GetChoice(2);

        if (choice == 1)
        {
            ReadEnvelope();
        }
        else
        {
            //Destroy the sealed envelope without reading its content.
        }
    }

    static void ReadEnvelope()
    {
        clear();
        Console.WriteLine($"Dear {player},\n\n" +
            $"Your grandfather's absence isn't a mere vanishing act. It's a thread in the tangled web that lurks within those walls. His story is just one piece of a larger puzzle, lost amid the murkiness of this place.\n\n" +
            $"Every corner within that house holds echoes of something concealed, waiting for a curious eye to uncover. Your journey will depend on the choices you make, the threads you choose to follow.\n\n" +
            $"Beware, for not everything will be as it appears. Trust will be a luxury you cannot afford, and truth will wear many masks.\n\n" +
            $"The Landlord’s Little Secret isn't a place of comfort; it's a labyrinth of uncertainties. Tread carefully, for the answers you seek are entwined within its mysteries.\n");
        Console.ReadKey();
        Console.WriteLine("A. This is some crazy prank, my grandfather ran away; he had dementia and the landlady was already nice enough to dedicate her time to taking care of him. She cried so much when she told us the news!\n" +
            "B. **I guess I’ll try to go, I need to get gramps’ belongings from there anyway. I doubt there will be anything to see.**\n");

        int choice = GetChoice(2);

        if (choice == 2)
        {
            GoToHouse();
        }
        else
        {
            //This is some crazy prank, my grandfather ran away; he had dementia and the landlady was already nice enough to dedicate her time to taking care of him. She cried so much when she told us the news!
        }
    }

    static void GoToHouse()
    {
        clear();
        Console.WriteLine($"{player} has decided to proceed towards the boarding house. After a few hours of packing and traveling, you have arrived at the [Tranquil Oaks Boarding House].\n");
        Console.ReadKey();
        Console.WriteLine("A. **Push the doorbell and try to look approachable towards the elderly landlady as much as possible.**\n" +
            "B. Knock on the door and wait with a straight face, trying to look as unaware as possible.\n");

        int choice = GetChoice(2);

        if (choice == 1)
        {
            pushDoorbell();
        }
        else
        {
            //Knock on the door and wait with a straight face, trying to look as unaware as possible.
        }
    }

    static void pushDoorbell()
    {
        clear();
        Console.WriteLine($"Door Unlocks, revealing an amicable old lady holding a vacuum cleaner while wearing an apron.\n" +
            $"Landlady: Oh! It’s you {player}, how may I help you? Are you here to get [Grandfather’s Name]’s things?\n");
        Console.ReadKey();
        Console.WriteLine("A. Check in on her instead, just in case she says something confirming the contents of the letter.\r\n" +
            "B. **Confirm her guess, lest she suspects something.**\r\n");

        int choice = GetChoice(2);

        if (choice == 2)
        {
            confirmGuess();
        }
        else
        {
            //Check in on her instead, just in case she says something confirming the contents of the letter.
        }
    }

    static void confirmGuess()
    {
        clear();
        Console.WriteLine($"{player}: You’re right, my grandfather’s things are our last memory of him after all as the authorities still don't have any clues. They told us that the chances are very slim considering my grandfather’s condition\n\n" +
            $"Landlady: I just wanna say, I’m very sorry for what happened. I will take responsibility and provide as much compensation that I can handle.\n\n" +
            $"{player}: We know that you’re not at fault, we already talked about it when the police were first involved. We are also at fault, we prioritized our careers more instead of taking care of the person who helped all of us establish ourselves.\n\n" +
            $"Landlady: Come in, come in! I’ll prepare some food for you. You can feel at home, {player}.\n");
        Console.ReadKey();
        Console.WriteLine("A. **Sit in the living room and observe the house as a whole.** \r\n" +
            "B. Follow her into the kitchen and offer some help.\r\n" +
            "C. Go to [Tenant 1]’s room, perhaps you can ask her some things.\r\n" +
            "D. Go to [Tenant 2]’s room, his weird tendencies may help reveal some things.\r\n");

        int choice = GetChoice(4);

        if (choice == 1)
        {
            sitLivingRoom();
        }
        else if (choice == 2)
        {
            //Follow her into the kitchen and offer some help.
        }
        else if (choice == 3)
        {
            //Go to [Tenant 1]’s room, perhaps you can ask her some things.
        }
        else
        {
            //Go to [Tenant 2]’s room, his weird tendencies may help reveal some things.
        }
    }

    static void sitLivingRoom()
    {
        clear();
        Console.WriteLine($"{player} decided to sit in the living room and look around, when {player} sat down on the wooden sofa, he felt something hollow.\n");
        Console.ReadKey();
        Console.WriteLine("A. **There must be a reason why there’s some hollow spots in this sofa. I need to look into this more.**\r\n" +
            "B. This is a very old sofa after all, I just take a look and if there’s nothing suspicious, then it’s just me being paranoid.\r\n" +
            "C. It’s nothing, if there’s anything suspicious, it has to be in my grandfather’s room, not in some place like the living room sofa.\r\n");

        int choice = GetChoice(3);

        if (choice == 1)
        {
            investigateSofa();
        }
        else if (choice == 2)
        {
            //This is a very old sofa after all, I just take a look and if there’s nothing suspicious, then it’s just me being paranoid
        }
        else
        {
            //It’s nothing, if there’s anything suspicious, it has to be in my grandfather’s room, not in some place like the living room sofa.
        }
    }

    static void investigateSofa()
    {
        clear();
        Console.WriteLine($"{player} decided to find something suspicious in those hollow spots; after a couple of minutes, the landlady still didn’t return. \n" +
            $"There {player} found something that looks like scratches from a person getting dragged!\n" +
            $"There were also bloodstains and even a whole fingernail under the sofa!\n");
        Console.ReadKey();
        Console.WriteLine("A. Act composed, this basically confirms that something dark is happening here. But this isn’t my grandfather’s fingernail at all!\r\n" +
            "B. **I need to confront the old lady, I’m sure she doesn’t have much strength, I can take her down.**\r\n" +
            "C. This might be from [Tenant 2], I heard he does bizarre disgusting things all the time. I’ll inform the landlady just in case.\r\n");

        int choice = GetChoice(3);

        if (choice == 2)
        {
            confrontOldLady();
        }
        else if (choice == 1)
        {
            //Act composed, this basically confirms that something dark is happening here. But this isn’t my grandfather’s fingernail at all!
        }
        else
        {
            //This might be from [Tenant 2], I heard he does bizarre disgusting things all the time. I’ll inform the landlady just in case.
        }
    }

    static void confrontOldLady()
    {
        clear();
        Console.WriteLine($"{player} decided to confront the landlady in the kitchen, but {player} doesn’t have anything on hand that\n" +
            $" can help him defend himself just in case it’s something dangerous as kitchens are basically filled with knives.\n");
        Console.ReadKey();
        Console.WriteLine("A. **Let’s see who can pull out a knife first. She’s senile, being a psychopath won’t help her.**\r\n" +
            "B. This… I need more time to prepare.\r\n");

        int choice = GetChoice(2);

        if (choice == 1)
        {
            pullKnife();
        }
        else
        {
            //This… I need more time to prepare.
        }
    }

    static void pullKnife()
    {
        clear();
        Console.WriteLine($"{player}: Landlady, I need to talk to you about something. I saw something in your living room just now." +
            $"\n\nLandlady: Hm? What is it? " +
            $"\n\n{player}: Well actually, someone gave me a letter yesterday. The letter said that you have some involvement in my grandfather’s disappearance." +
            $"\n\nLandlady: Well, do you believe him?\n");
        Console.ReadKey();
        Console.WriteLine("A. **Answer ambiguously, suggest something that can make her show her true colors. I need to hear her side first.**\r\n" +
            "B. I don’t need to walk around the bush, she’s definitely some type of crazy.\r\n");

        int choice = GetChoice(2);

        if (choice == 1)
        {
            listenToLady();
        }
        else
        {
            //I don’t need to walk around the bush, she’s definitely some type of crazy.
        }
    }

    static void listenToLady()
    {
        clear();
        Console.WriteLine($"{player}: Maybe I do, maybe I don’t. I definitely need to hear your side of the story.\n\n" +
            $"Landlady: I doesn’t look like you want to hear anything from me, {player}, you look very angry right now.\n\n" +
            $"{player}: What are you trying to say?\n\n" +
            $"Landlady: I guess you’ll be angrier when you figure out everything.\n\n" +
            $"{player}: Are you just admitting to it like that? \n\n" +
            $"Landlady: Oh, no one’s admitting anything. I just wanna say that, what you’re trying to figure out is something that you can ask directly to your grandfather.\n\n" +
            $"{player}: What? You know where he is?!\n\nLandlady: Well of course I do, he’s around many places. I put him there myself!\n");
        Console.ReadKey();
        Console.WriteLine("A. **I need to continue talking to her, I need more answers before I end her myself!**\r\n" +
            "B. One stab, and we’re done with this nightmare!\r\n");

        int choice = GetChoice(2);

        if (choice == 1)
        {
            investigateLadyFurther();
        }
        else
        {
            //One stab, and we’re done with this nightmare!
        }
    }

    static void investigateLadyFurther()
    {
        clear();
        Console.WriteLine($"{player}: What do you mean?\n\n" +
            $"Landlady: You know what that means, I divided him. He and his stupid student wanted to act like police officers when I’m trying to do my business here! I guess that crazy bloke died too, he even made the letter he gave you very cryptic. He’s a stupid guy until his last breath!\n\n" +
            $"{player}: You...\n");
        Console.ReadKey();
        Console.WriteLine("A. **I’ll just ask her when she’s half dead, I got to get rid of this woman!**\r\n" +
            "B. I need her to experience what she did to her victims.\r\n");

        int choice = GetChoice(2);

        if (choice == 1)
        {
            attackAttempt();
        }
        else
        {
            //I need her to experience what she did to her victims.
        }
    }

    static void attackAttempt()
    {
        clear();
        Console.WriteLine($"{player} decided to lunge towards the unarmed landlady, but {player} didn’t expect the strength from a woman in their sixties. She’s insanely strong!\n\n" +
            $"Landlady: (heavy breathing) Did you think I’m weak? How do you think they died then?\n\n" +
            $"{player}: You! Just! Won’t! Shut! Up!\n\n" +
            $"Landlady: (laughs crazily) It’s because of this you moron!\n\n");
        Console.ReadKey();
        Console.WriteLine($"The landlady smashed her own head on {player}’s, disregarding her own safety!\n\n");
        Console.ReadKey();
        Console.WriteLine($"This is your last choice, your fate will be determined by this choice!\n");
        Console.WriteLine("A. **Try to reach the knife near the kitchen entrance to stab the landlady. You might be able to inflict a serious injury, but your back will be open.**\r\n" +
            "B. Take advantage of the time and smash her head yourself, regardless of her disgusting pain tolerance, she will be dizzy.\r\n");
        int choice = GetChoice(2);

        if (choice == 1)
        {
            grabKnifeToAttack();
        }
        else
        {
            //Take advantage of the time and smash her head yourself, regardless of her disgusting pain tolerance, she will be dizzy.
        }
    }

    static void grabKnifeToAttack()
    {
        clear();
        Console.WriteLine($"{player} got stood up but not without stomping on the landlady’s foreleg.\n\n");
        Console.ReadKey();
        Console.WriteLine($"The landlady bit on {player}’s calf without hesitation. The landlady was dragged by {player} through her mouth using his leg, causing {player} immense pain!\n\n");
        Console.ReadKey();
        Console.WriteLine("You have reached the knife!\n\n");
        Console.WriteLine("Bonus for finishing the game perfectly. How do you want this confrontation to end?\n");
        Console.WriteLine("A. **Tie the landlady up, and ask her where your grandfather’s remains are as well as your doubts.**\r\n" +
            "B. Just kill her! I want to end this nightmare!\r\n");
        int choice = GetChoice(2);

        if (choice == 1)
        {
            ending1();
        }
        else
        {
            //Just kill her! I want to end this nightmare!
        }
    }

    static void ending1()
    {
        clear();
        Console.WriteLine($"{player}: Just so you know, I’m now the one to decide. Before I kill you, I need to know, where are my grandfather’s remains?\n\n" +
            $"Landlady: (whispers) You’re very arrogant for someone with a wasted leg (laughs weakly). Well, all I can say is only his limbs are with me, they’re in my garden along with the other bodies. All the others? You have to figure it out yourself (laughs with all her might).\n\n");
        Console.ReadKey();
        Console.WriteLine($"As {player} is about to punch her, {player} saw the landlady play with her dentures, \n" +
            $"revealing a small capsule that she immediately swallowed. In just a little over ten seconds, the heartbeat of the landlady stopped.");
        Console.ReadKey();
    }
    static int GetChoice(int maxChoice)
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
                Console.WriteLine($"Invalid choice. Please enter a number between 1 and {maxChoice}");
            }
        }
        return choice;
    }

    static string GetInput(string input)
    {
        Console.Write(input);
        return Console.ReadLine();
    }
    static void clear()
    {
        Console.Clear();
    }
}
