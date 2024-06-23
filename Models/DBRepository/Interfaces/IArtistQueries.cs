using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Models.DBRepository.Interfaces
{
   public interface IArtistQueries
    {
        public Artist GetArtistById(int id);
    }
}
