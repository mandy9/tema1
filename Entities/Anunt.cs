using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows;
namespace Entities

{
   public class Anunt
    {
        private int idAnunt;
        private string titlu;
        private string descriere;
        byte[] poza;
      //  Bitmap bmp = new Bitmap(@"C:\temp\test.png");
        public Anunt(string idAnunt, string titlu, string descriere,byte[] poza)
        {
            this.idAnunt =Int32.Parse(idAnunt);
            this.titlu = titlu;
            this.descriere = descriere;
            this.poza = poza;
        }

        public int IdAnunt
        {
            get { return idAnunt; }
            set { idAnunt = value; }
        }

        public String Titlu
        {
            get { return titlu; }
            set { titlu = value; }
        }

        public String Descriere
        {
            get { return descriere; }
            set { descriere = value; }
        }
        
       
        
    }
}
