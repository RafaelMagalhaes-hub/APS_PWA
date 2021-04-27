using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Buffet.Evento.Situacao
{
    public enum SituacaoOpcoesGerais
    { 
        agendado,
        cancelado,
        executado,
        outros
    }
    public class SituacaoGeralEvento: SituacaoEvento
    {
        public SituacaoOpcoesGerais escolhaSituacaoGeral { get; set; }

        public SituacaoGeralEvento(SituacaoOpcoesGerais opcaoGeral) : base() 
        {
            escolhaSituacaoGeral = opcaoGeral;
        }
        public SituacaoGeralEvento(string descricao,SituacaoOpcoesGerais opcaoGeral) : base(descricao) 
        {
            escolhaSituacaoGeral = opcaoGeral;
        }

    }
}