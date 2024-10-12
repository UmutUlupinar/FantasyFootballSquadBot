namespace FantasyFootballSquadBot.Wrapping.Mackolik;

public class ScrapperService
{
    private readonly WebScrapper _webScraper;

    public ScrapperService()
    {
        _webScraper = new WebScrapper();
    }
    
    public string GetTitle(string url) =>
        _webScraper.ScrapeWebsite(url).Result;
    
}