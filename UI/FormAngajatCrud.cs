using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormLog.UI;
using BL;

namespace FormLog
{
    public partial class FormAngajatCrud : Form
    {
        OperatiiAnunt operatii = new OperatiiAnunt();

        public FormAngajatCrud()
        {
            InitializeComponent();
        }

        private void butonvizualizareanunt_Click(object sender, EventArgs e)
        {
            FormCRUD f = new FormCRUD();
            f.Show();
                       
        }

        private void butoncreareanunt_Click(object sender, EventArgs e)
        {
            FormAdaugareAnunt fa = new FormAdaugareAnunt();
            fa.Show();
            }

        private void butoneditare_Click(object sender, EventArgs e)
        {
            FormEditareAnunt fe = new FormEditareAnunt();
            fe.Show();
        }

        private void butonstergere_Click(object sender, EventArgs e)
        {
            FormStergereAnunt fs = new FormStergereAnunt();
            fs.Show();
        }
    }
}
