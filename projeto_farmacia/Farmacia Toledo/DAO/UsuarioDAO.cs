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
    public class UsuarioDAO : Connection
    {
        MySqlCommand sqlCommand = null;

        public void salvar(Usuario usuario)
        {
            try
            {
                openConnection();
                sqlCommand = new MySqlCommand
                    (
                    " INSERT INTO                       " +
                    "   farmaceutico (user, password)   " +
                    " VALUES                            " +
                    "   (@user, @password)              ", 
                    strConn
                    );

                sqlCommand.Parameters.AddWithValue("@user", usuario.user);
                sqlCommand.Parameters.AddWithValue("@password", usuario.password);

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
                    "   id_user,        " +
                    "   user            " +
                    " FROM              " +
                    "   farmaceutico    ",
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

        public bool login(Usuario usuario)
        {
            bool result = false;
            try
            {
                openConnection();
                sqlCommand = new MySqlCommand
                    (
                    " SELECT                    " +
                    "   *                       " +
                    " FROM                      " +
                    "   farmaceutico            " +
                    " WHERE                     " +
                    "   user = @user            " +
                    " AND                       " +
                    "   password = @password    ", 
                    strConn
                    );

                sqlCommand.Parameters.AddWithValue("@user", usuario.user);
                sqlCommand.Parameters.AddWithValue("@password", usuario.password);

                MySqlDataReader data = sqlCommand.ExecuteReader();
                result = data.HasRows;
                

            }catch(Exception err)
            {
                throw err;
            }

            return result;
        }

        public bool validarUsuario(String nomeUsuario)
        {
            bool result = false;
            try
            {
                openConnection();
                sqlCommand = new MySqlCommand
                    (
                    " SELECT                    " +
                    "   *                       " +
                    " FROM                      " +
                    "   farmaceutico            " +
                    " WHERE                     " +
                    "   user = @user            ",
                    strConn
                    );

                sqlCommand.Parameters.AddWithValue("@user", nomeUsuario);

                MySqlDataReader data = sqlCommand.ExecuteReader();
                result = data.HasRows;


            }
            catch (Exception err)
            {
                throw err;
            }

            return result;
        }

        public void excluir(int id)
        {
            try
            {
                openConnection();
                sqlCommand = new MySqlCommand
                    (
                    " DELETE FROM               " +
                    "   farmaceutico            " +
                    " WHERE                     " +
                    "   id_user = @id           ",
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

        public void alterar(Usuario usuario, int id)
        {
            try
            {
                openConnection();
                sqlCommand = new MySqlCommand
                    (
                    " UPDATE                    " +
                    "   farmaceutico            " +
                    " SET                       " +
                    " user = @user,             " +
                    " password = @password      " +
                    " WHERE                     " +
                    "   id_user = @id           ",
                    strConn
                    );

                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@user", usuario.user);
                sqlCommand.Parameters.AddWithValue("@password", usuario.password);

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
