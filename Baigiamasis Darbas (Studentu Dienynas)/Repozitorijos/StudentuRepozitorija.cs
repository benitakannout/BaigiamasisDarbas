using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis_Darbas__Studentu_Dienynas_.Repozitorijos
{
    public class StudentuRepozitorija
    {
        public List<Studentai> studentai = new List<Studentai>();

        public StudentuRepozitorija()
        {
            studentai.Add(new Studentai(1, "Sandra"));
            studentai.Add(new Studentai(2, "Aurimas"));
            studentai.Add(new Studentai(3, "Karolis"));
            studentai.Add(new Studentai(4, "Brigita"));
            studentai.Add(new Studentai(5, "Laurynas"));
            studentai.Add(new Studentai(6, "Sabina"));
            studentai.Add(new Studentai(7, "Asta"));
            studentai.Add(new Studentai(8, "Gabrielius"));
            studentai.Add(new Studentai(9, "Rokas"));
            studentai.Add(new Studentai(10, "Simona"));
            studentai.Add(new Studentai(11, "Ieva"));
            studentai.Add(new Studentai(12, "Paulius"));
            studentai.Add(new Studentai(13, "Tomas"));
            studentai.Add(new Studentai(14, "Tadas"));
        }
        public Studentai Retrieve(string vardas)
        {
            var studentas = studentai.FirstOrDefault(x => x.Vardas == vardas);
            return studentas;
        }

        public void AddNewStudent(int id, string vardas)
        {
            studentai.Add(new Studentai(id, vardas));
        }

        public List<Studentai> Retrieve()
        {
            return studentai;
        }
    }
}
