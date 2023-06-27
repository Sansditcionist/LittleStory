// Backstory to the user

Console.WriteLine("Welcome To Little Story.");
Console.WriteLine("It's 3:50am and you just arrived home from work.");
Console.WriteLine("You are about to enter your house but the door Is locked.");
Console.WriteLine("You forgot where your wife left the keys.");
Console.WriteLine("You start searching for the keys when you see a paper on the flowers.");
Console.WriteLine("There Is something written on it");
Console.WriteLine("Do you want to check the paper or continue to look for the keys? _[check or continue]_");

// Prompt the user for a choice
Console.Write("> ");
string optionChoice = Console.ReadLine();

// ask where the player wants to do

if(optionChoice == "check")
{
    Console.WriteLine("You check the paper");
    Console.WriteLine("On the paper it says: The keys to the house are In your coat pocket you dumb nerd");
    Console.WriteLine("You get the keys and go to your house.");
    Console.WriteLine("As you enter to the house, you hear a wierd noise coming from the basemnet.");
    Console.WriteLine("A few seconds later you hear the noise again.");
    Console.WriteLine("Do you want to check the noise or turn on the TV and fall asleep? _[check noise or turn on tv]_");

    Console.Write("> ");

    // Prompt the user for another choice
    string noiseChoice = Console.ReadLine();

    if(noiseChoice == "check noise")
    {
        Console.WriteLine("You go down stairs to investigate the noise");
        Console.WriteLine("You enter the basement and a panel with spikes falls on you and you die");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("YOU DIED!");
        Console.ResetColor();
    }
    else if(noiseChoice == "turn on tv")
    {
        Console.WriteLine("You go to the living room and turn on the TV");
        Console.WriteLine("a few hours later you fall asleep");
        Console.WriteLine("you wake up at 7:50am and your wife made breakfast");
        Console.WriteLine("You eat a grilled cheese sandwich and live a normal life");
        Console.WriteLine("Not too long...");
        Console.WriteLine("Your wife pulls a gun out of here pocket and gives you 2 options");
        Console.WriteLine("The sandwich you ate there was a poison sandwich.");
        Console.WriteLine("Your 1st option Is to give here $2,000,000 and she will cure you.");
        Console.WriteLine("Your 2nd option Is to pack your bags and get out of the house forever.");
        Console.WriteLine("What do you choose? _[1st or 2nd]_");

        Console.Write("> ");

        string wifeChoice = Console.ReadLine();

        if(wifeChoice == "1st")
        {
            Console.WriteLine("You chose the 1st option");
            Console.WriteLine("Sadly you don't have 2 million dollars");
            Console.WriteLine("Your wife then shoots you and throws you to the garden");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("YOU DIED!");
            Console.ResetColor();
        }
        else if(wifeChoice == "2nd")
        {
            Console.WriteLine("You chose the 2nd option");
            Console.WriteLine("You pack your bags and leave the house");
            Console.WriteLine("After you leave the house you go to the police and then they arrest her.");
            Console.WriteLine("5 Years later you fiund another girls and you live very happy.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("THE END!");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("You gave the wrong option so your wife shoots you and you die.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("YOU DIED!");
            Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Error: No option to that question detected.");
        Console.ResetColor();
    }
}
else if(optionChoice == "continue")
{
    Console.WriteLine("You continue looking for the keys.");
    Console.WriteLine("It's 4:22am and still can't find your keys");
    Console.WriteLine("It's 7:50am and your wife opens the door");
    Console.WriteLine("But it was too late.");
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine("YOU DIED!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Error: No option to that question detected.");
    Console.ResetColor();
}
