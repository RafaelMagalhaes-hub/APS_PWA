using Buffet.Models.Buffet.Evento.Localizacao.Endereco;
using Buffet.Models.Evento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Buffet.Cliente.ClienteEspecifico
{
    public class ClientePF: ClienteGenerico
    {
        public string cpf { get; set; }
        public DateTime nascimento { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string observacoes { get; set; }
        public DateTime insercao { get; set; }
        public DateTime modificacao { get; set; }
        public Endereco enderecoCliPF { get; set; }


        public ClientePF():base()
        {
        }

        public ClientePF(string descricao,string novoCPF,DateTime novaData,string novoNome,string novoEmail, string novaObservacao, DateTime momentoInsercao,DateTime novaModificacao,Endereco novoEndereco):base(descricao)
        {
            cpf = novoCPF;
            nascimento = novaData;
            nome = novoNome;
            email = novoEmail;
            observacoes = novaObservacao;
            insercao = momentoInsercao;
            modificacao = novaModificacao;
            enderecoCliPF = novoEndereco;
        }

    }
}