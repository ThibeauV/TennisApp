using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TennisApp.Repositories
{
    public interface IDataRepositories<T>
    {
        Task<IEnumerable<T>> GetPlayersAsync();
    }
}
