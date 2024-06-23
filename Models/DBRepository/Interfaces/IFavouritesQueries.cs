using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Models.DBRepository.Interfaces
{
   public  interface IFavouritesQueries
    {
        public void AddToFavourites(Favourite favourite);
        public void DeleteFromFavourites(Favourite favourite);
        public List<Favourite> GetFavouritesByUserId(int userId);
        public Favourite GetFavouriteSongBySongIdAndUserId(int songId, int userId);
    }
}
