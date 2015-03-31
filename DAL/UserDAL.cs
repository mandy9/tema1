using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entities;


namespace DAL
{

   public class UserDAL
    {

    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;



    public UserDAL()
    { Initialize(); }
        
       

       public void Initialize()
       {
        server = "127.0.0.1";
        database = "piata";
        uid = "root";
        password = "root";
        String connectionString ;
        connectionString= "SERVER=" + server + ";" + "DATABASE=" + 
		database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        connection = new MySqlConnection(connectionString);            
        }


        public User getUser(String username, String password)
        {
            User u = null;
            String sql = "SELECT * FROM piata.tb1 WHERE username='" + username +  "'  AND password='" + password + "'";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    u = new User(reader["username"].ToString(), reader["password"].ToString(), reader["nume"].ToString(), reader["prenume"].ToString(), reader["salar"].ToString(), reader["rol"].ToString());
                }
                else
                {
                    u = null;
                }
                connection.Close();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                connection.Close();
                return null;
            }
            return u;
        }

        public void AdaugareAngajat(string username, string parola,string nume, string prenume, int salar,string rol)
        {
            String sql1 = "INSERT INTO tb1 (username,password,nume,prenume,salar,rol) VALUES ('" + username +  "','" + parola + "','"+ nume + "','" + prenume + "','" + salar + "','" + rol + "')";
          
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql1, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                connection.Close();
            }

        }

        public void EditareAngajat(string username, string salar_nou)
        {
            String sql = "UPDATE tb1 SET salar='" + salar_nou + "' WHERE username='" + username + "'";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                connection.Close();
            }

        }


        public void StergereAngajat(string username)
        {
            String sql = "DELETE from tb1 WHERE username='" + username + "' LIMIT 1";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                connection.Close();
            }

        }

        public void nr_anunturi(int nr_nou,string user)
        {
            String sql = "UPDATE tb1 SET nr_anunturi='" + nr_nou + "' WHERE username='" + user + "'";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                connection.Close();
            }
        }


       public void resetPassword(string user, string new_password)
        {
            String sql = "UPDATE tb1 SET password='" + new_password + "' WHERE username='" + user + "'";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                connection.Close();
            }
        }
    }
}
    
