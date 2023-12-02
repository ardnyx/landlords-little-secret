using System;
using System.Data;
using System.Security.Cryptography;

class Program
{
    static string player;
     static void Main()
    {
        player = GetInput("Please Enter Your Name: ");
        clear();
        say($"Welcome, {player}. Your journey into the Landlord’s Little Secret begins now.");
        say($"Your determination will guide you through the shadows of this ominous boarding house.");
        say($"Remember, every choice you make shapes the outcome of this chilling tale.");
        say($"Prepare yourself, {player}, for the secrets that lie ahead.");
        say($"-- Press any key to continue --");

        StoryIntroduction();
    }

    static void StoryIntroduction()
    {
        clear();
        say($"In an abandoned alleyway late at night. You encounter a disheveled man clutching a sealed envelope.");
        Console.WriteLine($"A. Try to help the anonymous man.\n" +
            $"B. Continue going home.\n");

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
        Console.WriteLine($"{player}: Hey, are you okay? You look troubled.\n");
        Console.ReadKey();
        Console.WriteLine($"Anonymous Man:[Breathing Heavily] Please, take this. It's for you.\n");
        Console.ReadKey() ;
        Console.WriteLine("(The anonymous man tries to hands over the sealed envelope to you.)");

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
        Console.WriteLine($"{player}: What's this about? Who are you?\n");
        Console.ReadKey();
        Console.WriteLine($"Anonymous Man: No time... [coughs] ...just read it. \n");
        Console.ReadKey();
        Console.WriteLine("(While gasping for breath, The Anonymous Man staggers, collapsing to the ground.)\n");
        Console.ReadKey();
        Console.WriteLine($"{player}: [Startled] Hey! Are you alright? Someone help!\n");
        Console.ReadKey();
        Console.WriteLine($"Anonymous Man: [Weakly] No use... [struggles to speak] ...it's... too late for me. Find... truth.\n");
        Console.ReadKey();
        Console.WriteLine($"{player}: [Urgently] Hold on! I'll call for an ambulance!\n");
        Console.ReadKey();
        Console.WriteLine($"Anonymous Man: [Whispers] No...\n");
        Console.ReadKey();
        Console.WriteLine(" (As the man closes his eyes, he takes his last breath before dying...)\n");
        Console.ReadKey();
        Console.WriteLine($"{player}: [Panicked, checking pulse] No, no, please... \n");
        Console.ReadKey();
        Console.WriteLine($"[Realizing the Anonymous Man has passed away, {player} notices the sealed envelope clutched tightly in his hand.]\n");
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
        Console.WriteLine("(Door Unlocks, revealing an amicable old lady holding a vacuum cleaner while wearing an apron.)\n");
        Console.ReadKey();
        Console.WriteLine($"Landlady: Oh! It’s you {player}, how may I help you? Are you here to get [Grandfather’s Name]’s things?\n");
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
        Console.WriteLine($"{player}: You’re right, my grandfather’s things are our last memory of him after all as the authorities still don't have any clues. They told us that the chances are very slim considering my grandfather’s condition\n");
        Console.ReadKey();
        Console.WriteLine($"Landlady: I just wanna say, I’m very sorry for what happened. I will take responsibility and provide as much compensation that I can handle.\n");
        Console.ReadKey();
        Console.WriteLine($"{player}: We know that you’re not at fault, we already talked about it when the police were first involved. We are also at fault, we prioritized our careers more instead of taking care of the person who helped all of us establish ourselves.\n");
        Console.ReadKey();
        Console.WriteLine($"Landlady: Come in, come in! I’ll prepare some food for you. You can feel at home, {player}.\n");
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
        Console.WriteLine($"{player} decided to sit in the living room and look around, when you sat down on the wooden sofa, you felt something hollow.\n");
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
        say($"{player} decided to find something suspicious in those hollow spots; after a couple of minutes, the landlady still didn’t return.");
        Console.WriteLine($"There you found something that looks like scratches from a person getting dragged!\n");
        Console.ReadKey();
        Console.WriteLine($"There were also bloodstains and even a whole fingernail under the sofa!\n");
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
        Console.WriteLine($"YOu decided to confront the landlady in the kitchen, but you don't have anything on hand that\n" +
            $" can help you defend yourself just in case it’s something dangerous as kitchens are basically filled with knives.\n");
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
        say($"{player}: [Landlady], I need to talk to you about something. I saw something in your living room just now.");
        say($"Landlady: Hm? What is it?");
        say($"{player}: Well actually, someone gave me a letter yesterday. The letter said that you have some involvement in my grandfather’s disappearance.");
        say($"Landlady: Well, do you believe him?");
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
        say($"{player}: Maybe I do, maybe I don’t. I definitely need to hear your side of the story.");
        say($"Landlady: I don't look like you want to hear anything from me, {player}, you look very angry right now.");
        say($"{player}: What are you trying to say?");
        say($"Landlady: I guess you’ll be angrier when you figure out everything.");
        say($"{player}: Are you just admitting to it like that?");
        say($"Landlady: Oh, no one’s admitting anything. I just wanna say that, what you’re trying to figure out is something that you can ask directly to your grandfather.");
        say($"{player}: What? You know where he is?!");
        say($"Landlady: Well of course I do, he’s around many places. I put him there myself!");
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
        say($"{player}: What do you mean?");
        say($"Landlady: You know what that means, I divided him. He and his stupid student wanted to act like police officers when I’m trying to do my business here! \n" +
            $"I guess that crazy bloke died too, he even made the letter he gave you very cryptic. \n" +
            $"He’s a stupid guy until his last breath!");
        say($"{player}: You…");
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
        say($"(You decided to lunge towards the unarmed landlady, but you didn’t expect the strength from a woman in their sixties. She’s insanely strong!)\n");
        say($"Landlady: (heavy breathing) Did you think I’m weak? How do you think they died then?");
        say($"{player}: You! Just! Won’t! Shut! Up!");
        say($"Landlady: (laughs crazily) It’s because of this you moron!");
        say($"\n(The landlady smashed her own head on you, disregarding her own safety!)");
        say($"(This is your last choice, your fate will be determined by this choice!)");
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
        say($"(You got stood up but not without stomping on the landlady’s foreleg.)\n");
        say($"(The landlady bit on your calf without hesitation. The landlady was dragged by you through her mouth using his leg, causing you immense pain!)\n");
        say($"(You have reached the knife!)\n");
        Console.WriteLine("Bonus for finishing the game perfectly. How do you want this confrontation to end?\n\n" +
            "A. **Tie the landlady up, and ask her where your grandfather’s remains are as well as your doubts.**\r\n" +
            "B. Just kill her! I want to end this nightmare!\r\n");
        int choice = GetChoice(2);

        if (choice == 1)
        {
            normalEnding();
        }
        else
        {
            //Just kill her! I want to end this nightmare!
        }
    }

    static void normalEnding()
    {
        clear();
        say($"{player}: Just so you know, I’m now the one to decide. Before I kill you, I need to know, where are my grandfather’s remains?");
        say($"Landlady: (whispers) You’re very arrogant for someone with a wasted leg (laughs weakly). \n" +
            $"Well, all I can say is only his limbs are with me, they’re in my garden along with the other bodies. \n" +
            $"All the others? You have to figure it out yourself (laughs with all her might)");
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

    static void say(string message)
    {
        Console.WriteLine($"{message}\n");
        Console.ReadKey();
    }
}