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
namespace FormLog.UI
{
    public partial class FormAddAngajat : Form
    {

        OperatiiUser op5 = new OperatiiUser();
        public FormAddAngajat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = textBox2.Text;
            string password = textBox3.Text;
            string nume= textBox4.Text;
            string prenume = textBox5.Text;
            int salar = Int32.Parse(textBox6.Text);
            string rol = textBox7.Text;
            op5.creareangajat(username, password,nume, prenume, salar, rol);
            MessageBox.Show("Vizualizati tabelul!");
        }
    }
}
