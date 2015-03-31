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
using Entities;
namespace FormLog.UI
{
    public partial class FormStergereAnunt : Form
    {

        OperatiiAnunt op3 = new OperatiiAnunt();


        public FormStergereAnunt()
        {
            InitializeComponent();
        }

        private void FormStergereAnunt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titlul = textBox1.Text;
            op3.stergereanunt(titlul);
            MessageBox.Show("Vizualizati tabelul!");
        }
    }
}
