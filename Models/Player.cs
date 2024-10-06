using System.Drawing;

namespace FantasyFootballSquadBot.Models;

public class Player
{
    /// <summary>
    /// Base player informations
    /// </summary>
    public string Name { get; set; }
    public Team Team { get; set; }
    public Position Position { get; set; }

    /// <summary>
    /// Player potential points information
    /// </summary>
    public Point PlayerBasePoint { get; set; }
    public Point PlayerWeeklyPoint { get; set; }
    public Point PlayerTeamPoint { get; set; }
    public Point PlayerPotentialActsPoint { get; set; }

    /// <summary>
    /// Player informations that are focus on week match
    /// </summary>
    public Point PlayerResultPoint { get; set; }
    public bool IsCaptain { get; set; }
    public bool IsSubtition { get; set; }
    
}