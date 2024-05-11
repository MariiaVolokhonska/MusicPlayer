using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Models.Interfaces
{
    interface Queries
    {
        public Song GetSongWithIdOrName(int? id, string? name);
        public bool CreatePlaylist();
        public void DeletePlaylist();
        public bool AddSongToPlaylist(Song song);
        public bool DeleteSongFromPlaylistWithIdOrName(int? id, string? name);



    }
}
