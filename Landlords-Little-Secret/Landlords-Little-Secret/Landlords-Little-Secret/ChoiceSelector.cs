using System;
public static class ChoiceSelector
{
	public static void choice_abandonedAlleyway()
	{
        Console.WriteLine($"A. Try to help the anonymous man.\n" +
            $"B. Continue going home.\n");

        int choice = normalEnding.GetChoice(2);

        if (choice == 1)
        {
            normalEnding.HelpAnonymousMan();
        }
        else
        {
            // Continue going home
        }
    }
    public static void choice_holdingSomething()
    {
        Console.WriteLine("\nA. Run away from the man, what he's holding might be dangerous!");
        Console.WriteLine("B. **Ask him about the thing that he's trying to give you as well as his identity.**\n");

        int choice = normalEnding.GetChoice(2);

        if (choice == 2)
        {
            normalEnding.AskAnonymousMan();
        }
        else
        {
            // Run away from the man, what he's holding might be dangerous.
        }
    }
    public static void choiceEnvelope()
    {
        Console.WriteLine("A. **Pick up the sealed envelope and read the content.**\n" +
            "B. Destroy the sealed envelope without reading its content.\n");
        int choice = normalEnding.GetChoice(2);

        if (choice == 1)
        {
            normalEnding.ReadEnvelope();
        }
        else
        {
            //Destroy the sealed envelope without reading its content.
        }
    }
    public static void choiceLetterContent()
    {
        Console.WriteLine("A. This is some crazy prank, my grandfather ran away; he had dementia and the landlady was already nice enough to dedicate her time to taking care of him. She cried so much when she told us the news!\n" +
            "B. **I guess I’ll try to go, I need to get gramps’ belongings from there anyway. I doubt there will be anything to see.**\n");

        int choice = normalEnding.GetChoice(2);

        if (choice == 2)
        {
            normalEnding.GoToHouse();
        }
        else
        {
            //This is some crazy prank, my grandfather ran away; he had dementia and the landlady was already nice enough to dedicate her time to taking care of him. She cried so much when she told us the news!
        }
    }

    public static void choiceHouseArrived()
    {
        Console.WriteLine("A. **Push the doorbell and try to look approachable towards the elderly landlady as much as possible.**\n" +
            "B. Knock on the door and wait with a straight face, trying to look as unaware as possible.\n");

        int choice = normalEnding.GetChoice(2);

        if (choice == 1)
        {
            normalEnding.pushDoorbell();
        }
        else
        {
            //Knock on the door and wait with a straight face, trying to look as unaware as possible.
        }
    }

    public static void choiceMeetLandlady()
    {
        Console.WriteLine("A. Check in on her instead, just in case she says something confirming the contents of the letter.\r\n" +
            "B. **Confirm her guess, lest she suspects something.**\r\n");

        int choice = normalEnding.GetChoice(2);

        if (choice == 2)
        {
            normalEnding.confirmGuess();
        }
        else
        {
            //Check in on her instead, just in case she says something confirming the contents of the letter.
        }
    }

