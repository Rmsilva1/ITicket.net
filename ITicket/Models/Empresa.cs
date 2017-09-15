using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITicket.Models
{
    public class Empresa
    {
        private long EmpresaID { get; set; }
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Senha { get; set; }
        private int Cnpj { get; set; }
        private string Telefone { get; set; }
        private string Logradouro { get; set; }
        private string Endereco { get; set; }
        private string Setor { get; set; }
        private string Produto { get; set; }
    }
}