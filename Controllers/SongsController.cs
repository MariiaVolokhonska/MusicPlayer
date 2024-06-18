using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using MusicPlayer.Models.Data;
using MusicPlayer.Models.ViewModels;
using MusicPlayer.Models;
using Microsoft.Data.SqlClient;

namespace MusicPlayer.Controllers
{
    public class SongsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SongsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            var songs = _context.Songs.ToList();
            /*List<SongViewModel> list = new List<SongViewModel>;
            int id = 1;
            SqlDataReader reader = 
            foreach(SongViewModel model in list)
            {
                Song song = new Song();
                song = _context.Songs.FirstOrDefault(x => x.SongID == id);
                id++;
            }*/
            
            
            List<SongViewModel> s_vm = new List<SongViewModel>();
            if (songs != null)
            {

                foreach (Song song in songs)
                {
                    var artist = _context.Artists.FirstOrDefault(x => x.ArtistID == song.ArtistID);
                    var album = _context.Albums.FirstOrDefault(x => x.AlbumID == song.AlbumID);
                    var songViewModel = new SongViewModel()
                    {
                        SongID=song.SongID,
                        Title = song.Title,
                        Artist = artist.ArtistName,
                        Genre = song.Genre,
                        Album = album.AlbumName,
                        Duration = song.Duration,
                        Location = song.Location
                    };
                    s_vm.Add(songViewModel);
                }
                return View(s_vm);
            }
            return View();
            
        }
        [HttpGet]
        public IActionResult AddToFavourites(int songId)
        {
           
            var selectedSong = _context.Songs.FirstOrDefault(x => songId == x.SongID);
            var favouriteSong = new Favourite()
            {
                SongID = selectedSong.SongID,
                Song = selectedSong,
            };
            Console.WriteLine($" {favouriteSong.FavouriteSongID} {favouriteSong.SongID} {favouriteSong.Song}");
            var listOfFavourites = _context.Favourites.ToList<Favourite>();
            if (!listOfFavourites.Contains(favouriteSong))
            {
                _context.Favourites.Add(favouriteSong);
                _context.SaveChanges();
                return RedirectToAction("Index", "Favourits");
            }
            else
            {
                return RedirectToAction("Index", "Songs");
            }

            
            
        }
        
        
       
    }
}
