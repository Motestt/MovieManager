using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.DataContracts;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_4._0.Entities
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Desserialize o JSON para um objeto Filme


            List<Filmes> filmes = FilmeManager.CarregarFilmes();

            List<Filmes> FilmesNa = filmes.FindAll(x => x.Score == 0.14567);

            int SSort = FilmesNa.Count;

            //numero aleatorio

            Random randNum = new Random();
            int randomNumber = randNum.Next(SSort);


            if (FilmesNa[randomNumber] == null)
            {
                //MessageBox 1
                MessageBox.Show("O Filmes acabaram, Adicione mais filmes a lista!");
            }
            else
            { 
                //MessageBox 2
                MessageBox.Show(FilmesNa[randomNumber].ToString());
            }

                


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
