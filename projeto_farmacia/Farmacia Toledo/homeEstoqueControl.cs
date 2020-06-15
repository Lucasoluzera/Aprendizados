using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Farmacia_Toledo.DAO;
using Farmacia_Toledo.Model;

namespace Farmacia_Toledo
{
    public partial class HomeEstoqueControl : UserControl
    {
        public HomeEstoqueControl()
        {
            InitializeComponent();
            preencherTabela();
        }

        public void preencherTabela()
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDAO.consultar(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) { 
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                Console.WriteLine(row.Cells["nome"].Value.ToString());
                ProdutoForm produtoForm = new ProdutoForm();
                produtoForm.Show();
                produtoForm.preencherObjeto(
                    row.Cells["nome"].Value.ToString(), 
                    row.Cells["preco"].Value.ToString(),
                    row.Cells["quantidade"].Value.ToString(), 
                    row.Cells["id_produto"].Value.ToString());
            }
            preencherTabela();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            ProdutoForm produtoForm = new ProdutoForm();
            produtoForm.ShowDialog();
            preencherTabela();
        }

        private void homeEstoqueControl_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizarRegistros_Click(object sender, EventArgs e)
        {
            preencherTabela();
        }
    }
}
