using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TennisApp.Models;

namespace TennisApp.Repositories
{
    public class FirebaseRepositories : IDataRepositories<Players>
    {
        private const string BaseURL = "https://tennisapp-63974-default-rtdb.europe-west1.firebasedatabase.app/";
        private readonly ChildQuery _query;

        public FirebaseRepositories()
        {
            string pathPlayer = "players";
            _query = new FirebaseClient(BaseURL).Child(pathPlayer);
        }

        public Task<IEnumerable<Players>> GetPlayersAsync()
        {
            throw new NotImplementedException();
        }
    }
}
