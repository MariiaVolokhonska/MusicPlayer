using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicPlayer.Models.Interfaces;

namespace MusicPlayer.Models.DBRepository.Interfaces
{
    public interface IQueries: ISongsQueries, IUserQueries
    {
    }
}
