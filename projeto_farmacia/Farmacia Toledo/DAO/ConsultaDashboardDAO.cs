using Farmacia_Toledo.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia_Toledo.DAO
{
    class ConsultaDashboardDAO : Connection
    {
        MySqlCommand sqlCommand = null;

        public int consultaVendasMes(DateTime dataInicial)
        {
            try
            {
                openConnection();
                sqlCommand = new MySqlCommand
                    (
                    " SELECT            " +
                    "   *               " +
                    "FROM               " +
                    "   venda           " +
                    "WHERE              " +
                    "   data_venda      " +
                    "BETWEEN            " +
                    "   @dataInicial    " +
                    "and                " +
                    "   @dataAtual      ",
                    strConn
                    );
                Console.WriteLine(dataInicial);
                Console.WriteLine(DateTime.Now);


                sqlCommand.Parameters.AddWithValue("@dataInicial", dataInicial);
                sqlCommand.Parameters.AddWithValue("@dataAtual", DateTime.Now);

                sqlCommand.ExecuteNonQuery();

                MySqlDataReader dr = sqlCommand.ExecuteReader();
                int quantidadeVendas = 0;
                while (dr.Read())
                {
                    quantidadeVendas = quantidadeVendas + Convert.ToInt32(dr.GetValue(3));
                }
                return quantidadeVendas;

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


        public double consultaVendasMesDinheiro(DateTime dataInicial)
        {
            try
            {
                openConnection();
                sqlCommand = new MySqlCommand
                    (
                    " SELECT            " +
                    "   *               " +
                    "FROM               " +
                    "   venda           " +
                    "WHERE              " +
                    "   data_venda      " +
                    "BETWEEN            " +
                    "   @dataInicial    " +
                    "and                " +
                    "   @dataAtual      ",
                    strConn
                    );
                Console.WriteLine(dataInicial);
                Console.WriteLine(DateTime.Now);


                sqlCommand.Parameters.AddWithValue("@dataInicial", dataInicial);
                sqlCommand.Parameters.AddWithValue("@dataAtual", DateTime.Now);

                sqlCommand.ExecuteNonQuery();

                MySqlDataReader dr = sqlCommand.ExecuteReader();
                double valorVenda = 0;
                while (dr.Read())
                {
                    valorVenda = valorVenda + Convert.ToDouble(dr.GetValue(5));
                }
                return valorVenda;

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

        public UsuarioMesDTO consultaFuncionarioMes(DateTime dataInicial)
        {
            UsuarioMesDTO usuarioMesDTO = new UsuarioMesDTO();

            int quantidadeVendas = 0;
            double valorMaior = 0, valorTotalPorUsuario = 0;
            String nomeFuncionario;

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

                MySqlDataReader dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    try
                    {
                        openConnection();
                        sqlCommand = new MySqlCommand
                            (
                            " SELECT                         " +
                            "   *                            " +
                            "FROM                            " +
                            "   venda                        " +
                            "WHERE                           " +
                            "   responsavel_venda = @nome    " +
                            "and                             " +
                            "   data_venda                   " +
                            "BETWEEN                         " +
                            "   @dataInicial                 " +
                            "and                             " +
                            "   @dataAtual                   ",
                            strConn
                            );


                        sqlCommand.Parameters.AddWithValue("@dataInicial", dataInicial);
                        sqlCommand.Parameters.AddWithValue("@dataAtual", DateTime.Now);
                        sqlCommand.Parameters.AddWithValue("@nome", dr.GetValue(1));

                        MySqlDataReader dr2 = sqlCommand.ExecuteReader();
                        while (dr2.Read())
                        {
                            valorTotalPorUsuario = valorTotalPorUsuario + Convert.ToDouble(dr2.GetValue(5));
                            quantidadeVendas = quantidadeVendas + Convert.ToInt32(dr2.GetValue(3));
                        }
                        if(valorTotalPorUsuario > valorMaior)
                        {
                            valorMaior = valorTotalPorUsuario;
                            usuarioMesDTO.bonificacao = valorMaior * 0.10;
                            usuarioMesDTO.produtosVendidos = quantidadeVendas;
                            usuarioMesDTO.nome = dr.GetValue(1).ToString();                        }
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
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                closeConnection();
            }

            return usuarioMesDTO;

        }


        public ProdutoDTO consultaProdutoMes(DateTime dataInicial)
        {
            ProdutoDTO produtoDTO = new ProdutoDTO();

            int  quantidadeVendas = 0;
            double valorMaior = 0, valorTotalPorProduto = 0;
            String nomeProduto;

            try
            {
                openConnection();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                sqlCommand = new MySqlCommand
                    (
                    " SELECT DISTINCT                " +
                    "   nome_produto                 " +
                    "FROM                            " +
                    "   venda                        " +
                    "WHERE                           " +
                    "   data_venda                   " +
                    "BETWEEN                         " +
                    "   @dataInicial                 " +
                    "and                             " +
                    "   @dataAtual                   ",
                    strConn
                    );

                sqlCommand.Parameters.AddWithValue("@dataInicial", dataInicial);
                sqlCommand.Parameters.AddWithValue("@dataAtual", DateTime.Now);

                MySqlDataReader dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine(dr.GetValue(0) + " EQWOPEKQWOPEKOQW");


                    try
                    {
                        openConnection();
                        sqlCommand = new MySqlCommand
                            (
                            " SELECT                         " +
                            "   *                            " +
                            "FROM                            " +
                            "   venda                        " +
                            "WHERE                           " +
                            "   nome_produto = @nome         " +
                            "and                             " +
                            "   data_venda                   " +
                            "BETWEEN                         " +
                            "   @dataInicial                 " +
                            "and                             " +
                            "   @dataAtual                   ",
                            strConn
                            );

                        sqlCommand.Parameters.AddWithValue("@dataInicial", dataInicial);
                        sqlCommand.Parameters.AddWithValue("@dataAtual", DateTime.Now);
                        sqlCommand.Parameters.AddWithValue("@nome", dr.GetValue(0).ToString());

                        MySqlDataReader dr2 = sqlCommand.ExecuteReader();
                        while (dr2.Read())
                        {
                            valorTotalPorProduto = valorTotalPorProduto + Convert.ToDouble(dr2.GetValue(5));
                            quantidadeVendas = quantidadeVendas + Convert.ToInt32(dr2.GetValue(3));
                        }
                        if (valorTotalPorProduto > valorMaior)
                        {
                            valorMaior = valorTotalPorProduto;
                            produtoDTO.nome = dr.GetValue(0).ToString();
                            produtoDTO.preco = valorTotalPorProduto / quantidadeVendas;
                            produtoDTO.quantidadeNoMes = quantidadeVendas;
                        }
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
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                closeConnection();
            }

            return produtoDTO;

        }
    }
}
