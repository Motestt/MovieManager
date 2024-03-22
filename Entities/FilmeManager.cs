using Newtonsoft.Json;
using System.IO;



namespace Movie_4._0.Entities
{
    public class FilmeManager
    {



        public static List<Filmes> listFf = new List<Filmes>();



       public static void SalvarFilmes(List<Filmes> filmes, string nomeArquivo)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + "filme.json";

            string jsonAtualizado = JsonConvert.SerializeObject(filmes, Formatting.Indented);
            
            File.WriteAllText(path, jsonAtualizado);

        }

        public static List<Filmes> CarregarFilmes()
        {
            if (!File.Exists("filme.json"))
            {
                return new List<Filmes>();
            }


            string path = AppDomain.CurrentDomain.BaseDirectory + "filme.json";

            string json = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<List<Filmes>>(json);



        } 
    }

}
