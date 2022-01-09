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
            pazymiai.Add(new Pazymiai(1, "Sandra", 1, 7));
            pazymiai.Add(new Pazymiai(1, "Sandra", 2, 9));
            pazymiai.Add(new Pazymiai(1, "Sandra", 3, 7));
            pazymiai.Add(new Pazymiai(1, "Sandra", 1, 8));
            pazymiai.Add(new Pazymiai(2, "Aurimas", 1, 9));
            pazymiai.Add(new Pazymiai(2, "Aurimas", 2, 8));
            pazymiai.Add(new Pazymiai(2, "Aurimas", 3, 9));
            pazymiai.Add(new Pazymiai(2, "Aurimas", 4, 9));
            pazymiai.Add(new Pazymiai(3, "Karolis", 1, 6));
            pazymiai.Add(new Pazymiai(3, "Karolis", 2, 10));
            pazymiai.Add(new Pazymiai(3, "Karolis", 3, 8));
            pazymiai.Add(new Pazymiai(3, "Karolis", 4, 8));
            pazymiai.Add(new Pazymiai(4, "Brigita", 1, 10));
            pazymiai.Add(new Pazymiai(4, "Brigita", 2, 9));
            pazymiai.Add(new Pazymiai(4, "Brigita", 3, 10));
            pazymiai.Add(new Pazymiai(4, "Brigita", 4, 10));
            pazymiai.Add(new Pazymiai(5, "Laurynas", 1, 7));
            pazymiai.Add(new Pazymiai(5, "Laurynas", 2, 7));
            pazymiai.Add(new Pazymiai(5, "Laurynas", 3, 6));
            pazymiai.Add(new Pazymiai(5, "Laurynas", 4, 7));
            pazymiai.Add(new Pazymiai(6, "Sabina", 1, 8));
            pazymiai.Add(new Pazymiai(6, "Sabina", 2, 8));
            pazymiai.Add(new Pazymiai(6, "Sabina", 3, 8));
            pazymiai.Add(new Pazymiai(6, "Sabina", 4, 8));
            pazymiai.Add(new Pazymiai(7, "Asta", 1, 10));
            pazymiai.Add(new Pazymiai(7, "Asta", 2, 9));
            pazymiai.Add(new Pazymiai(7, "Asta", 3, 9));
            pazymiai.Add(new Pazymiai(7, "Asta", 4, 9));
            pazymiai.Add(new Pazymiai(8, "Gabrielius", 1, 7));
            pazymiai.Add(new Pazymiai(8, "Gabrielius", 2, 8));
            pazymiai.Add(new Pazymiai(8, "Gabrielius", 3, 6));
            pazymiai.Add(new Pazymiai(8, "Gabrielius", 4, 7));
            pazymiai.Add(new Pazymiai(9, "Rokas", 1, 10));
            pazymiai.Add(new Pazymiai(9, "Rokas", 2, 10));
            pazymiai.Add(new Pazymiai(9, "Rokas", 3, 10));
            pazymiai.Add(new Pazymiai(9, "Rokas", 4, 10));
            pazymiai.Add(new Pazymiai(10, "Simona", 1, 8));
            pazymiai.Add(new Pazymiai(10, "Simona", 2, 6));
            pazymiai.Add(new Pazymiai(10, "Simona", 3, 8));
            pazymiai.Add(new Pazymiai(10, "Simona", 4, 7));
            pazymiai.Add(new Pazymiai(11, "Ieva", 1, 6));
            pazymiai.Add(new Pazymiai(11, "Ieva", 2, 8));
            pazymiai.Add(new Pazymiai(11, "Ieva", 3, 9));
            pazymiai.Add(new Pazymiai(11, "Ieva", 4, 8));
            pazymiai.Add(new Pazymiai(12, "Paulius", 1, 7));
            pazymiai.Add(new Pazymiai(12, "Paulius", 2, 6));
            pazymiai.Add(new Pazymiai(12, "Paulius", 3, 6));
            pazymiai.Add(new Pazymiai(12, "Paulius", 4, 6));
            pazymiai.Add(new Pazymiai(13, "Tomas", 1, 9));
            pazymiai.Add(new Pazymiai(13, "Tomas", 2, 9));
            pazymiai.Add(new Pazymiai(13, "Tomas", 3, 9));
            pazymiai.Add(new Pazymiai(13, "Tomas", 4, 9));
            pazymiai.Add(new Pazymiai(14, "Tadas", 1, 10));
            pazymiai.Add(new Pazymiai(14, "Tadas", 2, 7));
            pazymiai.Add(new Pazymiai(14, "Tadas", 3, 7));
            pazymiai.Add(new Pazymiai(14, "Tadas", 4, 8));
        }

        public List<Pazymiai> Retrieve()
        {
            return pazymiai;
        }
    }
}
