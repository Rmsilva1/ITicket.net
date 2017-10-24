using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITicket.Models
{
    public class UsuarioViewModel : Usuario
    {
        public string SenhaConfirmacao { get; set; }

        public Boolean confirmarSenhasIguais()
        {
            return Senha.Equals(SenhaConfirmacao);
        }
    }
}