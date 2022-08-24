namespace Game_Repository;

public class Game 
{
    public Game() {}

    public Game(int gameID, string text1, string text2, int number) {
        GameID = gameID
        Text1 = text1;
        Text2 = text2;
        Number = number;
    }
    public int GameID { get; set; }
    public string Text1 { get; set; }
    public string Text2 { get; set; }
    public int Number { get; set; }
}
public class MadLibs
{
    public MadLibs() {}

    public MadLibs(int madLibID, string sentence1, string sentence2, string sentence3, WordType wordType) {
        MadLibID = madLibID;
        Sentence1 = sentence1;
        Sentence2 = sentence2;
        Sentence3 = sentence3;
        WordType = wordType;
    }
public int MadLibID { get; set; }
public string Sentence1 { get; set; }
public string Sentence2 { get; set; }
public string Sentence3 { get; set; }
public WordType WordType { get; set; }
}

public enum WordType { Verb, Adjective, Adverb, Noun }