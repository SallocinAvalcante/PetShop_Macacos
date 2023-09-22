using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_de_Macacos
{
    public partial class AnimalCad : Form
    {
        public AnimalCad()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void NEXT1_Click(object sender, EventArgs e)
        {
            try
            {

                Animal AC = new Animal(textBox1.Text, int.Parse(textBox2.Text), textBox3.Text, textBox4.Text, textBox5.Text, Char.Parse(textBox61.Text), Char.Parse(textBox71.Text));
                MySqlConnection conexao = new MySqlConnection("server=localhost; database=banco; user id=root; password=''");
                MySqlCommand sql_Inst = new MySqlCommand("INSERT INTO Animal (Nome, Idade, RGA, Especie, Raça, Exotico, Sexo) " 
                    + "VALUES ('" + AC.GetNome() + "'," +
                               " " + AC.GetIdade() + "," +
                               " '" + AC.GetRGA() + "', " +
                               "'" + AC.GetEspecie() + "'," +
                               " '" + AC.GetRaca() + "'," +
                               " '" + AC.GetExotico() + "'," +
                               " '" +AC.GetSexo()+"')", conexao);

              

                //BD
                try
                {

                    conexao.Open();
                    sql_Inst.ExecuteNonQuery();
                    MessageBox.Show("Dados Armazenados!", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                catch (Exception error)
                {
                    MessageBox.Show("ERRO:" + error);
                }
                conexao.Close();

            }


            catch (Exception error)
            {
                MessageBox.Show("ERRO:" + error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
