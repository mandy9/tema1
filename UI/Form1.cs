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



namespace FormLog

{
    public partial class FormLog : Form
    {

        OperatiiUser op = new OperatiiUser();
        public FormLog()
        {
            InitializeComponent();
        }

        public String getu()
        {
            return usernamebox.Text; 
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {

            string un = usernamebox.Text;
            string p = passwordbox.Text;
            User user = op.login(un, p);
            if (user == null)
            {
               
                MessageBox.Show("Date incorecte!");
            }
            else {

                if (user.Rol.Equals("admin"))
                {
                    FormAdmin form = new FormAdmin();
                    form.Show();
                }
                else
                {
                    FormAngajat form = new FormAngajat();
                    form.Show();
                }
            }
            
        }

      
        private void forgotbutton_Click(object sender, EventArgs e)
        {
            string un = usernamebox.Text;
            String new_password = op.ForgotPassword(un);
            MessageBox.Show("Parola noua: " + new_password);
        }
        }
    }

