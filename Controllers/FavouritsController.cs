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
using MusicPlayer.Models.DBRepository.Queries;

namespace MusicPlayer.Controllers
{
    public class FavouritsController : Controller

    {
        private readonly ApplicationDbContext _context;
        private SongsQueries s_queries;
        private UserQueries u_queries;
        private FavouritesQueiries f_queries;
        private ArtistQueries a_queries;
        private AlbumQueries alb_queries;
        public FavouritsController(ApplicationDbContext context)
        {
            _context = context;
            s_queries = new SongsQueries(_context);
            u_queries = new UserQueries(_context);
            f_queries = new FavouritesQueiries(_context);
            a_queries = new ArtistQueries(_context);
            alb_queries = new AlbumQueries(_context);
        }
        [HttpGet]
        public IActionResult Index()
        {


            var user = u_queries.GetUserById(Globals.USER_ID);
              
            ProfileViewModel profile = new ProfileViewModel() { userInSystemId = user.UserID, Login = user.Login};
            var favSongs = f_queries.GetFavouritesByUserId(user.UserID);
           
            var songs = s_queries.GetAllSongs();
                
            List<FavouritesViewModel> fs_vm = new List<FavouritesViewModel>();
              
                foreach (Favourite favSong in favSongs)
                {
                    int artistId = songs.FirstOrDefault(x => x.SongID == favSong.SongID).ArtistID;
                    int albumId = songs.FirstOrDefault(x => x.SongID == favSong.SongID).AlbumID;

                var artist = a_queries.GetArtistById(artistId);
                   
                    var album = alb_queries.GetAlbumById(albumId);
                    
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
            [HttpGet]
            public IActionResult DeleteFromFavourites(int songId)
            {
            var selectedSong = f_queries.GetFavouriteSongBySongIdAndUserId(songId, Globals.USER_ID);
            
            f_queries.DeleteFromFavourites(selectedSong);
                

              
                return RedirectToAction("Index");
            }
        }
    }


       


