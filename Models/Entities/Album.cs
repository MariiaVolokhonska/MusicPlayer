using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MusicPlayer.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }
        
        public int ArtistID { get; set; }
        public int Year { get; set; }
    }
}
