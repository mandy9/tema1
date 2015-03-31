using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLog
{
    public partial class FormAngajat : Form
    {
        public FormAngajat()
        {
            InitializeComponent();
        }

        private void crud_Click(object sender, EventArgs e)
        {
            FormAngajatCrud crud = new FormAngajatCrud();
            crud.Show();
        }
    }
}
