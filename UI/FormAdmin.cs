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
namespace FormLog
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void butonangajatimanagement_Click(object sender, EventArgs e)
        {
            Formoperatiipeangajati f = new Formoperatiipeangajati();
            f.Show();
        }

        private void butonraport_Click(object sender, EventArgs e)
        {
            FormRaport fr = new FormRaport();
            fr.Show();
        }
    }
}
