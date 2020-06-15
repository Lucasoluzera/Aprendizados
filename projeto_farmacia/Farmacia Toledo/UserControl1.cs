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
using Farmacia_Toledo.BLL;
using Farmacia_Toledo.Model;
using Farmacia_Toledo.Properties;
using Microsoft.VisualBasic.ApplicationServices;

namespace Farmacia_Toledo
{
    public partial class UserControl1 : UserControl
    {

       

        public UserControl1()
        {
            InitializeComponent();
        }

        private void preencherTabela()
        {
            UsuarioDAO usuarioDao = new UsuarioDAO();
            usuarioDao.consulta(dataGridViewUser);
        }

        

        private void btnNewUser_Click_1(object sender, EventArgs e)
        {
            preencherTabela();
            UserForm userForm = new UserForm();
            userForm.ShowDialog();

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            preencherTabela();
        }

        private void btnAtualizarRegistros_Click(object sender, EventArgs e)
        {
            preencherTabela();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            preencherTabela();
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewUser.Rows[e.RowIndex];
                Console.WriteLine(row.Cells["user"].Value.ToString());
                UserForm userForm = new UserForm();
                userForm.Show();
                userForm.prencherObjeto(
                    row.Cells["id_user"].Value.ToString(),
                    row.Cells["user"].Value.ToString());  
            }
            preencherTabela();
        }

    }
}
