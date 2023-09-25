using SpotifyClone.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Servies
{
    internal class NotepadService
    {

        public void PlaylistToNotepad(Playlist playlist) 
        { 
            string directory = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\\Playlists";
            

            if (!File.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string saveFile = Path.Combine(directory, $"{playlist.Id}.txt");

            File.WriteAllText(saveFile,playlist.GetSongs());

        }
    }
}
