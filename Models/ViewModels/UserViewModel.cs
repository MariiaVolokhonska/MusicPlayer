using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Models.ViewModels
{
    public class UserViewModel
    {

        public int UserID { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }


        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public List<Playlist> Playlists { get; set; }
    }
}

