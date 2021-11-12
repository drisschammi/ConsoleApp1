using System;
using System.Collections.Generic;

namespace ConsoleApp0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez de saisire le nombre des etudiants ");
            int nbrET = int.Parse(Console.ReadLine());
            string[] Tableaux = new string[nbrET];

            Options ABD = new Options("ABD", 20);
            Options ASR = new Options("ASR", 20);
            Options GL = new Options("GL", 20);

            var liste = new List<Tuple<Etudiant, string, string, string>>();

            for (int i = 0; i < nbrET; i++)
            {
                Console.WriteLine("Veuillez de saisire le nom d'etudiant ");
                string nomET = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Veuillez de saisire le prenom d'etudiant");
                string prenomET = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Veuillez de saisire la note d'etudiant ");
                double noteET = double.Parse(Console.ReadLine());
                Console.WriteLine("Entrez le premier choix");
                string choix1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Entrez le 2eme choix2");
                string choix2 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Entrez le 3eme choix3");
                string choix3 = Convert.ToString(Console.ReadLine());

                Etudiant etudt = new Etudiant(nomET, prenomET, noteET);
                var tuple = Tuple.Create(etudt, choix1, choix2, choix3);
                liste.Add(tuple);
            }
            liste.Sort(delegate (Tuple<Etudiant, string, string, string> etudX, Tuple<Etudiant, string, string, string> etudY)
            {
                return etudY.Item1.noteET.CompareTo(etudX.Item1.noteET);
            });

            for (int i = 0; i < nbrET; i++)
            {
                switch (liste[i].Item2)
                {
                    case "GL":
                        if (GL.placedisponible > 0)
                        {
                            Tableaux[i] = liste[i].Item1.nomET + "  " + liste[i].Item1.prenomET + "  " + "  -->  " + GL.nomoption; --GL.placedisponible;
                        }
                        break;

                    case "ABD":
                        if (ABD.placedisponible > 0)
                        {
                            Tableaux[i] = liste[i].Item1.nomET + "  " + liste[i].Item1.prenomET + "  " + "  " + "  -->  " + ABD.nomoption; --ABD.placedisponible;
                        }
                        break;
                    case "ASR":
                        if (ASR.placedisponible > 0)
                        {
                            Tableaux[i] = liste[i].Item1.nomET + "  " + liste[i].Item1.prenomET + "  " + "  " + "  -->  " + ASR.nomoption; --ASR.placedisponible;
                        }
                        break;
                }
                if (Tableaux[i] == null)
                {
                    switch (liste[i].Item3)
                    {
                        case "GL":
                            if (GL.placedisponible > 0)
                            {
                                Tableaux[i] = liste[i].Item1.nomET + "  " + liste[i].Item1.prenomET + "  " + "  " + "  -->  " + GL.nomoption; --GL.placedisponible;
                            }
                            break;
                        case "ABD":
                            if (ABD.placedisponible > 0)
                            {
                                Tableaux[i] = liste[i].Item1.nomET + "  " + liste[i].Item1.prenomET + "  " + "  " + "  -->  " + ABD.nomoption; --ABD.placedisponible;
                            }
                            break;
                        case "ASR":
                            if (ASR.placedisponible > 0)
                            {
                                Tableaux[i] = liste[i].Item1.nomET + "  " + liste[i].Item1.prenomET + "  " + "  " + "  -->  " + ASR.nomoption; --ASR.placedisponible;
                            }
                            break;
                    }
                }
            }
            Console.WriteLine("La liste des etudiants avec affectation des options  : ");
            Console.WriteLine("Nom   Prenom  option");
            Console.Write("\n");
            for (int i = 0; i < nbrET; i++)
            {
                Console.Write(Tableaux[i] + "\t");
                Console.Write("\n");
            }
        }
    }
}
