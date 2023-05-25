using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.DataBase;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
  

    public class ColaboradorRepository
    {
        private NydusDBContext _context;

        public ColaboradorRepository()
        {
            _context = new NydusDBContext();
        }

        public List<Colaborador> ObterColaboradores()
        {
            return _context.Colaboradores.ToList();
        }

        public Colaborador ObterColaboradorPorId(int id)
        {
            return _context.Colaboradores.Find(id);
        }

        public void InserirColaborador(Colaborador colaborador)
        {
            _context.Colaboradores.Add(colaborador);
            _context.SaveChanges();
        }

        public void AtualizarColaborador(Colaborador colaborador)
        {
            _context.Entry(colaborador).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void ExcluirColaborador(int id)
        {
            var colaborador = _context.Colaboradores.Find(id);
            if (colaborador != null)
            {
                _context.Colaboradores.Remove(colaborador);
                _context.SaveChanges();
            }
        }
    }

}