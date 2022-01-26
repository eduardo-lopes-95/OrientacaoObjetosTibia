using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjectos.Entities
{
    //Abstração carrega comportamentos
    //Interface carrega contratos, não diz o como fazer, mas tem que ter
    class Knight : Personagem
    {
        public Knight(string nome, int level) : base(nome, level)
        {
        }

        public override string Atacar()
        {
            return this.nome + "";
        }
    }
}

