﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MusicPlayer.Controllers
{
    public class PlaylistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
