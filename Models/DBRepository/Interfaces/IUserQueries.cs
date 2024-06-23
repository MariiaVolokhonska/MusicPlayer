using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Models.Interfaces
{
   public  interface IUserQueries
    {
        public void CreateUser(User user);
        public User GetUserByLogin(string login);
        public User GetUserById(int id);
        public void DeleteUser(int id);
        

       
        

        /*
        public Song GetSongWithIdOrName(int? id, string? name);
        public bool CreatePlaylist();
        public void DeletePlaylist();
        public bool AddSongToPlaylist(Song song);
        public bool DeleteSongFromPlaylistWithIdOrName(int? id, string? name);*/



    }
}
