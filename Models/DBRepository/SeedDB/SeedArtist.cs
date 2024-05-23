using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicPlayer.Models.Data;

namespace MusicPlayer.Models.DBRepository.SeedDB
{
    
    public class SeedArtist
    {
        public static void SeedListOfSongs(ApplicationDbContext context)
        {
            List<Album> albumList1 = new List<Album>();
            List<Album> albumList2 = new List<Album>();
            List<Album> albumList3 = new List<Album>();
            context.Artists.AddRange(
                new Artist { ArtistName = "marmixer", Information = "Very nice artist", Albums = albumList1 },
                new Artist { ArtistName = "BassBassic", Information = "Cool artist", Albums = albumList2 },
                new Artist { ArtistName = "einnt", Information = "Super artist", Albums = albumList3 }
                );
        }
    }
}
