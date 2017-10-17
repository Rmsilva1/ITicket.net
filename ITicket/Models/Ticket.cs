using ITicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITicket.Models
{
    public class Ticket
    {
        public long TicketID { get; set; }
        public int CodigoTicket { get; set; }
        public DateTime DataImpressao { get; set; }
        public DateTime DataFinalizacao { get; set; }
        public string Anotacao { get; set; }

        //Relação
        public long? EmpresaID { get; set; }

        public Empresa Empresa { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }

    }
}