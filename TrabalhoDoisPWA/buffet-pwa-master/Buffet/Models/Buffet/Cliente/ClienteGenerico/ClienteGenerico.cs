using System;
using System.Collections;
using System.Collections.Generic;
using Buffet.Models.Buffet.Evento;

namespace Buffet.Models.Evento
{
    //Coloquei a entidade de domínio Tipo Cliente como ClienteGenerico
    public abstract class ClienteGenerico
    {
        public Guid idCli { get; set; }
        public string descricaoCli { get; set; }
        public List<EventoGenerico>listaEventosContratados { get; set; }
        public ClienteGenerico(string novaDescricaoCli)
        {
            listaEventosContratados = new List<EventoGenerico>();
            idCli = new Guid();            
            descricaoCli = novaDescricaoCli;
        }

        public ClienteGenerico()
        {
            listaEventosContratados = new List<EventoGenerico>();
            idCli = new Guid();            
        }
    }
}