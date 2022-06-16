namespace Algorithms.Easy;
public class TournamentWinner
{
    /*
    Fully understand the problem
        Inputs: Competitions array (Home,away), results array (1=home team won, 0=away team won)
        Guaranteed that one team wins the tournament, one round robin, at least 2 teams.
    Look for potential simplifications of the problem
        Since no draws are possible and there is always a winner, we can focus on just counting wins. So we just keep track of total wins for each team and then simply return the name of the team with the most wins.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Iterate through both arrays simultaneously and store the result in a dictionary. Increase the int by one for the winning team.
        Only need to store winning team, no op for losing team. At the end check each entry in the dict to find the team with the most wins OR do this when you store a win.
    Then implement the simplified conceptual solution step by step
        Forgot to set mostWins and didn’t see it for ages. Make sure you don’t implement any step to quickly.
    Optimization. Big O analysis. Amortization?
        Time = n
        Space = k aka winning teams
    */
    // Insta checking leader each time instead of afterwards.
    Dictionary<string, int> winCounts = new Dictionary<string, int>();
    string currentLeader = "";
    int mostWins = 0;
    public string GetTournamentWinner(List<List<string>> competitions, List<int> results)
    {
        for (int i = 0; i < results.Count; i++)
        {
            var comp = competitions[i];
            var homeTeam = comp[0];
            var awayTeam = comp[1];

            if (results[i] == 1)
            {
                winCounts[homeTeam] = winCounts.GetValueOrDefault(homeTeam) + 1;
                CompareToLeader(homeTeam);
            }
            else
            {
                winCounts[awayTeam] = winCounts.GetValueOrDefault(awayTeam) + 1;
                CompareToLeader(awayTeam);
            }
        }
        return currentLeader;
    }
    private void CompareToLeader(string team)
    {
        if (winCounts[team] > mostWins)
        {
            mostWins = winCounts[team];
            currentLeader = team;
        }
    }
}