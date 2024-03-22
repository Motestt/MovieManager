using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Movie_4._0.Entities
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string pesquisa;
        double avaliar;

        private void button1_Click(object sender, EventArgs e)
        {
            //dessealizar


            List<Filmes> filmes = FilmeManager.CarregarFilmes();
            

            //textbox
            pesquisa = this.textBox1.Text;

            Filmes search = filmes.Find(x => x.Name == this.pesquisa);

            MessageBox.Show("Filme:" + search.Name);





        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Desserializar


            List<Filmes> filmes = FilmeManager.CarregarFilmes();

           

            

            //avaliar

            avaliar = double.Parse(this.textBox2.Text, CultureInfo.InvariantCulture);


            Filmes search1 = filmes.Find(x => x.Name == this.pesquisa);

            if (search1.Score == 0.14567)
            {
                // Atualiza a nota do filme
                search1.Score = avaliar;
                filmes.RemoveAll(x => x.Name == this.pesquisa);
                filmes.Add(search1);

                //atualizando lista

                FilmeManager.SalvarFilmes(filmes, "filme.json");
                

                MessageBox.Show("Avaliado!");
            }
            else
            {
                MessageBox.Show("Esse Filme ja tem uma nota!");
            }







        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
