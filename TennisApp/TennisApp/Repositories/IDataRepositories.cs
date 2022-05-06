using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TennisApp.Models;

namespace TennisApp.Repositories
{
    public interface IDataRepositories<T>
    {
        Task<IEnumerable<T>> GetPlayersAsync();

        Task<bool> AddPlayersAsync(Player player);
    }
}
