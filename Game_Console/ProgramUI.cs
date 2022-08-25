using System;
using System.Net.NetworkInformation;
namespace Game_Repository;

class ProgramUI {
    MadLibsGame _repo = new MadLibsGame();
    public void Run()
    {
        Seed();
        Menu();
    }

    private void Menu()
    {
        System.Console.WriteLine("Please enter a username before we begin!");
        string username = Console.ReadLine();

        bool keepRunning = true;
        while(keepRunning) 
        {
            Console.Clear();
            System.Console.WriteLine($"Hello {username}! Welcome to Mad Libs! Please select from the following options!\n"
            + "1. Add a new game!\n"
            + "2. List all games!\n"
            + "3. Update a game!\n"
            + "4. Delete a game!\n"
            + "5. Start Round One!\n"
            + "6. Start Round Two!\n"
            + "7. Exit");
            string? userResponse = Console.ReadLine();
            switch(userResponse) {
                case "1":
                AddNewGame();
                break;
                case "2":
                GetAllGames();
                break;
                case "3":
                UpdateGame();
                break;
                case "4": 
                RemoveGame();
                break;
                case "5":
                PlayRound1();
                break;
                case "6":
                PlayRound2();
                break;
                case "7":
                System.Console.WriteLine("Bye Bye!");
                keepRunning = false;
                break;
                default: 
                System.Console.WriteLine("Please review your options and try again!");
                break;
            }
            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
    private void AddNewGame() {
        Console.Clear();

        Game newgame = new Game();

        System.Console.WriteLine("Please enter a new Game ID for your new game.");
        newgame.GameID = int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Please enter a new ");
    }

    private void GetAllGames() {
        Console.Clear();

        foreach (Game newgame in _repo.ShowAllGames())
        {
            DisplayItems(newgame);
        }
    }

    private void UpdateGame() {

    }

    private void RemoveGame() {
        Console.Clear();

        System.Console.WriteLine("Please enter the Game ID for the game you'd like to delete.");
        int gameID = int.Parse(Console.ReadLine());

        bool deleteSuccessful = _repo.RemoveGame(gameID);
        if(deleteSuccessful) 
        {
            Console.Clear();
            System.Console.WriteLine("Delete successful!");
        }
        else 
        {
            Console.Clear();
            System.Console.WriteLine("Delete unsuccessful please try again.");
        }
    }

    public void PlayRound1() {
        Console.Clear();

        Game newgame = new Game();

        System.Console.WriteLine("Please re-enter your username before we begin!");
        string username = Console.ReadLine();
        
        System.Console.WriteLine($"Hello {username} let's begin the game!\n"
        + "The ruleds are simple. Enter in the type of words as you're prompted and when you're finished enter them your completed Mad Lib will appear!\n");

        System.Console.WriteLine("Please enter a plural noun: ");

        string pluralNoun = Console.ReadLine();
        // int nounInt = int.Parse(pluralNoun);
        
        // newItem.Noun = (WordType)nounInt;

        System.Console.WriteLine("Please enter a verb: ");
        string verb = Console.ReadLine();
        // int verbInt = int.Parse(verb);
        // newItem.Verb = (WordType)verbInt;

        System.Console.WriteLine("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        

        string sentence1 = $"Oh you think your day has been tough? Today I found {pluralNoun} on my doorstep!";

        string sentence2 = $"Can you believe that? I immediately started {verb}!";

        string sentence3 = $"I mean there were {number} of them!! That's insanity!\n";

        System.Console.WriteLine(sentence1 + " " + sentence2 + " " + sentence3);
    }

    public void PlayRound2() {
        Console.Clear();

        System.Console.WriteLine("Hello are you ready for Round 2? Yes, no, or maybe?");

        string userResponse = Console.ReadLine();

if (userResponse == "yes")
{
    System.Console.WriteLine("Hell yeah let's do this!");
}
else if (userResponse == "maybe")
{
    System.Console.WriteLine("Ehhh let's play it'll be fun!");
}
else if (userResponse == "no")
{
    System.Console.WriteLine("Tough luck it's game time baby!");
}
else 
{
    System.Console.WriteLine("Sorry couldn't understand that response. Please enter yes, no, or maybe!\n");
}

Console.Write("Please enter an adjective: ");
string adjective = Console.ReadLine();

Console.Write("Please enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter a verb: \n");
string verb = Console.ReadLine();

string sentence1 = $"They say there are many {adjective} fish in the sea.";
string sentence2 = $"However, so far I've only found {number} fish in the proverbial sea.";
string sentence3 = $"It's enough to make a girl start {verb} around here! Maybe we ought to go fish in the pond!\n";

System.Console.WriteLine(sentence1 + " " + sentence2 + " " + sentence3); // prints madLib2 to console
    }

    private void DisplayItems() {
        
    }

    private void Seed() {
        // Game game1 = new Game(_repo.ShowAllGames().Count + 1, "");
    }
}