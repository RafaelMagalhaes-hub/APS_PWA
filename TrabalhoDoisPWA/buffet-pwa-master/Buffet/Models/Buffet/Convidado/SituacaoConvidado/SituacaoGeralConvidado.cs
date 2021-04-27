using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Buffet.Convidado.Situacao
{
    public enum SituacaoConvidadoOpcoesGerais
    {
        confirmado,
        cancelado,
        emDuvida,
        outros
    }
    public class SituacaoGeralConvidado: SituacaoConvidado
    {
        public SituacaoConvidadoOpcoesGerais opcaoGeral { get; set; }

        public SituacaoGeralConvidado(SituacaoConvidadoOpcoesGerais opcaoGeralEscolhida) :base()
        {
            opcaoGeral = opcaoGeralEscolhida;
        }

        public SituacaoGeralConvidado(string descricao, SituacaoConvidadoOpcoesGerais opcaoGeralEscolhida) : base(descricao) 
        {
            opcaoGeral = opcaoGeralEscolhida;
        }

    }
}