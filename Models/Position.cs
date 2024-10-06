namespace FantasyFootballSquadBot.Models;

public class Position
{
    public PositionEnum Name { get; set; }
    public int PlayerCount { get; set; }
    public string WeekAdvantage { get; set; }
    public bool HaveCaptain { get; set; }
}

public enum PositionEnum
{
    GoalKeeper=0,
    Defence,
    Middlefielder,
    Attacker
    
}