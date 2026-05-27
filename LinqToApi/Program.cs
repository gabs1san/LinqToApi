using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(response);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}"); Console.WriteLine(ex.ToString());
    }
}

namespace LinqToApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
 