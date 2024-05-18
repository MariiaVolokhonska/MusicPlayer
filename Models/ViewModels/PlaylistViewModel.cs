using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Models.ViewModels
{
    public class PlaylistViewModel
    {
        
        public int PlaylistID { get; set; }
       
        public string PlaylistName { get; set; }
        
        public int UserID { get; set; }
        public int SongID { get; set; }
        public Song Song { get; set; }
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
    }
}
