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
    public class UsuarioBLL
    {
        UsuarioDAO UsuarioDAO = new UsuarioDAO();

        public void salvar(Usuario usuario)
        {
            try
            {
                UsuarioDAO.salvar(usuario);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
        
        public void alterar(Usuario usuario, int id)
        {
            try
            {
                UsuarioDAO.alterar(usuario, id);
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
                UsuarioDAO.excluir(id);
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
                UsuarioDAO.consulta(dataGridView);
            }
            catch
            {

            }
        }

        public bool login(Usuario usuario)
        {
            try
            {
                return UsuarioDAO.login(usuario);
            }
            catch(Exception err)
            {
                throw err;
            }
        }

        public bool validarUsuario(String nomeUsuario)
        {
            try
            {
                return UsuarioDAO.validarUsuario(nomeUsuario);
            }
            catch(Exception err)
            {
                throw err;
            }
        }
    }
}