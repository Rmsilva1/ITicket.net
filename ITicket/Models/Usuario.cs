using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITicket.Models
{
    public class Usuario
    {
        private long UsuarioID { get; set; }
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Senha { get; set; }
        private string Telefone { get; set; }
        private string Ticket { get; set; }
    }
}