﻿using System;
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
    public partial class FormDeleteAngajat : Form
    {

        OperatiiUser op3 = new OperatiiUser();
        public FormDeleteAngajat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string username = textBox1.Text;
                op3.stergereangajat(username);
                MessageBox.Show("Verificaţi tabelul!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("exception");
            }

        }
    }
}
