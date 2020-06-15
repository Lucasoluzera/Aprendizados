using Farmacia_Toledo.BLL;
using Farmacia_Toledo.DAO;
using Farmacia_Toledo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_Toledo
{
    public partial class ProdutoForm: Form
    {
        
        Connection connection = new Connection();
        ProdutoBLL produtoBLL = new ProdutoBLL();

        int produto_id;

        public ProdutoForm()
        {
            InitializeComponent();
        }

        public void preencherObjeto(String nome, String valor, String quantidade, String produto_id)
        {
            Console.WriteLine("nome " + nome);
            this.produto_id = Convert.ToInt32(produto_id);
            tbNome.Text = nome;
            tbPreco.Text = valor;
            nmQtd.Value = Convert.ToInt32(quantidade);
            button1.Visible = true;
            button3.Visible = true;
            button2.Visible = false;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProdutoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            Connection connection = new Connection();
            connection.openConnection();
            if(tbNome.Text == null || tbNome.Text == "")
            {
                MessageBox.Show("Nome é obrigatório.");
                return;
            }

            if (produtoBLL.consultarProduto(tbNome.Text) != null){
                MessageBox.Show("Produto já cadastrado, altere ele.");
                return;
            }

            produto.nomeProduto = tbNome.Text;

            if (tbPreco.Text == null || tbPreco.Text == "")
            {
                MessageBox.Show("Preço é obrigatório.");
                return;
            }
            try
            {
                double preco = Convert.ToDouble(tbPreco.Text);
                produto.precoProduto = preco;
            }
            catch 
            {
                MessageBox.Show("Valor informado não é um valor compátivel.");
                return;
            }

            if (String.IsNullOrEmpty(nmQtd.Text) || Convert.ToInt32(nmQtd.Text) == 0)
            {
                MessageBox.Show("Quantidade não pode ser vazia ou zero.");
                return;
            }
            produto.quantidade = Convert.ToInt32(nmQtd.Text);

            try
            {
                connection.openConnection();
                produtoBLL.salvar(produto);
                MessageBox.Show("Produto cadastrado com sucesso.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

        public void nmQtd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.openConnection();
                produtoBLL.excluir(this.produto_id);
                MessageBox.Show("Produto excluido com sucesso.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void tbPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            Connection connection = new Connection();
            connection.openConnection();
            if (tbNome.Text == null || tbNome.Text == "")
            {
                MessageBox.Show("Nome é obrigatório.");
                return;
            }
            produto.nomeProduto = tbNome.Text;

            if (tbPreco.Text == null || tbPreco.Text == "")
            {
                MessageBox.Show("Preço é obrigatório.");
                return;
            }
            try
            {
                double preco = Convert.ToDouble(tbPreco.Text);
                produto.precoProduto = preco;
            }
            catch
            {
                MessageBox.Show("Valor informado não é um valor compátivel.");
                return;
            }

            if (String.IsNullOrEmpty(nmQtd.Text) || Convert.ToInt32(nmQtd.Text) == 0)
            {
                MessageBox.Show("Quantidade não pode ser vazia ou zero.");
                return;
            }
            produto.quantidade = Convert.ToInt32(nmQtd.Text);

            try
            {
                connection.openConnection();
                produtoBLL.alterar(produto, this.produto_id);
                MessageBox.Show("Produto alterado com sucesso.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
