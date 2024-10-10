using HtmlAgilityPack;

namespace FantasyFootballSquadBot.Wrapping.Mackolik;

public class WebScrapper
{
    private readonly HttpClient _httpClient;

    public WebScrapper()
    {
        _httpClient = new HttpClient();
    }

    public async Task<string> ScrapeWebsite(string url)
    {
        var html = await _httpClient.GetStringAsync(url);

        HtmlDocument document = new HtmlDocument();
        document.LoadHtml(html);
        
        var titleNode = document.DocumentNode.SelectSingleNode("//title");
        return titleNode?.InnerText ?? "Başlık bulunamadı";
        
    }
}