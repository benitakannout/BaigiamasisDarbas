using System;
using Baigiamasis_Darbas__Studentu_Dienynas_;
using Baigiamasis_Darbas__Studentu_Dienynas_.Repozitorijos;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentuRepo = new StudentuRepozitorija();
            var pazymiuRepo = new PazymiuRepozitorija();

            while (true)
            {
                try
                {
                    Console.WriteLine("1 - perziureti pazymius, 2 - redaguoti pazymius, 3 - perziureti studentu sarasa, 4 - redaguoti studentu sarasa");
                    int pasirinkimas = Convert.ToInt32(Console.ReadLine());
                    switch (pasirinkimas)
                    {
                        case 1:
                            PerziuretiPazymiusMeniu(pazymiuRepo);
                            break;
                        case 2:
                            RedaguotiPazymiusMeniu(pazymiuRepo);
                            break;
                        case 3:
                            PerziuretiStudentuSarasa(studentuRepo);
                            break;
                        case 4:
                            RedaguotiStudentuSarasa(studentuRepo);
                            break;
                        default:
                            Console.WriteLine("Negalimas pasirinkimas");
                            break;
                    };
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ivyko klaida: {e.Message}");
                }
            }
        }

        public static void RedaguotiStudentuSarasa(StudentuRepozitorija studentuRepozitorija)
        {
            Console.WriteLine("Pasirinkite veiksma:");
            Console.WriteLine("1 - prideti studenta, 2 - istrinti studenta, 3 - keisti studento varda");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    PridetiStudenta(studentuRepozitorija);
                    break;
                case 2:
                    IstrintiStudenta(studentuRepozitorija);
                    break;
                case 3:
                    KeistiStudentoVarda(studentuRepozitorija);
                    break;
                default:
                    Console.WriteLine("Negalimas pasirinkimas");
                    break;
            }
        }

        public static List<Studentai> PridetiStudenta(StudentuRepozitorija studentuRepozitorija)
        {
            Console.WriteLine("Iveskite studento varda:");
            string vardas = Console.ReadLine();
            studentuRepozitorija.AddNewStudent(vardas);
            var studentai = studentuRepozitorija.Retrieve();
            return studentai;
        }

        public static List<Studentai> IstrintiStudenta(StudentuRepozitorija studentuRepozitorija)
        {
            Console.WriteLine("Iveskite studento varda:");
            string vardas = Console.ReadLine();
            studentuRepozitorija.RemoveStudent(vardas);
            var studentai = studentuRepozitorija.Retrieve();
            return studentai;
        }

        public static List<Studentai> KeistiStudentoVarda(StudentuRepozitorija studentuRepozitorija)
        {
            Console.WriteLine("Iveskite studento ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite varda:");
            string vardas = Console.ReadLine();
            studentuRepozitorija.EditStudent(id, vardas);
            var studentai = studentuRepozitorija.Retrieve();
            return studentai;
        }

        public static void PerziuretiStudentuSarasa(StudentuRepozitorija studentuRepozitorija)
        {
            var visiStudentai = studentuRepozitorija.Retrieve();
            foreach (var studentas in visiStudentai)
            {
                Console.WriteLine($"Studento ID - {studentas.ID}, studento vardas - {studentas.Vardas}");
            }
        }

        public static void PerziuretiPazymiusMeniu(PazymiuRepozitorija pazymiuRepozitorija)
        {
            Console.WriteLine("Pasirinkite ka norite perziureti:");
            Console.WriteLine("1 - visu studentu trimestro pazymiai, 2 - visi vieno studento pazymiai, 3 - studento vieno trimestro pazymys");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    VisiStudentaiTrimestras(pazymiuRepozitorija);
                    break;
                case 2:
                    VienoStudentoPazymiai(pazymiuRepozitorija);
                    break;
                case 3:
                    VienasPazymys(pazymiuRepozitorija);
                    break;
                default:
                    Console.WriteLine("Negalimas pasirinkimas");
                    break;
            }
        }

        public static void RedaguotiPazymiusMeniu(PazymiuRepozitorija pazymiuRepozitorija)
        {
            Console.WriteLine("Pasirinkite ka norite redaguoti:");
            Console.WriteLine("1 - redaguoti pazymi, 2 - prideti pazymi, 3 - istrinti pazymi");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    RedaguotiPazymi(pazymiuRepozitorija);
                    break;
                case 2:
                    PridetiPazymi(pazymiuRepozitorija);
                    break;
                case 3:
                    IstrintiPazymi(pazymiuRepozitorija);
                    break;
                default:
                    Console.WriteLine("Negalimas pasirinkimas");
                    break;
            }
        }

        public static List<Pazymiai> RedaguotiPazymi(PazymiuRepozitorija pazymiuRepozitorija)
        {
            Console.WriteLine("Iveskite studento ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pazymio trimestro numeri (4 - metinis pazymys):");
            int trimestras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite nauja pazymi:");
            int pazymys = Convert.ToInt32(Console.ReadLine());
            pazymiuRepozitorija.EditGrade(id, trimestras, pazymys);
            var pazymiai = pazymiuRepozitorija.Retrieve();
            return pazymiai;
        }

        public static List<Pazymiai> PridetiPazymi(PazymiuRepozitorija pazymiuRepozitorija)
        {
            Console.WriteLine("Iveskite studento ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pazymio trimestro numeri (4 - metinis pazymys):");
            int trimestras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pazymi, kuri norite prideti:");
            int pazymys = Convert.ToInt32(Console.ReadLine());
            pazymiuRepozitorija.AddGrade(id, trimestras, pazymys);
            var pazymiai = pazymiuRepozitorija.Retrieve();
            return pazymiai;
        }

        public static List<Pazymiai> IstrintiPazymi(PazymiuRepozitorija pazymiuRepozitorija)
        {
            Console.WriteLine("Iveskite studento ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trinamo pazymio trimestro numeri (4 - metinis pazymys):");
            int trimestras = Convert.ToInt32(Console.ReadLine());
            pazymiuRepozitorija.RemoveGrade(id, trimestras);
            var pazymiai = pazymiuRepozitorija.Retrieve();
            return pazymiai;
        }

        public static void VisiStudentaiTrimestras(PazymiuRepozitorija pazymiuRepozitorija)
        {
            Console.WriteLine("Pasirinkite trimestra:");
            Console.WriteLine("1 - I trimestras, 2 - II trimestras, 3 - III trimestras, 4 - metiniai pazymiai");
            int trimestras = Convert.ToInt32(Console.ReadLine());
            var pazymiaiPagalTrimestra = pazymiuRepozitorija.RetrieveAllGradesForTerm(trimestras);

            foreach(var pazymys in pazymiaiPagalTrimestra)
            {
                Console.WriteLine($"Studento eiles numeris - {pazymys.Id}; trimestro pazymys - {pazymys.Pazymys}");
            }
        }

        public static void VienoStudentoPazymiai(PazymiuRepozitorija pazymiuRepozitorija)
        {
            Console.WriteLine("Iveskite studento eiles numeri");
            int id = Convert.ToInt32(Console.ReadLine());
            var pazymiaiPagalStudenta = pazymiuRepozitorija.RetrieveAllGradesForStudent(id);

            foreach (var pazymys in pazymiaiPagalStudenta)
            {
                if (pazymys.Trimestras != 4)
                {
                    Console.WriteLine($"Trimestro numeris - {pazymys.Trimestras}; pazymys - {pazymys.Pazymys}");
                }
                else
                {
                    Console.WriteLine($"Metinis pazymys - {pazymys.Pazymys}");
                }
            }
        }

        public static void VienasPazymys(PazymiuRepozitorija pazymiuRepozitorija)
        {
            Console.WriteLine("Iveskite studento eiles numeri:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trimestra (1, 2, 3 trimestrai, 4 - metinis pazymys");
            int trimestras = Convert.ToInt32(Console.ReadLine());
            var pazymys = pazymiuRepozitorija.RetrieveGrade(id, trimestras);
            if (pazymys.Trimestras != 4)
            {
                Console.WriteLine($"{pazymys.Trimestras} trimestro studento pazymys - {pazymys.Pazymys}");
            }
            else
            {
                Console.WriteLine($"Metinis studento pazymys - {pazymys.Pazymys}");
            }
        }
    }
}