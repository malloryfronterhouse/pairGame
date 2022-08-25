namespace Game_Repository;
public class MadLibsGame {
    protected readonly List<Game> _game = new List<Game>();

    //create
    public bool AddNewGame(Game game) {
        int prevCount = _game.Count;

        _game.Add(game);

        return prevCount < _game.Count ? true : false;
    }

    //read 
    public List<Game> ShowAllGames() {
        return _game;
    }

    update 
    public bool UpdateGame(int gameID, Game newgame) {
        Game? oldGame = _game.Find(game => game.GameID == gameID);

        if(oldGame != null) {
            oldGame.Number = newgame.Number != 0 ? newgame.Number : oldGame.Number;
            oldGame.Text1 = newgame.Text1 != "" ? newgame.Text1 : oldGame.Text1;
            oldGame.Text2 = newgame.Text2 != "" ? newgame.Text2 : oldGame.Text2;
        }
        //delete
    public bool RemoveGame(int gameID) {
            Game itemToDelete = _game.Find(game => game.GameID == gameID);

            bool deleteGame = _game.Remove(itemToDelete);

            return deleteGame;
        }
    }
}

// public class GameOutput {
//     protected readonly List<MadLibs> _madlib = new List<MadLibs>();
//     //create
//     public bool AddMadLib(MadLibs item) {
//         int prevCount = _madlib.Count;

//         _madlib.Add(item);

//         return prevCount < _madlib.Count ? true : false;
//     }
//     //read 
//     public List<MadLibs> GetAllTemplates() {
//         return _madlib;
//     }
// }

    //update
//     public bool UpdateMadLib(int madLibID, MadLibs newItem) {
//         MadLibs? oldItem = _madlib.Find(item => item.MadLibID == madLibID);

//         if(oldItem != null) {
//             oldItem.Sentence1 = newItem.Sentence1 != "" ? newItem.Sentence1 : oldItem.Sentence1;
//             oldItem.Sentence2 = newItem.Sentence2 != "" ? newItem.Sentence2 : oldItem.Sentence2;
//             oldItem.Sentence3 = newItem.Sentence3 != "" ? newItem.Sentence3 : oldItem.Sentence3;
//         }
//     }
// }

    //     public bool RemoveMadLib(int madLibID) {
    //         MadLibs? itemToDelete = _madlib.Find(item => item.MadLibID == madLibID);

    //         bool deleteMadLib = _madlib.Remove(itemToDelete);

    //         return deleteMadLib;
    //     }
    // }
    