namespace FantasyFootballSquadBot.Models;

public class Match
{
    public string Week { get; set; }
    public Team AwayTeam { get; set; }
    public Team HomeTeam { get; set; }
    public bool IsDerby { get; set; }
}