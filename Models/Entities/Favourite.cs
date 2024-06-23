using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicPlayer.Models
{
    public class Favourite
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FavouriteSongID { get; set; }
        
        [Required]
        [ForeignKey("Song")]
        public int SongID { get; set; }
        public Song Song { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
