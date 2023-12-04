using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
public static class Ending2
{
	public static void kateRoom()
	{
        Clear();
        say($"You decided to go into Kate's room. As you open the door, piles of letters come falling down from the shelves. A messy room, it even looks like no one has lived there for a long time.");
        ChoiceSelector.choiceKateRoom();
	}

    public static void kateRoomCaught()
    {
        Clear();
        say($"(You hear the landlady’s footsteps coming towards you, as if she was trying to catch a thief.)");
        say($"Landlady: {normalEnding.player}, what are you up to?");
        say($"{normalEnding.player}: Nothing, I just saw Kate’s room filled with letters. Does she ever open them? It’s gonna take her a while to finish them all!");
        say($"Landlady: And why? That’s none of your business! Don’t mess with stuff you don’t own. Clean this place up!");
        say($"{normalEnding.player}: Well, I just wanted to ask her about some things about this place.\n");
        say($"(The landlady gets angry, you probably shouldn’t have messed with her stuff. Being nervous, you leave some letters at the door. She tells you to go back to the sofa and wait. As you sat, you felt something hollow.)\n");
        ChoiceSelector.choiceSomethingHollow();
    }
    public static void investigateSofa()
    {
        Clear();
        say($"You did actually manage to find something suspicious in those hollow spots. There, you found something that looks like scratches from a person getting dragged! \n" +
            $"There were also bloodstains and even a whole fingernail under the sofa! You get shocked, traumatized even! While looking into the sofa, you hear the landlady sprinting towards you.");
        say($"Landlady: You are really getting on my nerves. What the hell are you doing now {normalEnding.player}?!");
        say($"{normalEnding.player}: Is this a body? What the hell happens in this place??!! What did you do to my grandfather?");
        say($"Landlady: Oh that old bag? I don’t know. Did you check who was in the sofa?");
        say($"{normalEnding.player}: Oh my god! What did you do to him? You’re so sick! So sick!");
        say($"Landlady: Don’t cry {normalEnding.player}, he’s in a better place now.");
        say($"{normalEnding.player}: Better place? Are you out of your goddamn mind?! You killed him! My poor grandfather. You’re gonna pay for this.");
        say($"Landlady: Pay for what? You’re both-");
        ChoiceSelector.choiceRagedUser();
    }
    public static void tackleLandlady()
    {
        Clear();
        say($"(As {normalEnding.player} tackled the landlady, {normalEnding.player} didn’t expect the strength from a woman in their sixties. She’s insanely strong!)");
        say($"Landlady: (heavy breathing) Did you think I’m weak? How do you think they died then?");
        say($"{normalEnding.player}: You! Just! Won’t! Shut! Up!");
        say($"Landlady: You’re gonna end up like the rest of them. Better get ready for this!");
        ChoiceSelector.choiceEscape();
    }
    public static void escapeLandlady()
    {
        Clear();
        say($"You managed to get out from the grips of the landlady. Thinking that you are safe from her, the landlady lunges at you once again!");
        say($"Landlady: (smiling menacingly) I’m gonna dice you up and cut you up like the rest of them!");
        say($"{normalEnding.player}: Psychopath! You’re gonna pay for this you old hag!");
        say($"(The landlady manages to cut you once. You scream in pain but you still manage to get away from her for the meantime.)");
        ChoiceSelector.choiceRunOrMock();
    }
    public static void Finale()
    {
        Clear();
        say($"(You managed to escape. The landlady might have been surprisingly strong but she still has her old woman speed. She screams your name in pain, revealing that she also got cut with the knife.)\n");
        say($"Landlady: {normalEnding.player}! You’re gonna pay for this!");
        say($"{normalEnding.player}: To hell with you! I’m gonna call the authorities you old hag.\n");
        say($"You get a phone and start calling the authorities. As you call on the phone, you rest near the front of the boarding house still hurt from the injuries. \n" +
            $"Both the you and the landlady slowly lose consciousness until sirens and flashing lights arrive at the scene.)");
    }
    static void say(string message)
    {
        WriteLine($"{message}\n");
        ReadKey();
    }
}
