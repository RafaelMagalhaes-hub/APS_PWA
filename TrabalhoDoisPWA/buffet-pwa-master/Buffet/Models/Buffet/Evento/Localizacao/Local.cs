using Buffet.Models.Buffet.Evento.Localizacao.Endereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Buffet.Localizacao
{
    public class Local
    {
        public string descricao { get; set; }
        public Endereco endereco { get; set; }

        public Local()
        {
        }

        public Local(string novaDescricao, Endereco novoEndereco)
        {
            descricao = novaDescricao;
            endereco = novoEndereco;
        }

    }

}