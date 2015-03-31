using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLog.UI
{
    public partial class Formoperatiipeangajati : Form
    {
        public Formoperatiipeangajati()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDeleteAngajat fd = new FormDeleteAngajat();
            fd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVizualizareAngajati fv = new FormVizualizareAngajati();
            fv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddAngajat f = new FormAddAngajat();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormModificareAngajat fm = new FormModificareAngajat();
            fm.Show();
        }
    }
}
