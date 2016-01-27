using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harj2
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD();
            cd.Artist = "Jalmari Kasapaskaa";
            cd.Album = "Kasa paskaa";



            Song song = new Song();
            Song song1 = new Song { Name = "- PLOP", Time = " 4.25" };
            Song song2 = new Song { Name = "- PLUP", Time = " 3.15" };
            Song song3 = new Song { Name = "- PLAP", Time = " 5.42" };
            Song song4 = new Song { Name = "- PLEP", Time = " 2.12" };
            Song song5 = new Song { Name = "- PLIP", Time = " 1.59" };
            Song song6 = new Song { Name = "- PLÄP", Time = " 4.34" };

            song.AddSong(song1);
            song.AddSong(song2);
            song.AddSong(song3);
            song.AddSong(song4);
            song.AddSong(song5);
            song.AddSong(song6);

            song.PrintCollection();


        }
    }
}
