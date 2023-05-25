using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class HistoricoCargo
    {
        public int HistoricoCargoId { get; set; }
        public int ColaboradorId { get; set; }
        public int CargoId { get; set; }
        public DateTime DataInicio { get; set; }
    }

}