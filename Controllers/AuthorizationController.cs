using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicPlayer.Migrations;
using MusicPlayer.Models;

using MusicPlayer.Models.Data;
using MusicPlayer.Models.Interfaces;
using MusicPlayer.Models.ViewModels;
using MusicPlayer.Models.DBRepository.Queries;

namespace MusicPlayer.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly ApplicationDbContext _context;
        private UserQueries queries;

        public AuthorizationController(ApplicationDbContext context)
        {
            _context = context;
            queries = new UserQueries(_context);
        }
        [HttpGet]
        public IActionResult Index()
        {
            Globals.USER_ID = -1;
            return View();
        }

         [HttpPost]
         public IActionResult Index(UserViewModel userData)
        {

            User user = queries.GetUserByLogin(userData.Login);
               
           
            if (user != null&& user.Password == userData.Password)
            {
                Globals.USER_ID = user.UserID;
                return RedirectToAction("Index","Favourits", new ProfileViewModel{  userInSystemId = user.UserID,  Login = user.Login, FavouriteSongs=null});
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



