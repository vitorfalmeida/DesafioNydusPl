using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.DataBase;
using WebApplication1.Models;

namespace WebApplication1.Repository
{


    public class EmpresaRepository
    {
        private NydusDBContext _context;

        public EmpresaRepository()
        {
            _context = new NydusDBContext();
        }

        public List<Empresa> ObterEmpresas()
        {
            return _context.Empresas.ToList();
        }

        public Empresa ObterEmpresaPorId(int id)
        {
            return _context.Empresas.Find(id);
        }

        public void InserirEmpresa(Empresa empresa)
        {
            _context.Empresas.Add(empresa);
            _context.SaveChanges();
        }

        public void AtualizarEmpresa(Empresa empresa)
        {
            _context.Entry(empresa).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void ExcluirEmpresa(int id)
        {
            var empresa = _context.Empresas.Find(id);
            if (empresa != null)
            {
                _context.Empresas.Remove(empresa);
                _context.SaveChanges();
            }
        }
    }
}