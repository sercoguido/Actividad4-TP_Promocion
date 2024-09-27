using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tp_Voucher.Clases
{
    public class Voucher
    {
        public string codigo { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaCanje { get; set; }
        public int idArticulo { get; set; }
    }
}