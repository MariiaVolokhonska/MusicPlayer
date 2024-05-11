using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicPlayer.Models
{
    public class Playlist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlaylistID { get; set; }
        [Required]
        public string PlaylistName { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserID { get; set; }
        public int SongID { get; set; }
        public Song Song { get; set; }
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
    }
}
