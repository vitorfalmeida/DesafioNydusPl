using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DataBase;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class HistoricoCargoRepository
    {
        private NydusDBContext _context;

        public HistoricoCargoRepository()
        {
            _context = new NydusDBContext();
        }

        public List<HistoricoCargo> ObterHistoricoCargosPorColaborador(int colaboradorId)
        {
            return _context.HistoricoCargos
                .Where(hc => hc.ColaboradorId == colaboradorId)
                .ToList();
        }

        public void InserirHistoricoCargo(HistoricoCargo historicoCargo)
        {
            _context.HistoricoCargos.Add(historicoCargo);
            _context.SaveChanges();
        }
    }
}