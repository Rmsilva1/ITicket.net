using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITicket.Models
{
    public class Ticket
    {
        public long TicketID { get; set; }
        public string NomeEmpresa { get; set; }
        public string EnderecoEmpresa { get; set; }
        public string NomeCliente { get; set; }
        public string Produto { get; set; }
        public DateTime DataImpressao { get; set; }
        public DateTime DataFinalizacao { get; set; }
        public int CodigoTicket { get; set; }
        public string Anotacao { get; set; }
    }
}