using System;
using System.Collections.Generic;
using System.Text;

namespace TennisApp.Models
{
    public class Players
    {
        private string playerId;

        public string PlayerId
        {
            get { return playerId; }
            set { playerId = value; }
        }

        private string firstname;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        private string lastname;

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
