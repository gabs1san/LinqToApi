using System.Text.Json.Serialization;

namespace LinqToApi.Models
{
    internal class Music
    {
        [JsonPropertyName("Song")]
        public string Nome { get; set; }

        [JsonPropertyName("artist")]
        public string Artist { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duration { get; set; }

        [JsonPropertyName("gendre")]
        public string Gender { get; set; }
    

    public void PrintMusicInfo(Music music)
        {
            Console.WriteLine($"Nome: {music.Nome}");
            Console.WriteLine($"Artist: {music.Artist}");
            Console.WriteLine($"Duration: {music.Duration} ms");
            Console.Write(music.Nome);
        }
    }
}
