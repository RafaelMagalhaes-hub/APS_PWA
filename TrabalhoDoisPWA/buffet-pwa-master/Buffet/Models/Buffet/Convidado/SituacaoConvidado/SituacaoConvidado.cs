using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Buffet.Convidado
{
    //Coloquei essa classe para representar a Situação Convidado
    public abstract class SituacaoConvidado
    {
        public Guid Id { get; set; }
        public string descricao { get; set; }

        public SituacaoConvidado()
        {
            Id = new Guid();
        }

        public SituacaoConvidado(string novaDescricao)
        {
            Id = new Guid();
            descricao = novaDescricao;
        }

    }
}