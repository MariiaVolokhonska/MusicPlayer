using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicPlayer.Models.Interfaces;
using MusicPlayer.Models.Data;

namespace MusicPlayer.Models.DBRepository.Queries
{
    public  class UserQueries : IUserQueries
    {
        private readonly ApplicationDbContext _context;
        public UserQueries(ApplicationDbContext context)
        {
            _context = context;
        }
        
        
        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        

        public void DeleteUser(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.UserID == id);
            _context.Remove(user);
            _context.SaveChanges();
        }
        public User GetUserByLogin(string login) => _context.Users.FirstOrDefault(x => x.Login == login);
        
        public User GetUserById(int id) => _context.Users.FirstOrDefault(x => id == x.UserID);



    }
}
