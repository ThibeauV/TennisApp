using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisApp.Models;

namespace TennisApp.Repositories
{
    public class FirebaseRepositories : IDataRepositories<Player>
    {
        private const string BaseURL = "https://tennisapp-63974-default-rtdb.europe-west1.firebasedatabase.app/";
        private readonly ChildQuery _query;

        public FirebaseRepositories()
        {
            string pathPlayer = "players";
            _query = new FirebaseClient(BaseURL).Child(pathPlayer);
        }

        public async Task<IEnumerable<Player>> GetPlayersAsync()
        {
            try
            {
                var firebaseObjects = await _query.OnceAsync<Player>();

                IEnumerable<Player> players = firebaseObjects.Select(x => new Player
                {
                    PlayerId = x.Object.PlayerId,
                    Firstname = x.Object.Firstname,
                    Lastname = x.Object.Lastname,
                    Age = x.Object.Age
                });

                return players;
            }
            catch (Exception x)
            {
                Debug.WriteLine(x);
                return null;
            }
        }
    }
}