    public static void choiceInsideHouse()
    {
        Console.WriteLine("A. **Sit in the living room and observe the house as a whole.** \r\n" +
            "B. Follow her into the kitchen and offer some help.\r\n" +
            "C. Go to [Tenant 1]’s room, perhaps you can ask her some things.\r\n" +
            "D. Go to [Tenant 2]’s room, his weird tendencies may help reveal some things.\r\n");

        int choice = normalEnding.GetChoice(4);

        if (choice == 1)
        {
            normalEnding.sitLivingRoom();
        }
        else if (choice == 2)
        {
            //Follow her into the kitchen and offer some help.
        }
        else if (choice == 3)
        {
            Ending2.kateRoom();
        }
        else
        {
            //Go to [Tenant 2]’s room, his weird tendencies may help reveal some things.
        }
    }
    public static void choiceSomethingHollow()
    {
        Console.WriteLine("A. **There must be a reason why there’s some hollow spots in this sofa. I need to look into this more.**\r\n" +
            "B. This is a very old sofa after all, I just take a look and if there’s nothing suspicious, then it’s just me being paranoid.\r\n" +
            "C. It’s nothing, if there’s anything suspicious, it has to be in my grandfather’s room, not in some place like the living room sofa.\r\n");

        int choice = normalEnding.GetChoice(3);

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
        Console.WriteLine("A. Act composed, this basically confirms that something dark is happening here. But this isn’t my grandfather’s fingernail at all!\r\n" +
            "B. **I need to confront the old lady, I’m sure she doesn’t have much strength, I can take her down.**\r\n" +
            "C. This might be from [Tenant 2], I heard he does bizarre disgusting things all the time. I’ll inform the landlady just in case.\r\n");

        int choice = normalEnding.GetChoice(3);

        if (choice == 2)
        {
            normalEnding.confrontOldLady();
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
    public static void choiceConfrontLady()
    {
        Console.WriteLine("A. **Let’s see who can pull out a knife first. She’s senile, being a psychopath won’t help her.**\r\n" +
            "B. This… I need more time to prepare.\r\n");

        int choice = normalEnding.GetChoice(2);

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
        Console.WriteLine("A. **Answer ambiguously, suggest something that can make her show her true colors. I need to hear her side first.**\r\n" +
            "B. I don’t need to walk around the bush, she’s definitely some type of crazy.\r\n");

        int choice = normalEnding.GetChoice(2);

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
        Console.WriteLine("A. **I need to continue talking to her, I need more answers before I end her myself!**\r\n" +
            "B. One stab, and we’re done with this nightmare!\r\n");

        int choice = normalEnding.GetChoice(2);

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
        Console.WriteLine("A. **I’ll just ask her when she’s half dead, I got to get rid of this woman!**\r\n" +
            "B. I need her to experience what she did to her victims.\r\n");

        int choice = normalEnding.GetChoice(2);

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
        Console.WriteLine("A. **Try to reach the knife near the kitchen entrance to stab the landlady. You might be able to inflict a serious injury, but your back will be open.**\r\n" +
            "B. Take advantage of the time and smash her head yourself, regardless of her disgusting pain tolerance, she will be dizzy.\r\n");
        int choice = normalEnding.GetChoice(2);

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
        Console.WriteLine("Bonus for finishing the game perfectly. How do you want this confrontation to end?\n\n" +
            "A. **Tie the landlady up, and ask her where your grandfather’s remains are as well as your doubts.**\r\n" +
            "B. Just kill her! I want to end this nightmare!\r\n");
        int choice = normalEnding.GetChoice(2);

        if (choice == 1)
        {
            normalEnding.perfectrunEnding();
        }
        else
        {
            //Just kill her! I want to end this nightmare!
        }
    }

    // ENDING 2 BRANCHES
    public static void choiceKateRoom()
    {
        int choice = choiceTemplate(2, 1, new string[]
        {
            "A. Feeling like you did something wrong, you close the door and act like nothing happened.",
            "B. Enter the room carefully and inspect the letters."
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
        int choice = choiceTemplate(2, 2, new string[]
        {
            "A. Continue listening to the landlady.",
            "B. Filled with rage, you lunge and tackle the landlady."
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
        int choice = choiceTemplate(2, 2, new string[]
        {
            "A. Wrestle with the landlady.",
            "B. Try to escape from the landlady"
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
        int choice = choiceTemplate(2, 1, new string[]
        {
            "A. Run towards the exit and escape the boarding house.",
            "B. Mock the landlady and piss her off, there's no way an old lady can catch up to you anyways."
        });

        if (choice == 1)
        {
            Ending2.Finale();
        }
        else
        {
            //Mock the landlady and piss her off, there's no way an old lady can catch up to you anyways.
        }
    }

    static int choiceTemplate(int maxChoice, int correctAnswer, string[] choices)
    {
        Console.WriteLine($"{choices[0]},\n" +
            $"{choices[1]}\n");

        return normalEnding.GetChoice(maxChoice);
    }
}
