
using SpotifyClone.Entitites;
using SpotifyClone.Servies;

Song song1 = new Song("1","2","3","4");
Song song2 = new Song("5","6","7","8");
Song song3 = new Song("9","10","11","12");

Playlist playlist = new Playlist(song1);
playlist.AddSong(song2);
playlist.AddSong(song3);

playlist.ShuffleSongs();

NotepadService service= new NotepadService();

service.PlaylistToNotepad(playlist);




