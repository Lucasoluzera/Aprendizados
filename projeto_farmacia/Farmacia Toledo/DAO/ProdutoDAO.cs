using Farmacia_Toledo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Farmacia_Toledo.DAO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Farmacia_Toledo.DAO 
{
    public class ProdutoDAO : Connection
    {
        MySqlCommand sqlCommand = null;
        
        public void salvar(Produto produto)
        {
            try
            {
                openConnection();
                sqlCommand = new MySqlCommand
                    (
                    " INSERT INTO                                       " +
                    "   produto(nome, preco, quantidade)                " +
                    " VALUES                                            " +
                    "   (@nomeProduto, @precoProduto, @quantidade)      ", 
                    strConn
                    );
                
                sqlCommand.Parameters.AddWithValue("@nomeProduto", produto.nomeProduto);    
                sqlCommand.Parameters.AddWithValue("@precoProduto", produto.precoProduto);
                sqlCommand.Parameters.AddWithValue("@quantidade", produto.quantidade);

                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                closeConnection();
            }
        }

        public void excluir(int id)
        {
            try
            {
                openConnection();
                sqlCommand = new MySqlCommand
                    (
                    " DELETE FROM              " +
                    "   produto                " +
                    " WHERE                    " +
                    "   id_produto = @id       ", 
                    strConn
                    );

                sqlCommand.Parameters.AddWithValue("@id", id);

                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                closeConnection();
            }
        }

        public void alterar(Produto produto, int id)
        {
            try
            {
                openConnection();
                sqlCommand = new MySqlCommand
                    (
                    " UPDATE                            " +
                    "   produto                         " +
                    " SET                               " +
                    "   nome = @nome,                   " +
                    "   preco = @precoProduto,          " +
                    "   quantidade = @quantidade        " +
                    " WHERE                             " +
                    "   id_produto = @id                ", 
                    strConn
                    );

                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@precoProduto", produto.precoProduto);
                sqlCommand.Parameters.AddWithValue("@quantidade", produto.quantidade);
                sqlCommand.Parameters.AddWithValue("@nome", produto.nomeProduto);

                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                closeConnection();
            }
        }


        public void consultar(DataGridView dataGridView)
        {
            try
            {
            openConnection();
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand
                (
                " SELECT        " +
                "   *           " +
                " FROM          " +
                "   produto     ", 
                strConn
                );
            MyDA.SelectCommand = command;
            DataSet dataSet = new DataSet();
            MyDA.Fill(dataSet);

            dataGridView.DataSource = dataSet;
            dataGridView.DataMember = dataSet.Tables[0].TableName;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                closeConnection();
            }
        }


        public Produto consultarProduto(String produto)
        {
            try
            {
                openConnection();
                sqlCommand = new MySqlCommand
                    (
                    " SELECT        " +
                    "   *           " +
                    " FROM          " +
                    "   produto     " +
                    " WHERE         " +
                    " nome = @nome  " ,
                    strConn
                    );

                sqlCommand.Parameters.AddWithValue("@nome", produto);
                MySqlDataReader dr =  sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    Produto produtoRetorno = new Produto();
                    produtoRetorno.id_produto = Convert.ToInt32(dr.GetValue(0));
                    produtoRetorno.nomeProduto = Convert.ToString(dr.GetValue(1));
                    produtoRetorno.precoProduto = Convert.ToDouble(dr.GetValue(2));
                    produtoRetorno.quantidade = Convert.ToInt32(dr.GetValue(3));
                    return produtoRetorno;
                }
                return null;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                closeConnection();
            }
        }

    }
}
