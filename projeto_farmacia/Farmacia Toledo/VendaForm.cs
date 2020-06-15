using Farmacia_Toledo.BLL;
using Farmacia_Toledo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_Toledo
{
    public partial class VendaForm : Form
    {
        private VendaBLL vendaBLL = new VendaBLL();
        private ProdutoBLL produtoBLL = new ProdutoBLL();

        private int vendaId;
        private double valorTotalProduto;

        public VendaForm()
        {
            InitializeComponent();
        }

        private Venda venda = new Venda();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void preencherObjeto(String nomeProduto, String quantidade, String nomeUsuario, String vendaId, String valorTotal)
        {
            tbNomeProduto.Text = nomeProduto;
            tbNomeProduto.ReadOnly = true;
            nmQtd.Value = Convert.ToInt32(quantidade);
            nmQtd.ReadOnly = true;
            tbLogin.Text = nomeUsuario;
            tbLogin.ReadOnly = true;
            btnDeleteVenda.Visible = true;
            this.vendaId = Convert.ToInt32(vendaId);
            this.valorTotalProduto = Convert.ToDouble(valorTotal);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbLogin.Text))
            {
                MessageBox.Show("Por favor insira seu login");
                return;
            }


            if (String.IsNullOrEmpty(nmQtd.Text) || nmQtd.Text.Equals(0))
            {
                MessageBox.Show("Por favor informe uma quantidade válida");
                return;
            }

            if (String.IsNullOrEmpty(tbNomeProduto.Text))
            {
                MessageBox.Show("Por favor insira um produto na venda");
                return;
            }

            venda = new Venda();
            venda.dataVenda = DateTime.Now;
            Produto produto = new Produto();
            produto = produtoBLL.consultarProduto(tbNomeProduto.Text);

            int quantidadeVenda = Convert.ToInt32(nmQtd.Text);

            if (produto == null)
            {
                MessageBox.Show("Produto não encotrado.");
                return;
            }

            if (produto.quantidade < quantidadeVenda)
            {
                MessageBox.Show("Não há quantidade suficiente para está compra, quantidade em estoque: " + produto.quantidade);
                return;
            }
            venda.valorVenda =  quantidadeVenda * produto.precoProduto;
            venda.nomeProduto = produto.nomeProduto;
            venda.quantidade = quantidadeVenda;
            produto.quantidade = produto.quantidade - quantidadeVenda;

            UsuarioBLL usuarioBLL = new UsuarioBLL();

            bool validarUsuario = usuarioBLL.validarUsuario(tbLogin.Text);

            if (!validarUsuario)
            {
                MessageBox.Show("Não foi encontrado o login : " + tbLogin.Text);
                return; 
            }
            venda.responsavelVenda = tbLogin.Text;

            Console.WriteLine(venda.responsavelVenda);

            if(produto.quantidade == 0)
            {
                produtoBLL.excluir(produto.id_produto);
            }
            else
            {
                produtoBLL.alterar(produto, produto.id_produto);
            }

            vendaBLL.salvar(venda);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nmQtd_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void tbNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void VendaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            vendaBLL.excluir(this.vendaId);
            Produto produto = produtoBLL.consultarProduto(tbNomeProduto.Text);

            int quantidadeVenda = Convert.ToInt32(nmQtd.Text);

            if (produto == null)
            {
                produto = new Produto();
                produto.nomeProduto = tbNomeProduto.Text;
                produto.quantidade = Convert.ToInt32(nmQtd.Text);
                produto.precoProduto = Convert.ToDouble(this.valorTotalProduto / quantidadeVenda);
                produtoBLL.salvar(produto);
            }
            else
            {
                produto.quantidade = produto.quantidade + Convert.ToInt32(nmQtd.Text);
                produtoBLL.alterar(produto,produto.id_produto);
            }
            MessageBox.Show("Venda excluída com sucesso.");
            this.Close();
        }
    }
}
