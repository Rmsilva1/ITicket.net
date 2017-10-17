using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITicket.Models
{
    public class Usuario
    {
        public long UsuarioID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }

        //Relação
        public long? ticketID { get; set; } 

        public Ticket Ticket { get; set; }
    }
}