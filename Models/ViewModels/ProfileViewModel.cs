using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Models.ViewModels
{
    public class ProfileViewModel
    {
        public int userInSystemId { get; set; }
        public string Login { get; set; }
        public List<FavouritesViewModel> FavouriteSongs { get; set;}
    }
}
