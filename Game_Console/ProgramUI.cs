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
            + "1. Start a new game!\n"
            + "2. List all games!\n"
            + "3. Update a game!\n"
            + "4. Delete a game!\n"
            + "5. Exit");
            string? userResponse = Console.ReadLine();
            switch(userResponse) {
                case "1":
                AddNewGame();
                break;
                case "2":
                ShowAllGames();
                break;
                case "3":
                UpdateGame();
                break;
                case "4": 
                RemoveGame();
                case "5":
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

    private void ShowAllGames() {

    }

    private void UpdateGame() {

    }

    private void RemoveGame() {

    }
}