using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_de_Avaliação_DaianeFarias
{
    public class Aluno
    {
        // Auto-Property
        public string Turma { get; set; }
        public byte Numero { get; set; }
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public double Nota { get; set; }

        // Construtor sem parâmetros

        public Aluno() { }

        // Construtor com parâmetros

        public Aluno (string trm, string nom, int cod, double nota)
        {
            Turma= trm;
            Nome= nom;
            Codigo= cod;    
            Nota= nota; 
        }
    }
}
