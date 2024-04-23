using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MusicPlayer.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Login{ get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public ICollection <Playlist> Playlists { get; set; }


    }
}
