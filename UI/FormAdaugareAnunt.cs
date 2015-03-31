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
using System.IO;
using FormLog;
namespace FormLog.UI
{
    public partial class FormAdaugareAnunt : Form
    {

        OperatiiAnunt op1 = new OperatiiAnunt();
        OperatiiUser op2 = new OperatiiUser();
        FormLog f = new FormLog();
        static int nranunt_nou=0;
  

        public FormAdaugareAnunt()
        {
            InitializeComponent();
        }


        private void FormAdaugareAnunt_Load(object sender, EventArgs e)
        {
        }

        
        public virtual void button1_Click(object sender, EventArgs e)
        {
                  
            string index = indexanunt.Text;
            string titlu = titluanunt.Text;
            string descriere = descriereanunt.Text;
            byte[] poza = null;                             //GetPhoto(boxpoza.Text);
            
            op1.creareanunt(index, titlu, descriere, poza);
            
            string usercurent = f.getu();
            nranunt_nou++;

            op2.NrAnunturi(nranunt_nou,usercurent);
            MessageBox.Show("Vizualizati tabelul!");
           
          }

  

       /* public static byte[] GetPhoto(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Append);
            BinaryReader br = new BinaryReader(fs);

            byte[] photo = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();

            return photo;
        }*/

        }
    }

