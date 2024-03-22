using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_4._0.Entities
{
    internal class FilmesS
    {

        public List<Filmes> FilmeSs { get; set; } = new List<Filmes>();


        public FilmesS()
        { 
        }

        public void AddFilmes(Filmes filme)
        {
            FilmeSs.Add(filme);
        }
    }






}
