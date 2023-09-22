using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_de_Macacos
{
    class Endereço
    {
        private String Rua;
        private int Numero;
        private String Bairro;
        private int Cep;

        //Construtor

        public Endereço(String p_r, int p_num, String p_br, int p_cp)
        {
            this.Rua = p_r;
            this.Numero = p_num;
            this.Bairro = p_br;
            this.Cep = p_cp;
        }


        //GET E SET

        //GET

        public String GetRua ()
        {
            return this.Rua;
        }

        public int GetNumero ()
        {
            return this.Numero;
        }

        public String GetBairro ()
        {
            return this.Bairro;
        }

        public int GetCep()
        {
            return this.Cep;
        }

        //Set

        public void SetRua (String r)
        {
            this.Rua = r;
        }

        public void SetNum(int n)
        {
            this.Numero = n;
        }
        public void SetBairro (String b)
        {
            this.Bairro = b;
        }
        public void SetCep (int c)
        {
            this.Cep = c;
        }

    }
}

