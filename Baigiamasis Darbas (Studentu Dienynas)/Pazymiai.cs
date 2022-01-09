using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baigiamasis_Darbas__Studentu_Dienynas_.Repozitorijos;

namespace Baigiamasis_Darbas__Studentu_Dienynas_
{
    public class Pazymiai
    {
        public int Id { get; set; }
        public string Vardas { get; set; }
        public int Trimestras { get; set; }
        public int Pazymys { get; set; }
        public Pazymiai()
        {

        }
        public Pazymiai(int id, string vardas, int trimestras, int pazymys)
        {
            Id = id;
            Vardas = vardas;
            Trimestras = trimestras;
            Pazymys = pazymys;
        }
    }
}
