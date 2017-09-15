using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITicket.Models
{
    public class Produto
    {
        private long ProdutoID { get; set; }
        private string Nome { get; set; }
        private string Descricao { get; set; }
        private double Preco { get; set; }
    }
}