using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
          
            private string username;
            private string password;
            private string nume;
            private string prenume;
            private int salar;
            private string rol;
            private int nr_anunturi;
        public User( string username, string password, string nume, string prenume, string salar,string rol)
        {
           
            this.username = username;
            this.password = password;
            this.nume = nume;
            this.prenume = prenume;
            this.salar = Int32.Parse(salar);
            this.rol =rol ;
            
        }

       
        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public String Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }
        public int Salar
        {
            get { return salar; }
            set { salar = value; }
        }
        public String Rol
        {
            get { return rol; }
            set { rol = value; }
        }
       
         }
}

    

