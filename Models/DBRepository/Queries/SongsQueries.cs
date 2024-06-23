using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicPlayer.Models.Interfaces;
using MusicPlayer.Models.Data;
using MusicPlayer.Models.DBRepository.Interfaces;

namespace MusicPlayer.Models.DBRepository.Queries
{
    public class SongsQueries : ISongsQueries { 
    private readonly ApplicationDbContext _context;

        public SongsQueries(ApplicationDbContext context)
        {
            _context = context;
        }

        public Song GetSongById(int id) => _context.Songs.FirstOrDefault(x => id == x.SongID);
        public List<Song> GetAllSongs() => _context.Songs.ToList();
        
    }
}
