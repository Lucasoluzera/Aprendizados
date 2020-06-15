using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia_Toledo.DAO;
using Farmacia_Toledo.Model;
using MySql.Data.MySqlClient;

namespace Farmacia_Toledo.BLL
{
    public class ConsultaDashboardBLL
    {
        ConsultaDashboardDAO consultaDashboardDAO = new ConsultaDashboardDAO();
        public int consultaVendasNoMes()
        {
            try
            {
                DateTime now = DateTime.Now;
                var startDate = new DateTime(now.Year, now.Month, 1);
                DateTime oDate = Convert.ToDateTime(startDate);
                return consultaDashboardDAO.consultaVendasMes(oDate);
            }
            catch
            {
                return 0;
            }
        }
        public double consultaVendasNoMesDinheiro()
        {
            try
            {
                DateTime now = DateTime.Now;
                var startDate = new DateTime(now.Year, now.Month, 1);
                DateTime oDate = Convert.ToDateTime(startDate);
                return consultaDashboardDAO.consultaVendasMesDinheiro(oDate);
            }
            catch
            {
                return 0;
            }
        }
        public UsuarioMesDTO consultaFuncionarioMes()
        {
            try
            {
                DateTime now = DateTime.Now;
                var startDate = new DateTime(now.Year, now.Month, 1);
                DateTime oDate = Convert.ToDateTime(startDate);
                return consultaDashboardDAO.consultaFuncionarioMes(oDate);
            }
            catch
            {
                return null;
            }
        }
        public ProdutoDTO consultaProdutoMes()
        {
            try
            {
                DateTime now = DateTime.Now;
                var startDate = new DateTime(now.Year, now.Month, 1);
                DateTime oDate = Convert.ToDateTime(startDate);
                return consultaDashboardDAO.consultaProdutoMes(oDate);
            }
            catch
            {
                return null;
            }
        }
    }
}