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
    public class ProdutoBLL
    {
        ProdutoDAO produtoDAO = new ProdutoDAO();

        public void salvar(Produto produto)
        {
            try
            {
                produtoDAO.salvar(produto);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public void excluir(int codigo)
        {
            try
            {
                produtoDAO.excluir(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void alterar (Produto produto, int id)
        {
            try
            {
                produtoDAO.alterar(produto,id);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public Produto consultarProduto (String nomeProduto)
        {
            try
            {
                return produtoDAO.consultarProduto(nomeProduto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}