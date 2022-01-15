﻿using System;
using Baigiamasis_Darbas__Studentu_Dienynas_;
using Baigiamasis_Darbas__Studentu_Dienynas_.Repozitorijos;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {

                    Console.WriteLine("1 - perziureti pazymius, 2 - redaguoti pazymius, 3 - perziureti studentu sarasa, 4 - redaguoti studentu sarasa");
                    int pasirinkimas = Convert.ToInt32(Console.ReadLine());
                    switch (pasirinkimas)
                    {
                        case 1:
                            PerziuretiPazymiusMeniu();
                            break;
                        case 2:
                            RedaguotiPazymiusMeniu();
                            break;
                        case 3:
                            PerziuretiStudentuSarasa();
                            break;
                        case 4:
                            RedaguotiStudentuSarasa();
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

        public static void RedaguotiStudentuSarasa()
        {
            Console.WriteLine("Pasirinkite veiksma:");
            Console.WriteLine("1 - prideti studenta, 2 - istrinti studenta, 3 - keisti studento varda");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    PridetiStudenta();
                    break;
                case 2:
                    IstrintiStudenta();
                    break;
                case 3:
                    KeistiStudentoVarda();
                    break;
                default:
                    Console.WriteLine("Negalimas pasirinkimas");
                    break;
            }
        }

        public static void PridetiStudenta()
        {
            Console.WriteLine("Iveskite studento ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite studento varda:");
            string vardas = Console.ReadLine();
            var studentuRepo = new StudentuRepozitorija();
            studentuRepo.AddNewStudent(id, vardas);
        }

        public static void IstrintiStudenta()
        {
            Console.WriteLine("Iveskite studento ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite studento varda:");
            string vardas = Console.ReadLine();
            var studentuRepo = new StudentuRepozitorija();
            studentuRepo.RemoveStudent(id, vardas);
        }

        public static void KeistiStudentoVarda()
        {
            Console.WriteLine("Iveskite studento ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite studento varda:");
            string vardas = Console.ReadLine();
            var studentuRepo = new StudentuRepozitorija();
            studentuRepo.EditStudent(id, vardas);
        }

        public static void PerziuretiStudentuSarasa()
        {
            var studentuRepo = new StudentuRepozitorija();
            var visiStudentai = studentuRepo.Retrieve();
            foreach (var studentas in visiStudentai)
            {
                Console.WriteLine($"Studento ID - {studentas.ID}, studento vardas - {studentas.Vardas}");
            }
        }

        public static void PerziuretiPazymiusMeniu()
        {
            Console.WriteLine("Pasirinkite ka norite perziureti:");
            Console.WriteLine("1 - visu studentu trimestro pazymiai, 2 - visi vieno studento pazymiai, 3 - studento vieno trimestro pazymys");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    VisiStudentaiTrimestras();
                    break;
                case 2:
                    VienoStudentoPazymiai();
                    break;
                case 3:
                    VienasPazymys();
                    break;
                default:
                    Console.WriteLine("Negalimas pasirinkimas");
                    break;
            }
        }

        public static void RedaguotiPazymiusMeniu()
        {
            Console.WriteLine("Pasirinkite ka norite redaguoti:");
            Console.WriteLine("1 - redaguoti pazymi, 2 - prideti pazymi, 3 - istrinti pazymi");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    RedaguotiPazymi();
                    break;
                case 2:
                    PridetiPazymi();
                    break;
                case 3:
                    IstrintiPazymi();
                    break;
                default:
                    Console.WriteLine("Negalimas pasirinkimas");
                    break;
            }
        }

        public static void RedaguotiPazymi()
        {
            Console.WriteLine("Iveskite studento ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pazymio trimestro numeri (4 - metinis pazymys):");
            int trimestras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite nauja pazymi:");
            int pazymys = Convert.ToInt32(Console.ReadLine());
            var pazymiuRepo = new PazymiuRepozitorija();
            pazymiuRepo.EditGrade(id, trimestras, pazymys);
        }

        public static void PridetiPazymi()
        {
            Console.WriteLine("Iveskite studento ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pazymio trimestro numeri (4 - metinis pazymys):");
            int trimestras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pazymi, kuri norite prideti:");
            int pazymys = Convert.ToInt32(Console.ReadLine());
            var pazymiuRepo = new PazymiuRepozitorija();
            pazymiuRepo.AddGrade(id, trimestras, pazymys);
        }

        public static void IstrintiPazymi()
        {
            Console.WriteLine("Iveskite studento ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trinamo pazymio trimestro numeri (4 - metinis pazymys):");
            int trimestras = Convert.ToInt32(Console.ReadLine());
            var pazymiuRepo = new PazymiuRepozitorija();
            pazymiuRepo.RemoveGrade(id, trimestras);
        }

        public static void VisiStudentaiTrimestras()
        {
            Console.WriteLine("Pasirinkite trimestra:");
            Console.WriteLine("1 - I trimestras, 2 - II trimestras, 3 - III trimestras, 4 - metiniai pazymiai");
            int trimestras = Convert.ToInt32(Console.ReadLine());
            var pazymiuRepo = new PazymiuRepozitorija();
            var pazymiaiPagalTrimestra = pazymiuRepo.RetrieveAllGradesForTerm(trimestras);

            foreach(var pazymys in pazymiaiPagalTrimestra)
            {
                Console.WriteLine($"Studento eiles numeris - {pazymys.Id}; trimestro pazymys - {pazymys.Pazymys}");
            }
        }

        public static void VienoStudentoPazymiai()
        {
            Console.WriteLine("Iveskite studento eiles numeri");
            int id = Convert.ToInt32(Console.ReadLine());
            var pazymiuRepo = new PazymiuRepozitorija();
            var pazymiaiPagalStudenta = pazymiuRepo.RetrieveAllGradesForStudent(id);

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

        public static void VienasPazymys()
        {
            Console.WriteLine("Iveskite studento eiles numeri:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trimestra (1, 2, 3 trimestrai, 4 - metinis pazymys");
            int trimestras = Convert.ToInt32(Console.ReadLine());
            var pazymiuRepo = new PazymiuRepozitorija();
            var pazymys = pazymiuRepo.RetrieveGrade(id, trimestras);
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