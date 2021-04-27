using System;
using Microsoft.AspNetCore.Identity;

namespace Buffet.Models.Acesso
{
    public class Usuario : IdentityUser<Guid>
    {
        public string Apelido { get; set; }


        public Usuario(String apelido) {
            this.Apelido = apelido;
        }

        public Usuario() { 
        }
    }


}