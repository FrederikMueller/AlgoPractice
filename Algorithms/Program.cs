using Algorithms.Easy;
using Algorithms.Medium;

internal class Program
{
    private static void Main(string[] args)
    {
        var tw = new TournamentWinner();

        List<List<string>> competitions = new List<List<string>>();
        List<string> competition1 = new List<string> {
            "HTML", "C#"
        };
        List<string> competition2 = new List<string> {
            "C#", "Python"
        };
        List<string> competition3 = new List<string> {
            "Python", "HTML"
        };
        competitions.Add(competition1);
        competitions.Add(competition2);
        competitions.Add(competition3);
        List<int> results = new List<int> {
            0, 0, 1
        };
        string expected = "Python";

        tw.GetTournamentWinner(competitions, results);

        Console.ReadLine();
    }
}