using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Farmacia_Toledo.Model;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;

namespace Farmacia_Toledo.DAO
{
    public class VendaDAO : Connection
    {
        MySqlCommand sqlCommand = null;

        public void salvar(Venda venda)
        {
            try
            {
                openConnection();
                sqlCommand = new MySqlCommand
                    (
                    " INSERT INTO                       " +
                    "   venda                           " +
                    "(                                  " +
                    "data_venda,                         " +
                    "nome_produto,                       " +
                    "quantidade,                        " +
                    "responsavel_venda,                  " +
                    "valor_venda                         " +
                    ")                                  " +
                    " VALUES                            " +
                    "(                                  " +
                    "@dataVenda,                        " +
                    "@nomeProduto,                      " +
                    "@quantidade,                       " +
                    "@responsavelVenda,                 " +
                    "@valorVenda                        " +
                    ")                                  ", 
                    strConn
                    );

                sqlCommand.Parameters.AddWithValue("@dataVenda", venda.dataVenda);
                sqlCommand.Parameters.AddWithValue("@nomeProduto", venda.nomeProduto);
                sqlCommand.Parameters.AddWithValue("@quantidade", venda.quantidade);
                sqlCommand.Parameters.AddWithValue("@responsavelVenda", venda.responsavelVenda);
                sqlCommand.Parameters.AddWithValue("@valorVenda", venda.valorVenda);

                sqlCommand.ExecuteNonQuery();

            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                closeConnection();
            }

        }

        public void consulta(DataGridView dataGridView)
        {
            try
            {
                openConnection();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                sqlCommand = new MySqlCommand
                    (
                    " SELECT            " +
                    "   *               " +
                    " FROM              " +
                    "   venda           ",
                    strConn
                    );

                dataAdapter.SelectCommand = sqlCommand;
 
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridView.DataSource = dataSet;
                dataGridView.DataMember = dataSet.Tables[0].TableName;
            }
            catch(Exception err)
            {
                throw err;
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
                    " DELETE FROM               " +
                    "   venda                   " +
                    " WHERE                     " +
                    "   id_venda = @id          ",
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
    }
}
