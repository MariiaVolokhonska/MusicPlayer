using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicPlayer.Models.Data;
using MusicPlayer.Models.DBRepository.Interfaces;

namespace MusicPlayer.Models.DBRepository.Queries
{
    public class ArtistQueries :IArtistQueries
    {
        private readonly ApplicationDbContext _context;

        public ArtistQueries(ApplicationDbContext context)
        {
            _context = context;
        }
        public Artist GetArtistById(int id)=> _context.Artists.FirstOrDefault(x => x.ArtistID == id);
    }
}
