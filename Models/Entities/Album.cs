using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicPlayer.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }
        [Required]
        public string AlbumName { get; set; }
        [Required]
        [ForeignKey("Artist")]
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
        [Required]
        public int Year { get; set; }
        public List<Song> Songs { get; set; }
    }
}
