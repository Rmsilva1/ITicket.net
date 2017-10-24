using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITicket.Models
{
    public class UsuarioViewModel : Usuario
    {
        [Required]
        public string SenhaConfirmacao { get; set; }

        public Boolean confirmarSenhasIguais()
        {
            if (Senha == null)
            {
                Senha = " ";
            }
            return Senha.Equals(SenhaConfirmacao);
        }
    }
}