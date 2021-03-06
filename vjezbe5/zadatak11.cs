﻿using System;

namespace vjezbe5
{ 
    class zadatak
    {
        static int NajveciElement(int[] niz)
        {
            int max = niz[0];
            for (int i = 1; i < niz.Length; i++)
                if (niz[i] > max)
                    max = niz[i];
            return max;
        }
        static int NajmanjiElement(int[] niz)
        {
            int min = niz[0];
            for (int i = 1; i < niz.Length; i++)
                if (niz[i] < min)
                    min = niz[i];
            return min;
        }
        static double ProsjekOcjena(int[] niz)
        {
            double suma = 0;
            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] == 5)
                    return 5.00;
                suma += niz[i];
            }
            return suma / niz.Length;
        }
        static void Main(string[] args)
        {
            int[] niz = new int[6];
            Console.WriteLine("Unesite ime i prezime studenta:");
            Console.Write("ime studenta - ");
            string ime = Console.ReadLine();
            Console.Write("prezime studenta - ");
            string prezime = Console.ReadLine();
            Console.WriteLine("\nUnesite 6 ocjena studenta");
            for (int i = 0; i < 6; i++)
                niz[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nStudent {0} {1} je postigao/la sljedece rezultate:\n", ime, prezime);
            Console.WriteLine("\t- najmanja osvojena ocjena je " + NajmanjiElement(niz));
            Console.WriteLine("\t- najveca osvojena ocjena je " + NajveciElement(niz));
            Console.WriteLine("\t- prosjek svih ocjena je " + Math.Round(ProsjekOcjena(niz), 1));
        }
    }
}