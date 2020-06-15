using Farmacia_Toledo.BLL;
using Farmacia_Toledo.Model;
using System;
using System.Windows.Forms;

namespace Farmacia_Toledo.DAO
{
    public partial class UserForm : Form
    {
        Connection connection = new Connection();
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        int id_user;

        public UserForm()
        {
            InitializeComponent();
        }


        public void prencherObjeto(String id, String name)
        {
            this.id_user = Convert.ToInt32(id);
            tbNameUser.Text = name;
            btnDeleteUser.Visible = true;
            btnSaveUser.Visible = false;
            button1.Visible = true;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            try
            {
                if (String.IsNullOrEmpty(tbNameUser.Text))
                {
                    MessageBox.Show("Um nome deve ser preencido");
                    return;
                }

                if (String.IsNullOrEmpty(tbPasswordUser.Text))
                {
                    MessageBox.Show("Uma senha deve ser preencido");
                    return;
                }

                if (!tbPasswordUser.Text.Equals(tbPasswordConfirmUser.Text))
                {
                    MessageBox.Show("Preencha os campos com senhas iguais.");
                    return;
                }

                usuario.user = tbNameUser.Text;
                usuario.password = tbPasswordUser.Text;

                Boolean existe =  usuarioBLL.validarUsuario(usuario.user);

                if (existe)
                {
                    MessageBox.Show("Usuário ja cadastrado.");
                    return;
                }

                usuarioBLL.salvar(usuario);

                MessageBox.Show("Usuário cadastrado com sucesso.");
                this.Close();

            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                connection.openConnection();
                usuarioBLL.excluir(this.id_user);
                MessageBox.Show("Usuário excluido com sucesso.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbNameUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            try
            {
                if (String.IsNullOrEmpty(tbNameUser.Text))
                {
                    MessageBox.Show("Um nome deve ser preencido");
                    return;
                }

                if (String.IsNullOrEmpty(tbPasswordUser.Text))
                {
                    MessageBox.Show("Uma senha deve ser preencido");
                    return;
                }

                if (!tbPasswordUser.Text.Equals(tbPasswordConfirmUser.Text))
                {
                    MessageBox.Show("Preencha os campos com senhas iguais.");
                    return;
                }
                usuario.user = tbNameUser.Text;
                usuario.password = tbPasswordUser.Text;

                usuarioBLL.alterar(usuario, this.id_user);
                MessageBox.Show("Usuário cadastrado com sucesso.");
                this.Close();

            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
