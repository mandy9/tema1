using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using FormLog.UI;
using MySql.Data.MySqlClient;
namespace FormLog.UI
{
    
   
    public partial class FormRaport : Form
    {
        OperatiiUser op5 = new OperatiiUser();
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public FormRaport()
        {
            InitializeComponent();
        }

        private void FormRaport_Load(object sender, EventArgs e)
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
            String sql = "SELECT * FROM tb1 WHERE rol= 'angajat' " ;
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new System.Data.DataSet();
            adap.Fill(ds);
            gridi.DataSource = ds.Tables[0];
        }
    }
}
