using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MusicPlayer.Models
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }
        public string Title { get; set; }
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
        public Genre Genre{ get; set; }
        public int AlbumID { get; set; }
        public Album Album { get; set; }
        public float Duration { get; set; }
        public string Location { get; set; }

    }

    }

