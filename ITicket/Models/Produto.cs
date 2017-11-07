using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITicket.Models
{
    public class Produto
    {
        public long ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        [DataType(DataType.Currency)]
        public double Preco { get; set; }
        public long? EmpresaID { get; set;}
        public Empresa Empresa { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

    }
}