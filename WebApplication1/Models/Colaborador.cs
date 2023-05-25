using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Colaborador
    {
        public int ColaboradorId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime? DataDemissao { get; set; }
    }

}