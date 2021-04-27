using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Buffet.Evento.Situacao
{
    //Coloquei essa classe para representar a Situação Evento
    public abstract class SituacaoEvento
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }

        public SituacaoEvento() 
        {
            Id = new Guid();
        }

        public SituacaoEvento(string novaDescricao)
        {
            Id = new Guid();
            Descricao = novaDescricao;
        }

    }
}
