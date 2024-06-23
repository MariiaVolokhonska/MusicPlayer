using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Models.ViewModels
{
    public class SongsUserViewModel
    {
        public ProfileViewModel User { get; set; }
        public List<SongViewModel> Songs { get; set; }
    }
}
