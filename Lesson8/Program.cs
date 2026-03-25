using System.IO;
using System.Threading.Tasks;

public class ConfigLoader
{
    public class Program
    {
        public static async Task Main()
        {
            string path = "config.txt";
            await File.WriteAllTextAsync(path, "theme=dark");

            var loader = new ConfigLoader();
            string config = await loader.LoadConfigAsync(path);

            Console.WriteLine("Loaded config:");
            Console.WriteLine(config);
        }
    }

    // TODO:
    // 1) Rename this to LoadConfigAsync
    public class ConfigLoader
    {
        // 2) Change the return type to Task<string>
        // 3) Use File.ReadAllTextAsync(path)
        public async Task<string> LoadConfigAsync(string path)
        {
            return await File.ReadAllTextAsync(path);
        }
    }

}

