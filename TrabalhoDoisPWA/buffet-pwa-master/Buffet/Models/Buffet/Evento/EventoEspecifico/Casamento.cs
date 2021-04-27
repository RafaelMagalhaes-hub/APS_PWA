using Buffet.Models.Buffet.Evento.Situacao;
using Buffet.Models.Buffet.Localizacao;
using Buffet.Models.Evento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Buffet.Evento
{
    public class Casamento: EventoGenerico
    {
        public DateTime Inicio { get; set; }

        public DateTime Termino { get; set; }

        public Local Local { get; set; }

        public string Observacoes { get; set; }

        public DateTime Insercao { get; set; }

        public DateTime Modificacao { get; set; }

        public SituacaoGeralEvento situacao { get; set; }

        public Casamento()
        {
        }

        public Casamento(string descricao, DateTime novoInicio, DateTime novoTermino, Local novoLocal, string novasObservacoes, DateTime momentoInsercao, DateTime novaModificacao, SituacaoGeralEvento novaSituacao) : base(descricao)
        {
            Inicio = novoInicio;
            Termino = novoTermino;
            Local = novoLocal;
            Observacoes = novasObservacoes;
            Insercao = momentoInsercao;
            Modificacao = novaModificacao;
            situacao = novaSituacao;
        }

    }




}
