using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITicket.Models
{
    public class Empresa
    {
        public long EmpresaID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Logradouro { get; set; }
        public string Endereco { get; set; }
        public string Setor { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}