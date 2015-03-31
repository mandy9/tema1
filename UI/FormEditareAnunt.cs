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
    public partial class FormEditareAnunt : Form
    {

        OperatiiAnunt op2 = new OperatiiAnunt();
        public FormEditareAnunt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titlul = box1.Text;
            string modificare = box2.Text;
          
            op2.editareanunt1(titlul, modificare);
            MessageBox.Show("Vizualizati tabelul!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string titlul = box1.Text;
            string indexmod = indexmodificare.Text;
            op2.editareanunt2(titlul,indexmod);
            MessageBox.Show("Vizualizati tabelul!");
        }

        
    }
}
