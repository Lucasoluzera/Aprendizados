using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia_Toledo.DAO;

namespace Farmacia_Toledo
{
    public partial class homeVendaControl : UserControl
    {
        public homeVendaControl()
        {
            InitializeComponent();
            preencherTabela();
        }

        public void preencherTabela()
        {
            VendaDAO vendaDAO = new VendaDAO();
            vendaDAO.consulta(dataGridView1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizarRegistros_Click(object sender, EventArgs e)
        {
            preencherTabela();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                VendaForm vendaForm = new VendaForm();
                vendaForm.Show();
                vendaForm.preencherObjeto(
                    row.Cells["nome_produto"].Value.ToString(),
                    row.Cells["quantidade"].Value.ToString(),
                    row.Cells["responsavel_venda"].Value.ToString(),
                    row.Cells["id_venda"].Value.ToString(),
                    row.Cells["valor_venda"].Value.ToString()
                    );
            }
            preencherTabela();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            VendaForm vendaForm = new VendaForm();
            vendaForm.Show();
        }

        private void homeVendaControl_Load(object sender, EventArgs e)
        {

        }
    }
}
