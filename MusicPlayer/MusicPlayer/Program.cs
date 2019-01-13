using System;
using System.Collections.Generic;
using MusicPlayer.Extensions;
namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            //BL8-Player3/3.SongGenres
            var listSong = player.GetSongs();
            var song = player.CreateSongs();
            listSong.Add(song);
            TraceInfo(listSong);

            player.Shuffle();
            TraceInfo(listSong);
            player.Start(listSong);
            //listSong = player.SortByTitle(listSong);
            //var sortedSongs = player.SortByTitle(listSong);
            //TraceInfo(sortedSongs);

            //BL8-Player1/3.SongTuples
            Console.WriteLine("--------------------");
            player.ListSongs(listSong, listSong[0]);

            //BL8-P3/3.Anonymous
            Console.WriteLine("--------------------");
            player.GetSongData_2(song);
           
            //BL8-Player2/3.LikeDislike
            Console.WriteLine("--------------------");
            listSong[0].Dislike();
            listSong[1].Like();
            listSong[2].Dislike();
            listSong[4].Like();
            TraceInfo(listSong);

            //L9-HW-Player-2/3.
            Console.WriteLine("--------------------");
            var listNameSongs = new List<string>();
            for (int i = 0; i < listSong.Count; i++)
            {
                listNameSongs.Add(listSong[i].Name);              
            }
            for (int i = 0; i < listNameSongs.Count; i++)
            {
                listNameSongs[i]=listNameSongs[i].Substring_2();
                Console.WriteLine(listNameSongs[i]);
            }
            Console.ReadLine();
        }

        public static void TraceInfo(List<Song> Song)
        {
            foreach (var i in Song)
            {
                if (i._like == true)
                    Console.ForegroundColor = ConsoleColor.Green;
                if (i._like == false)
                    Console.ForegroundColor = ConsoleColor.Red;
                if (i._like == null)
                    Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine($"Name Artist: {i.Artist.Name}");
                Console.WriteLine($"Name song: {i.Name}");
                Console.WriteLine($"Genre: {i.Artist._Genre}");
                Console.WriteLine($"Album: {i.Album.Name}");
                Console.WriteLine($"Year of album release: {i.Album.Year}");
                Console.WriteLine($"Duration song: {i.Duration} second");
                Console.WriteLine($"Lyrics: {i.Lyrics}\n");
            }
        }
    }
}
