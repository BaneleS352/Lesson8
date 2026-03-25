using System;
using System.Net.Http;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        var http = new HttpClient();

        Console.WriteLine("A) Starting download...");

        // TODO: start GetStringAsync, store it in a Task<string> variable (do NOT await yet)
        Task<string> downloadTask = http.GetStringAsync("https://example.com");

        // TODO: print "B) Doing something else..."
        Console.WriteLine("B) Doing something else...");
        // TODO: await the task and print "C) Done!" + length

        string html = await downloadTask;

        Console.WriteLine("C) Done!");
        Console.WriteLine($"Length: {html.Length}");
    }
}