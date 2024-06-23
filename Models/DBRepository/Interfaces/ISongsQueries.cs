using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Models.DBRepository.Interfaces
{
   public interface ISongsQueries
    {
        public Song GetSongById(int id);
        public List<Song> GetAllSongs();
    }
}
