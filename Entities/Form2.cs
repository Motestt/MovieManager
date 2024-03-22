using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Globalization;


namespace Movie_4._0.Entities
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //variaveis e listas 




        //botão adicionar
        private void button2_Click(object sender, EventArgs e)
        {
            double score1 = 0.14567;
            //textbox 1,2 e 3
            string name = textBox1.Text;
            string year = textBox2.Text;
            string dur = textBox3.Text;
            double score;


            //if else

            if (checkBox1.Checked)
            {
                //checkboc true
                score = score1;

            }
            else
            {
                //textbox false4
                score = double.Parse(textBox41.Text, CultureInfo.InvariantCulture);
            }



            //add lista
            List<Filmes> listF = new List<Filmes>();
            Filmes filme = new Filmes(name, year, dur, score);
            listF.Add(filme);



            //messageBox

            MessageBox.Show("Filme Adcionado!");




            //CARREGAR FILME ()
            List<Filmes> filmes = FilmeManager.CarregarFilmes();

            // Adicionar o novo filme à lista

            filmes.AddRange(listF);

            // Serializar a lista atualizada de filmes para JSON

            FilmeManager.SalvarFilmes(filmes, "filme.json");







        }






        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 

