using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia_Toledo.BLL;
using Farmacia_Toledo.Model;

namespace Farmacia_Toledo
{
    public partial class homeUserControl : UserControl
    {
        ConsultaDashboardBLL consultaDashboardBLL = new ConsultaDashboardBLL();


        public homeUserControl()
        {
            InitializeComponent();
            consultar();
        }

        private void consultar()
        {
            //Consulta o usuario com mais vendas
            UsuarioMesDTO usuarioMesDTO = new UsuarioMesDTO();
            usuarioMesDTO = consultaDashboardBLL.consultaFuncionarioMes();
            if(usuarioMesDTO == null)
            {
                usuarioMesDTO = new UsuarioMesDTO();
                usuarioMesDTO.nome = "Sem informações";
                usuarioMesDTO.bonificacao = 00.00;
                usuarioMesDTO.produtosVendidos = 00;
            }

            label7.Text = usuarioMesDTO.nome;
            label8.Text = usuarioMesDTO.produtosVendidos.ToString();
            label11.Text = "R$" + usuarioMesDTO.bonificacao.ToString("00.00", System.Globalization.CultureInfo.InvariantCulture);

            //Consulta o total de vendas
            label2.Text = consultaDashboardBLL.consultaVendasNoMes().ToString();
            label4.Text = "R$" + consultaDashboardBLL.consultaVendasNoMesDinheiro().ToString("00.00", System.Globalization.CultureInfo.InvariantCulture);

            //Consulta o produto mais vendido
            ProdutoDTO produtoDTO = new ProdutoDTO();

            produtoDTO = consultaDashboardBLL.consultaProdutoMes();

            if(produtoDTO == null)
            {
                produtoDTO = new ProdutoDTO();
                produtoDTO.nome = "Sem informações";
                produtoDTO.preco = 00.00;
                produtoDTO.quantidadeNoMes = 00;
            }

            label16.Text = produtoDTO.nome;
            label15.Text = produtoDTO.quantidadeNoMes.ToString();
            label12.Text = "R$" + produtoDTO.preco.ToString("00.00", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void lblLucro_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void homeUserControl_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.consultar();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
