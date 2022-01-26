using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjectos.Entities
{
    abstract class Personagem
    {
        public string nome { get; set; }
        public int level { get; set; }

        public Personagem(string nome, int level)
        {
            this.nome = nome;
            this.level = level;
        }

        public virtual string Atacar()
        {
            return "";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
