using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json;
using System.IO;

namespace Movie_4._0.Entities
{
    public class Filmes
    {

        public string Name { get; set; }
        public string Year { get; set; }
        public string Dur { get; set; }
        public double Score { get; set; }

        


        public Filmes(string name, string year, string dur, double score)
        {
            Name = name;
            Year = year;
            Dur = dur;
            Score = score;
        }

        



        public override string ToString()
        {
            return "nome: "
            + Name + "\n"
            + "Ano: "
            + Year + "\n"
            + "Duração: "
            + Dur + "\n"
            + "Nota: "
            + Score;



        }




    }
}
