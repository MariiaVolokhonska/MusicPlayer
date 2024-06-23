using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicPlayer.Models.Data;
using MusicPlayer.Models.ViewModels;
using MusicPlayer.Models;
using MusicPlayer.Migrations;

using Microsoft.Data.SqlClient;

namespace MusicPlayer.Controllers
{
    public class FavouritsController : Controller

    {
        private readonly ApplicationDbContext _context;
        public FavouritsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            
            var user = _context.Users.FirstOrDefault(x => x.UserID == Globals.USER_ID);
            ProfileViewModel profile = new ProfileViewModel() { userInSystemId = user.UserID, Login = user.Login};
            var favSongs = _context.Favourites.Where(x=>x.UserID==user.UserID).ToList();
            var songs = _context.Songs.ToList();
            List<FavouritesViewModel> fs_vm = new List<FavouritesViewModel>();
               // if (favSongs.Count!=0)
               // {
                foreach (Favourite favSong in favSongs)
                {
                    int artistId = songs.FirstOrDefault(x => x.SongID == favSong.SongID).ArtistID;
                    int albumId = songs.FirstOrDefault(x => x.SongID == favSong.SongID).AlbumID;

                    var artist = _context.Artists.FirstOrDefault(x => x.ArtistID == artistId);
                    var album = _context.Albums.FirstOrDefault(x => x.AlbumID == albumId);
                    var favViewModel = new FavouritesViewModel()
                    {
                        SongID = songs.FirstOrDefault(x => x.SongID == favSong.SongID).SongID,
                        Title = songs.FirstOrDefault(x => x.SongID == favSong.SongID).Title,
                        Artist = artist.ArtistName,
                        Genre = songs.FirstOrDefault(x => x.SongID == favSong.SongID).Genre,
                        Album = album.AlbumName,
                        Duration = songs.FirstOrDefault(x => x.SongID == favSong.SongID).Duration,
                        Location = songs.FirstOrDefault(x => x.SongID == favSong.SongID).Location,
                    };
                    fs_vm.Add(favViewModel);
                }
                        UserAccountViewModel viewModel = new UserAccountViewModel() { Profile = profile, FavouriteSongs = fs_vm };
                        return View(viewModel);
                   // }
                
               // return View();
            }
            [HttpGet]
            public IActionResult DeleteFromFavourites(int songId)
            {
                var selectedSong = _context.Favourites.FirstOrDefault(x => songId == x.SongID && x.UserID==Globals.USER_ID);
                Console.WriteLine(selectedSong.SongID);
                // _context.Favourites.Remove(selectedSong);
                // _context.SaveChanges();

                /* ProfileViewModel profile = new ProfileViewModel() { userInSystemId = userInSystemId, Login = Login, FavouriteSongs = FavouriteSongs };
                 var favSongs = _context.Favourites.ToList();
                 var songs = _context.Songs.ToList();
                 List<FavouritesViewModel> fs_vm = new List<FavouritesViewModel>();

                 if (songs != null)
                 {
                     foreach (Favourite favSong in favSongs)
                     {
                         int artistId = songs.FirstOrDefault(x => x.SongID == favSong.SongID).ArtistID;
                         int albumId = songs.FirstOrDefault(x => x.SongID == favSong.SongID).AlbumID;

                         var artist = _context.Artists.FirstOrDefault(x => x.ArtistID == artistId);
                         var album = _context.Albums.FirstOrDefault(x => x.AlbumID == albumId);
                         var favViewModel = new FavouritesViewModel()
                         {
                             SongID = songs.FirstOrDefault(x => x.SongID == favSong.SongID).SongID,
                             Title = songs.FirstOrDefault(x => x.SongID == favSong.SongID).Title,
                             Artist = artist.ArtistName,
                             Genre = songs.FirstOrDefault(x => x.SongID == favSong.SongID).Genre,
                             Album = album.AlbumName,
                             Duration = songs.FirstOrDefault(x => x.SongID == favSong.SongID).Duration,
                             Location = songs.FirstOrDefault(x => x.SongID == favSong.SongID).Location,
                         };
                         fs_vm.Add(favViewModel);
                     }
                     UserAccountViewModel viewModel = new UserAccountViewModel() { Profile = profile, FavouriteSongs = fs_vm };
                     return View(viewModel);
                 }

                 return View();*/
                return RedirectToAction("Index", "Home");
            }
        }
    }


       


