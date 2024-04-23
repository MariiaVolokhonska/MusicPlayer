using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MusicPlayer.Models
{
    public class Artist
    {
        [Key]
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public string Information { get; set; }
    }
}
