using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.DataBase;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class CargoRepository
    {
        private NydusDBContext _context;

        public CargoRepository()
        {
            _context = new NydusDBContext();
        }

        public List<Cargo> ObterCargos()
        {
            return _context.Cargos.ToList();
        }

        public Cargo ObterCargoPorId(int id)
        {
            return _context.Cargos.Find(id);
        }

        public void InserirCargo(Cargo cargo)
        {
            _context.Cargos.Add(cargo);
            _context.SaveChanges();
        }

        public void AtualizarCargo(Cargo cargo)
        {
            _context.Entry(cargo).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void ExcluirCargo(int id)
        {
            var cargo = _context.Cargos.Find(id);
            if (cargo != null)
            {
                _context.Cargos.Remove(cargo);
                _context.SaveChanges();
            }
        }
    }
}