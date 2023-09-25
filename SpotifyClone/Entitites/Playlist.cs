using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entitites
{
    public class Playlist
    {

        public Guid Id { get; set;} = Guid.NewGuid();

        private List<Song> SongList { get; set; } = new List<Song>();

        public Random random = new Random();

        public Playlist(Song song) 
        {
            AddSong(song);
        } 


        public void AddSong(Song song) 
        {
            if (song != null && SongList.Contains(song) == false)
            {
                SongList.Add(song);
            }
        }

        public string GetSongs()
        {
            return string.Join("\n", SongList.Select(x=> $"{x.Title} - {x.Composer}"));
        }

        public void ShuffleSongs()
        {
            int count = SongList.Count;

            while (count > 0)
            {
                count--;

                int randomIndex = random.Next(0, count);

                Song song = SongList[count];

                SongList[count] = SongList[randomIndex];

                SongList[randomIndex] = song;

            }
        }
    }
}
