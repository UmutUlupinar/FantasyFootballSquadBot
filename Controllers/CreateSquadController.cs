using Microsoft.AspNetCore.Mvc;

namespace FantasyFootballSquadBot.Controllers;

public class CreateSquadController : Controller
{
    /// <summary>
    /// This method returns squad for active week
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ContentResult SquadView()
    {
        string htmlContent = "İşte bu haftanın ideal kadrosu;";
        return new ContentResult()
        {
            Content = htmlContent,
            ContentType = "text/html",
            StatusCode = 200
        };
    }
}