using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicPlayer.Models
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [ForeignKey("Artist")]
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
        [Required]
        public Genre Genre{ get; set; }
        [Required]
        [ForeignKey("Album")]
        public int AlbumID { get; set; }
        public Album Album { get; set; }
        [Required]
        public float Duration { get; set; }
        [Required]
        public string Location { get; set; }

    }

    }

