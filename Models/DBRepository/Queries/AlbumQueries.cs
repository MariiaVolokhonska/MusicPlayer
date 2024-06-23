using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicPlayer.Models.Data;
using MusicPlayer.Models.DBRepository.Interfaces;

namespace MusicPlayer.Models.DBRepository.Queries
{
    public class AlbumQueries : IAlbumQueries
    {
        private readonly ApplicationDbContext _context;

        public AlbumQueries(ApplicationDbContext context)
        {
            _context = context;
        }

        public Album GetAlbumById(int id) => _context.Albums.FirstOrDefault(x => x.AlbumID == id);
    }
}

