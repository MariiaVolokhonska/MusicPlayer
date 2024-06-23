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
using MusicPlayer.Migrations;
using MusicPlayer.Models.DBRepository.Queries;
using MusicPlayer.Models.DBRepository.Interfaces;

namespace MusicPlayer.Controllers
{
    public class SongsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private SongsQueries s_queries;
        private UserQueries u_queries;
        private FavouritesQueiries f_queries;
        private ArtistQueries a_queries;
        private AlbumQueries alb_queries;
        public SongsController(ApplicationDbContext context)
        {
            _context = context;
            s_queries = new SongsQueries(_context);
            u_queries = new UserQueries(_context);
            f_queries = new FavouritesQueiries(_context);
            a_queries = new ArtistQueries(_context);
            alb_queries = new AlbumQueries(_context);
        }
        [HttpGet]
        public IActionResult Index(ProfileViewModel profile)
        {

            var songs = s_queries.GetAllSongs();
               // _context.Songs.ToList();
            
            
            List<SongViewModel> s_vm = new List<SongViewModel>();
            if (songs != null)
            {

                foreach (Song song in songs)
                {
                    var artist = a_queries.GetArtistById(song.ArtistID);
                    
                    var album = alb_queries.GetAlbumById(song.AlbumID);
                    
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
                SongsUserViewModel model = new SongsUserViewModel() {Songs=s_vm, User = profile };
                return View(model);
            }
            return View();
            
        }
        [HttpGet]
        public IActionResult AddToFavourites(int songId)
        {

            var selectedSong = s_queries.GetSongById(songId);
                
            
            var selectedUser = u_queries.GetUserById(Globals.USER_ID);
             
            
            var favouriteSong = new Favourite()
            {
                SongID = selectedSong.SongID,
                Song = selectedSong,
                UserID = selectedUser.UserID,
                
            };

            var listOfFavourites = f_queries.GetFavouritesByUserId(Globals.USER_ID);
               
            var songInList = listOfFavourites.FirstOrDefault(x => x.SongID == favouriteSong.SongID);
            if (songInList is null)
            {
                f_queries.AddToFavourites(favouriteSong);
               
                return RedirectToAction("Index", "Favourits");
            }
            else
            {
                return RedirectToAction("Index", "Songs");
            }

            
            
        }
        
        
       
    }
}
