using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Models.ViewModels
{
    public class UserAccountViewModel
    {
        public ProfileViewModel Profile{ get; set; }
        public List<FavouritesViewModel> FavouriteSongs { get; set; }
    }
}
