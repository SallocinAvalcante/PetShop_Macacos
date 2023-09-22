using System;

namespace Clinica_de_Macacos
{
    class Animal
    {
        //Atributos
        private String Nome;
        private int Idade;
        private String RGA;
        private String Especie;
        private String Raça;
        private Char Exotico;
        private Char Sexo;


        //Metodos Construtores

        public Animal(String p_nm, int p_id, String p_rga, String p_esp, String p_rç, Char p_ex, Char p_sx)
        {
            this.Nome = p_nm;
            this.Idade = p_id;
            this.RGA = p_rga;
            this.Especie = p_esp;
            this.Raça = p_rç;
            this.Exotico = p_ex;
            this.Sexo = p_sx;

        }

        //Metódos Get/Set


        //Get
        public String GetNome()
        {
            return this.Nome;

        }

        public int GetIdade()
        {
            return this.Idade;
        }

        public String GetRGA()
        {
            return this.RGA;
        }
        public String GetEspecie()
        {
            return this.Especie;
        }
        public String GetRaca()
        {
            return this.Raça;
        }
        public Char GetExotico()
        {
            return this.Exotico;
        }
        public Char GetSexo()
        {
            return this.Sexo;
        }

        //Set

        public void SetNome(String nm)
        {
            this.Nome = nm;
        }

        public void SetIdade(int id)
        {
            this.Idade = id;
        }

        public void SetRGA(String rg)
        {
            this.RGA = rg;
        }

        public void SetEspecie(String es)
        {
            this.Especie = es;
        }
        public void SetRaça(String rç)
        {
            this.Raça = rç;
        }
        public void SetExotico(Char ex)
        {
            this.Exotico = ex;
        }
        public void SetSexo(Char sx)
        {
            this.Sexo = sx;
        }


    }
}
