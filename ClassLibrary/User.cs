using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class User
    {
        private string id;
        private string name;
        private string password;
        private string email;
        private string gender;
        private string noKtp;
        private string imgKtp;

        public User(string id, string name, string password, string email, string gender, string noKtp, string imgKtp)
        {
            Id = id;
            Name = name;
            Password = password;
            Email = email;
            Gender = gender;
            NoKtp = noKtp;
            ImgKtp = imgKtp;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
        public string NoKtp { get => noKtp; set => noKtp = value; }
        public string ImgKtp { get => imgKtp; set => imgKtp = value; }


    }
}