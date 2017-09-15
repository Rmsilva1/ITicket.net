using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITicket.Models
{
    public class Ticket
    {
        private long TicketID { get; set; }
        private string NomeEmpresa { get; set; }
        private string EnderecoEmpresa { get; set; }
        private string NomeCliente { get; set; }
        private string Produto { get; set; }
        private DateTime DataImpressao { get; set; }
        private DateTime DataFinalizacao { get; set; }
        private int CodigoTicket { get; set; }
        private string Anotacao { get; set; }
    }
}