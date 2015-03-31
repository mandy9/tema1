using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BL
{
    public class OperatiiAnunt
    {
        AnuntDAL a = new AnuntDAL();

        public void creareanunt(string index, string titlu, string descriere,byte[] poza)
        {
            a.AdaugareAnunt(index, titlu, descriere,poza);
           
        }

        public void editareanunt1(string titlu, string descriere_noua)
        {
            a.EditareAnunt1(titlu,descriere_noua);
        }

        public void editareanunt2(string titlu, string index_nou)
        {
            a.EditareAnunt2(titlu, index_nou);
        }
        public void stergereanunt(string titlu)
        {
            a.StergereAnunt(titlu);
        }
     
    }
}
