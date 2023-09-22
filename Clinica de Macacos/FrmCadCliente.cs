using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace Clinica_de_Macacos
{
    public partial class FrmCadCliente : Form
    {
        public FrmCadCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

                Cliente CL = new Cliente(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                Endereço Edr = new Endereço(textBox4.Text, int.Parse(textBox5.Text), (textBox6.Text), int.Parse(textBox7.Text));



                MySqlConnection conexao = new MySqlConnection("server=localhost; user id=root; database=banco; password=''");

                MySqlCommand sql_Inst = new MySqlCommand("INSERT INTO banco.cliente(Nome, Idade, Cpf, Rua, Bairro, Numero, Cep)" +
                 "VALUES ('" + CL.GetNome() + "'," +
                         " " + CL.GetIdade() + "," +
                         " " + CL.GetCPF() + "," +
                         " '" + Edr.GetRua() + "'," +
                         " '" + Edr.GetBairro() + "'," +
                         " " + Edr.GetNumero() + "," +
                         " " + Edr.GetCep() + " )", conexao);


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

            catch (Exception ex)
            {
                MessageBox.Show("ERRO:" + ex);
            }




            //BD



        }
    }
}

