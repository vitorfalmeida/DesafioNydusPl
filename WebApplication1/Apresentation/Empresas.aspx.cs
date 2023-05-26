using System;
using System.Web.UI;
using WebApplication1.Repository;

namespace UI
{
    public partial class Empresas : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindEmpresas();
            }
        }

        private void BindEmpresas()
        {
            // Aqui você pode utilizar o repositório para obter os dados das empresas
            EmpresaRepository empresaRepository = new EmpresaRepository();
            var empresas = empresaRepository.ObterEmpresas();

            gridEmpresas.DataSource = empresas;
            gridEmpresas.DataBind();
        }
    }
}
