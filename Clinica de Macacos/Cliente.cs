using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_de_Macacos
{
   public class Cliente
    {
       

        //Atributos 
        private String Nome;
        private int Idade;
        private int CPF;
        


        //Metodo Construtor :
        public Cliente(String p_nm, int p_id, int p_cp)
        {
            this.Nome = p_nm;
            this.Idade = p_id;
            this.CPF = p_cp;
        }


        //Metodos para uso:

        //Sets
        public void SetNome (String nm)
        {
            this.Nome = nm;
        }

        public void SetIdade(int id)
        {
            this.Idade = id;
        }

        public void SetCpf(int cp)
        {
            this.CPF = cp;
        }


        //Gets

        public String GetNome()
        {
            return this.Nome;

        }

        public int GetIdade()
        {
            return this.Idade;
        }

        public int GetCPF()
        {
            return this.CPF;
        }

      

        //Fim dos metodos de Uso deste forms


    }
}
