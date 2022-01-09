using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baigiamasis_Darbas__Studentu_Dienynas_.Repozitorijos;

namespace Baigiamasis_Darbas__Studentu_Dienynas_
{
    public class Studentai
    {
        public int ID { get; set; }
        public string Vardas { get; set; }
        public Studentai()
        {

        }
        public Studentai(int id, string vardas)
        {
            ID = id;
            Vardas = vardas;
        }
    }
}
