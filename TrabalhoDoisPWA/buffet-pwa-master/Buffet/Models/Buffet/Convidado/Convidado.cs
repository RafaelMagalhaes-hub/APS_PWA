using Buffet.Models.Buffet.Evento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buffet.Models.Buffet.Convidado.Situacao;
using Buffet.Models.Evento;

namespace Buffet.Models.Buffet.Convidado
{
    public class Convidado
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public DateTime nascimentoConvidado { get; set; }
        public EventoGenerico eventoG { get; set; }
        public string observacoes { get; set; }
        public DateTime insercao { get; set; }
        public DateTime modificacao { get; set; }

        public SituacaoGeralConvidado situacaoConvidado { get; set; }

        public Convidado(string novoNome,string novoEmail,string novoCPF, DateTime nascimento,EventoGenerico evento,string novaObservacao,DateTime momentoInsercao,DateTime novaModificacao,SituacaoGeralConvidado novaSituacao)
        {
            nome = novoNome;
            email = novoEmail;
            cpf = novoCPF;
            nascimentoConvidado = nascimento;
            eventoG = evento;
            observacoes = novaObservacao;
            insercao = momentoInsercao;
            modificacao = novaModificacao;
            situacaoConvidado = novaSituacao;
        }
    }
}
