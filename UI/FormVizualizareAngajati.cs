using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BL;
namespace FormLog.UI
{
    public partial class FormVizualizareAngajati : Form
    {

       
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
    
        public FormVizualizareAngajati()
        {
            InitializeComponent();
        }

        private void FormVizualizareAngajati_Load(object sender, EventArgs e)
        {
            try
            {
                server = "127.0.0.1";
                database = "piata";
                uid = "root";
                password = "root";
                String connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                String sql = "SELECT * FROM tb1 WHERE Rol='angajat'";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new System.Data.DataSet();
                adap.Fill(ds);
                grid1.DataSource = ds.Tables[0];
            }


            catch (Exception ex)
            { MessageBox.Show("exception"); }
        }
    }
}
