using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicPlayer.Models;
using MusicPlayer.Models.Data;
using MusicPlayer.Models.Interfaces;
using MusicPlayer.Models.ViewModels;

namespace MusicPlayer.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthorizationController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

         [HttpPost]
         public IActionResult Index(UserViewModel userData)
        {
           
            User user = _context.Users.FirstOrDefault(x => x.Login == userData.Login);
           
            if (user != null&& user.Password == userData.Password)
            {
                return RedirectToAction("Index","ProfilePage", new ProfileViewModel{  userInSystemId = user.UserID,  Login = user.Login, FavouriteSongs=null});
            }
            return RedirectToAction("PasswordOrLoginIsIncorrect");
                
            }
        [HttpGet]
        public IActionResult PasswordOrLoginIsIncorrect()
        {
            return View();
        }
       

        }
    }



