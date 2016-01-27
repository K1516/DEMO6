using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj2
{
    class Song : CD
    {


        public string Name { get; set; }
        public string Time { get; set; }
        private List<Song> songs;
        public Song()
        {
            songs = new List<Song>();
        }
        public void AddSong(Song song)
        {
            songs.Add(song);
        }

    
        public void PrintCollection()
        {
        Console.WriteLine("CD data: ");
            Console.WriteLine("Artist: " + Artist);
            Console.WriteLine("Album: " + Album);


            Console.WriteLine("Songs in a CD:");
            foreach (Song song in songs)
            {
                Console.WriteLine(song.ToString());
            }
        }
    }
}
