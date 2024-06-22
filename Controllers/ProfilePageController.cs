using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicPlayer.Models.ViewModels;

namespace MusicPlayer.Controllers
{
    public class ProfilePageController : Controller
    {
        public IActionResult Index(int userInSystemId ,string Login, List<FavouritesViewModel> FavouriteSongs)
        {
            ProfileViewModel profile = new ProfileViewModel() {userInSystemId=userInSystemId, Login=Login, FavouriteSongs=FavouriteSongs};

            return View(profile);
        }
    }
}
