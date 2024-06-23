using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Models.ViewModels
{
    public class FavouritesViewModel
    {
        public int SongID { get; set; }
        public string Title { get; set; }
        public String Artist { get; set; }
        public Genre Genre { get; set; }
        public String Album { get; set; }
        public float Duration { get; set; }
        public string Location { get; set; }
        public int userId { get; set; }
        public User User { get; set; }
        public int favouriteSongId { get; set; }
    }
}
