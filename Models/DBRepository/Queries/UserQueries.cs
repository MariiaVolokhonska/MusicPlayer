using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicPlayer.Models.Interfaces;
using MusicPlayer.Models.Data;

namespace MusicPlayer.Models.DBRepository.Queries
{
    public class UserQueries : IUserQueries
    {
        private readonly ApplicationDbContext _context;
        public UserQueries(ApplicationDbContext context)
        {
            _context = context;
        }
        public void CreatePlaylist(Playlist playlist)
        {
            _context.Playlists.Add(playlist);
            _context.SaveChanges();
        }
        public void UpdatePlaylist()
        {

        }
        public Playlist GetPlaylistById(int playlistId)
        {
            return _context.Playlists.FirstOrDefault(x=> x.PlaylistID==playlistId);
        }
        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeletePlaylist(int id)
        {
            var playlist = _context.Playlists.FirstOrDefault(x => x.PlaylistID == id);
            _context.Remove(playlist);
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.UserID == id);
            _context.Remove(user);
            _context.SaveChanges();
        }
        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(x=>x.UserID==id);
        }

        public void UpdateUserInfo()
        {
            throw new NotImplementedException();
        }
    }
}
