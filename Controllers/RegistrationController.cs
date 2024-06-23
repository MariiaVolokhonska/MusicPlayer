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
using MusicPlayer.Models.DBRepository.Queries;

namespace MusicPlayer.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext _context;
        private UserQueries queries;

        public RegistrationController(ApplicationDbContext context)
        {
            _context = context;
            queries = new UserQueries(_context);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserViewModel userData)
        {
            User user = new User()
            {
                Login = userData.Login,
                Password = userData.Password,
                Email = userData.Email,
                PhoneNumber = userData.PhoneNumber,
                Playlists = new List<Playlist>(),
            };
            queries.CreateUser(user);
            // _context.Users.Add(user);
            // _context.SaveChanges();
            return RedirectToAction("Index", "Authorization");
        }
        /*

        [HttpPost]
        public IActionResult Create(UserViewModel userData)
        {
            User user = new User()
            {
                Login = userData.Login,
                Password = userData.Password,
                Email = userData.Email,
                PhoneNumber = userData.PhoneNumber,
                Playlists = new List<Playlist>(),
            };
            _queries.CreateUser(user);
            return RedirectToAction("Index");
        }*/

       
    }
}
