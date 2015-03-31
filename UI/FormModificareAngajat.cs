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
    public partial class FormModificareAngajat : Form
    {
        OperatiiUser op2 = new OperatiiUser();

        public FormModificareAngajat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeuser = textBox1.Text;
            string salar = textBox2.Text;
            op2.editareangajat(numeuser, salar);
            MessageBox.Show("Verificati tabelul!");
        }
    }
}
