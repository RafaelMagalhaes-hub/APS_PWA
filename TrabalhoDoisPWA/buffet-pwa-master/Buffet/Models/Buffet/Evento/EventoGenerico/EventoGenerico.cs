using System;
using System.Collections.Generic;
using Buffet.Models.Buffet.Cliente;
using Buffet.Models.Buffet.Convidado;

namespace Buffet.Models.Evento
{
    //Coloquei a entidade de domínio Tipo Evento como EventoGenerico
    public class EventoGenerico
    {
        public Guid idEven{ get; set; }
        public string descricaoEven { get; set; }
        public List<Convidado>listaDeConvidados { get; set; }

        public EventoGenerico(string novaDescricao)
        {
            idEven = new Guid();
            descricaoEven = novaDescricao;
        }

        public EventoGenerico()
        {
            idEven = new Guid();
        }

    }
}