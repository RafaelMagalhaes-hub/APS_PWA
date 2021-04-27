using Buffet.Models.Buffet.Evento.Localizacao.Endereco;
using Buffet.Models.Evento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Buffet.Cliente
{
    public class ClientePJ: ClienteGenerico
    {
        public string cnpj { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string observacoes { get; set; }
        public DateTime insercao { get; set; }
        public DateTime modificacao { get; set; }
        public Endereco enderecoCliPJ { get; set; }

        public ClientePJ() : base() 
        { 
        }

        public ClientePJ(string descricao, string novoCNPJ,string novoNome,string novoEmail,string novaObservacao,DateTime momentoInsercao,DateTime novaModificacao,Endereco novoEndereco):base(descricao)
        {
            cnpj = novoCNPJ;
            nome = novoNome;
            email = novoEmail;
            observacoes = novaObservacao;
            insercao = momentoInsercao;
            modificacao = novaModificacao;
            enderecoCliPJ = novoEndereco;
        }

    }
}