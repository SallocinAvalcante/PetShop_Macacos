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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadCliente cliente = new FrmCadCliente(); // Criando a nossa instancia do obj

            //Configuração das aparecencias, DockStyle é onde ele preenche
            cliente.TopLevel = false;
            cliente.Dock = DockStyle.Fill;
            //Limpamos nosso forms
          PanelCenter.Controls.Clear();
           // Add o form
            PanelCenter.Controls.Add(cliente); 
            cliente.Show();

            BtnCliente.BackColor = Color.GreenYellow;
            BtnInicio.BackColor = Color.Transparent;
            BtnPClientes.BackColor = Color.Transparent;
            BtnCadPet.BackColor = Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            AnimalCad Cad = new AnimalCad(); // Criando a nossa instancia do obj

            //Configuração das aparecencias, DockStyle é onde ele preenche
            Cad.TopLevel = false;
            Cad.Dock = DockStyle.Fill;
            //Limpamos nosso forms
   
            PanelCenter.Controls.Clear();
            // Add o form
            PanelCenter.Controls.Add(Cad);
            Cad.Show();

            BtnCadPet.BackColor = Color.GreenYellow;
            BtnInicio.BackColor = Color.Transparent;
            BtnCliente.BackColor = Color.Transparent;
            BtnPClientes.BackColor = Color.Transparent;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            PrincipaisClientes CLI = new PrincipaisClientes(); // Criando a nossa instancia do obj

            //Configuração das aparecencias, DockStyle é onde ele preenche
            CLI.TopLevel = false;
            CLI.Dock = DockStyle.Fill;
            //Limpamos nosso forms

            PanelCenter.Controls.Clear();
            // Add o form
            PanelCenter.Controls.Add(CLI);
            CLI.Show();

            BtnCadPet.BackColor = Color.Transparent;
            BtnInicio.BackColor = Color.Transparent;
            BtnCliente.BackColor = Color.Transparent;
            BtnPClientes.BackColor = Color.GreenYellow;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair", "Macacos Lindos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            PanelCenter.Controls.Clear();
            BtnCliente.BackColor = Color.Transparent;
            BtnInicio.BackColor = Color.GreenYellow;
            BtnPClientes.BackColor = Color.Transparent;
            BtnCadPet.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
