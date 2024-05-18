using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Models.Interfaces
{
   public  interface IUserQueries
    {
        public void CreateUser(User user);
        public User GetUserById(int id);
        public void DeleteUser(int id);
        public  void UpdateUserInfo();

        public void CreatePlaylist(Playlist playlist);
        public void DeletePlaylist(int id);
        public Playlist GetPlaylistById(int playlistId);
        

        /*
        public Song GetSongWithIdOrName(int? id, string? name);
        public bool CreatePlaylist();
        public void DeletePlaylist();
        public bool AddSongToPlaylist(Song song);
        public bool DeleteSongFromPlaylistWithIdOrName(int? id, string? name);*/



    }
}
