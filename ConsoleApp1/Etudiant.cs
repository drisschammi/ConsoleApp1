using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp0
{
    class Etudiant
    {
        public string nomET;
        public string prenomET;
        public double noteET;

        public Etudiant(string nome, string pren, double note1année)
        {
            this.nomET = nome;
            this.prenomET = pren;
            this.noteET = note1année;
        }
    }
}
