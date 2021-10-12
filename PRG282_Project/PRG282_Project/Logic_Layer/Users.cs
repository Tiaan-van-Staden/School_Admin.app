using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.Logic_Layer
{
    class Users
    {
        string name;
        string password;

        public Users(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
    }
}
