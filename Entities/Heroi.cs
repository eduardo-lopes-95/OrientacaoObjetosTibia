using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjectos.Entities
{
    class Heroi : Personagem
    {
        public Heroi(string nome, int level) : base(nome, level)
        {

        }

        public override string Atacar()
        {
            return this.nome + "ataca com sua espada";
        }
    }
}
