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
    public class VendaBLL
    {
        VendaDAO vendaDAO = new VendaDAO();

        public void salvar(Venda venda)
        {
            try
            {
                vendaDAO.salvar(venda);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public void excluir(int id)
        {
            try
            {
                vendaDAO.excluir(id);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void consulta(DataGridView dataGridView)
        {
            try
            {
                vendaDAO.consulta(dataGridView);
            }
            catch
            {

            }
        }
    }
}