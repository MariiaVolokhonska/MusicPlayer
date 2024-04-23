using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MusicPlayer.Models
{
    public class Playlist
    {
        [Key]
        public int PlaylistID { get; set; }
        public string PlaylistName { get; set; }
        public int SongID { get; set; }
        public Song Song { get; set; }
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
    }
}
