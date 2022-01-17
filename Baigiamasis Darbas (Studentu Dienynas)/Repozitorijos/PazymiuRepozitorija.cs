using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis_Darbas__Studentu_Dienynas_.Repozitorijos
{
    public class PazymiuRepozitorija
    {
        public List<Pazymiai> pazymiai = new List<Pazymiai>();
        public PazymiuRepozitorija()
        {
            pazymiai.Add(new Pazymiai(1, 1, 7));
            pazymiai.Add(new Pazymiai(1, 2, 9));
            pazymiai.Add(new Pazymiai(1, 3, 7));
            pazymiai.Add(new Pazymiai(1, 4, 8));
            pazymiai.Add(new Pazymiai(2, 1, 9));
            pazymiai.Add(new Pazymiai(2, 2, 8));
            pazymiai.Add(new Pazymiai(2, 3, 9));
            pazymiai.Add(new Pazymiai(2, 4, 9));
            pazymiai.Add(new Pazymiai(3, 1, 6));
            pazymiai.Add(new Pazymiai(3, 2, 10));
            pazymiai.Add(new Pazymiai(3, 3, 8));
            pazymiai.Add(new Pazymiai(3, 4, 8));
            pazymiai.Add(new Pazymiai(4, 1, 10));
            pazymiai.Add(new Pazymiai(4, 2, 9));
            pazymiai.Add(new Pazymiai(4, 3, 10));
            pazymiai.Add(new Pazymiai(4, 4, 10));
            pazymiai.Add(new Pazymiai(5, 1, 7));
            pazymiai.Add(new Pazymiai(5, 2, 7));
            pazymiai.Add(new Pazymiai(5, 3, 6));
            pazymiai.Add(new Pazymiai(5, 4, 7));
            pazymiai.Add(new Pazymiai(6, 1, 8));
            pazymiai.Add(new Pazymiai(6, 2, 8));
            pazymiai.Add(new Pazymiai(6, 3, 8));
            pazymiai.Add(new Pazymiai(6, 4, 8));
            pazymiai.Add(new Pazymiai(7, 1, 10));
            pazymiai.Add(new Pazymiai(7, 2, 9));
            pazymiai.Add(new Pazymiai(7, 3, 9));
            pazymiai.Add(new Pazymiai(7, 4, 9));
            pazymiai.Add(new Pazymiai(8, 1, 7));
            pazymiai.Add(new Pazymiai(8, 2, 8));
            pazymiai.Add(new Pazymiai(8, 3, 6));
            pazymiai.Add(new Pazymiai(8, 4, 7));
            pazymiai.Add(new Pazymiai(9, 1, 10));
            pazymiai.Add(new Pazymiai(9, 2, 10));
            pazymiai.Add(new Pazymiai(9, 3, 10));
            pazymiai.Add(new Pazymiai(9, 4, 10));
            pazymiai.Add(new Pazymiai(10, 1, 8));
            pazymiai.Add(new Pazymiai(10, 2, 6));
            pazymiai.Add(new Pazymiai(10, 3, 8));
            pazymiai.Add(new Pazymiai(10, 4, 7));
            pazymiai.Add(new Pazymiai(11, 1, 6));
            pazymiai.Add(new Pazymiai(11, 2, 8));
            pazymiai.Add(new Pazymiai(11, 3, 9));
            pazymiai.Add(new Pazymiai(11, 4, 8));
            pazymiai.Add(new Pazymiai(12, 1, 7));
            pazymiai.Add(new Pazymiai(12, 2, 6));
            pazymiai.Add(new Pazymiai(12, 3, 6));
            pazymiai.Add(new Pazymiai(12, 4, 6));
            pazymiai.Add(new Pazymiai(13, 1, 9));
            pazymiai.Add(new Pazymiai(13, 2, 9));
            pazymiai.Add(new Pazymiai(13, 3, 9));
            pazymiai.Add(new Pazymiai(13, 4, 9));
            pazymiai.Add(new Pazymiai(14, 1, 10));
            pazymiai.Add(new Pazymiai(14, 2, 7));
            pazymiai.Add(new Pazymiai(14, 3, 7));
            pazymiai.Add(new Pazymiai(14, 4, 8));
        }
        public Pazymiai RetrieveGrade(int id, int trimestras)
        {
            var pazymys = pazymiai.FirstOrDefault(x => x.Id == id && x.Trimestras == trimestras);
            return pazymys;
        }

        public List<Pazymiai> RetrieveAllGradesForTerm(int trimestras)
        {
            var trimestroPazymiai = Retrieve();
            trimestroPazymiai = trimestroPazymiai.Where(pazymys => pazymys.Trimestras.Equals(trimestras)).ToList();
            return trimestroPazymiai;
        }
        public List<Pazymiai> RetrieveAllGradesForStudent(int id)
        {
            var studentoPazymiai = Retrieve();
            studentoPazymiai = studentoPazymiai.Where(pazymys => pazymys.Id.Equals(id)).ToList();
            return studentoPazymiai;
        }
        public List<Pazymiai> Retrieve()
        {
            return pazymiai;
        }
        public List<Pazymiai> AddGrade (int id, int trimestras, int pazymys)
        {
            pazymiai.Add(new Pazymiai(id, trimestras, pazymys));
            return pazymiai;
        }

        public void RemoveGrade (int id, int trimestras)
        {
            var pazymiai = Retrieve();
            var pazymysIstrinti = pazymiai.SingleOrDefault(x => x.Id == id && x.Trimestras == trimestras);
            if (pazymysIstrinti != null)
            {
                pazymiai.Remove(pazymysIstrinti);
            }
            else
            {
                Console.WriteLine($"Pazymys pagal id {pazymysIstrinti.Id} neegzistuoja");
            }
        }

        public Pazymiai EditGrade(int id, int trimestras, int pazymys)
        {
            var pazymiai = Retrieve();
            var pazymysRedaguoti = pazymiai.SingleOrDefault(x => x.Id == id && x.Trimestras == trimestras);
            if (pazymysRedaguoti == null)
            {
                Console.WriteLine($"Pazymys pagal id {pazymysRedaguoti.Id} neegzistuoja");
                return null;
            }

            pazymysRedaguoti.Pazymys = pazymys;
            return pazymysRedaguoti;
        }
    }
}
