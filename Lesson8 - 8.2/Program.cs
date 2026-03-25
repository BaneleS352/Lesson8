using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        var contentService = new ContentService();


        // TODO:
        // 1) Wrap the awaited call in try/catch
        // 2) Print html.Length on success
        // 3) Print a friendly message and ex.Message on failure

        try
        {
            string html = await contentService.GetWebsiteContentAsync("https://example.com");
            Console.WriteLine($"Downloaded length: {html.Length}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to fetch website content.");
            Console.WriteLine(ex.Message);
        }
    }

    public class ContentService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<string> GetWebsiteContentAsync(string url)
        {
            return await _httpClient.GetStringAsync(url);
        }
    }
}