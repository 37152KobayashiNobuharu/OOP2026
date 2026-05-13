
using Microsoft.VisualBasic.FileIO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var songs = new List<Song>();
            while (true) {
                Console.WriteLine("*****曲の登録*****");
                Console.Write("曲名");
                string? title = Console.ReadLine();

                if (title == "end") {
                    break;
                }

                Console.Write("アーティスト名");
                string? artistName = Console.ReadLine();

                Console.Write("演奏時間(秒)");
                int length = int.Parse(Console.ReadLine());

                Song song = new Song(title, artistName, length);

                songs.Add(song);
            }
            PrintSongs(songs);
        }
        private static void PrintSongs(IEnumerable<Song> songs) {
            foreach (var Song in songs) {
                Console.WriteLine($" {Song.Title},{Song.ArtistName},{Song.Length / 60}:{Song.Length % 60:00}");
            }
        }
    }
}
