using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entities;

namespace DAL
{
    public class AnuntDAL
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public AnuntDAL()
        {
            Initialize();
        }

        public void Initialize()
        {
            server = "127.0.0.1";
            database = "piata";
            uid = "root";
            password = "root";
            String connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }


        public void AdaugareAnunt(string index, string titlu, string descriere,byte[] poza)
        {
            String sql = "INSERT INTO anunturi(idAnunturi,Titlu,Descriere,Poza) VALUES ('" + index + "','" + titlu + "','" + descriere + "','" +poza + "')";
     
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
        public void EditareAnunt1(string titlu, string descriere_noua)
        {
            String sql = "UPDATE anunturi SET descriere='" + descriere_noua + "' WHERE Titlu='" + titlu + "'";

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

        public void EditareAnunt2(string titlu, string index_nou)
        {
            String sql = "UPDATE anunturi SET idAnunturi='" + index_nou + "' WHERE Titlu='" + titlu + "'";

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
       
        public void StergereAnunt(string titlu)
        {
            String sql = "DELETE from anunturi WHERE Titlu='" + titlu + "' LIMIT 1";

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
    

