using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjectos.Entities
{
    class Mago : Personagem
    {
        public Mago(string nome, int level) : base(nome, level)
        {
        }

        public override string Atacar()
        {
            return this.nome + "jogou mágia";
        }
    }
}
