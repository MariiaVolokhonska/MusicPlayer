using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicPlayer.Models.Interfaces;
using MusicPlayer.Models.Data;
using MusicPlayer.Models.DBRepository.Interfaces;

namespace MusicPlayer.Models.DBRepository.Queries
{
    public class FavouritesQueiries :IFavouritesQueries
    {
        private readonly ApplicationDbContext _context;

        public FavouritesQueiries(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddToFavourites(Favourite favourite)
        {
            _context.Favourites.Add(favourite);
            _context.SaveChanges();
        }
        public void DeleteFromFavourites(Favourite favourite)
        {
            _context.Favourites.Remove(favourite);
            _context.SaveChanges();
        }
        public Favourite GetFavouriteSongBySongIdAndUserId(int songId, int userId) => _context.Favourites.FirstOrDefault(x => songId == x.SongID && x.UserID == userId);
        public List<Favourite> GetFavouritesByUserId(int userId)=> _context.Favourites.Where(x => x.UserID == userId).ToList<Favourite>();
    }
}
