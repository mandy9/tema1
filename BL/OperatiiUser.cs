using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DAL;
using Entities;


namespace BL
{
   public class OperatiiUser
    {
        UserDAL userDAL = new UserDAL();

        private string getMd5Hash(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }


        public User login(string username, string pass)
        {

            User user = userDAL.getUser(username, getMd5Hash(pass));
            return user;
        }
    

       public void creareangajat(string username, string password, string nume,string prenume,int salar,string rol)
       {
           userDAL.AdaugareAngajat(username,password,nume,prenume,salar,rol);
            }

       public void editareangajat(string username, string salar_nou)
       {
           userDAL.EditareAngajat(username, salar_nou);
       }

       public void stergereangajat(string username)
       {
           userDAL.StergereAngajat(username);
       }


       public void NrAnunturi(int nr_nou,string user)
       {
        userDAL.nr_anunturi(nr_nou,user);
       }

       
         public String ForgotPassword(string user)
         {
             string newpassword = generateRandomPassword(3);
             userDAL.resetPassword(user, getMd5Hash( newpassword));
             return newpassword;
         }

         private string generateRandomPassword(int length)
         {
             const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
             StringBuilder res = new StringBuilder();
             Random rnd = new Random();
             while (0 < length--)
             {
                 res.Append(valid[rnd.Next(valid.Length)]);
             }
             return res.ToString();
             
         }


     }
    }



