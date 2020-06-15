using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using Farmacia_Toledo.DAO;
using Farmacia_Toledo.Model;
using Farmacia_Toledo.BLL;

namespace Farmacia_Toledo
{
    public partial class FormLoginFarmacia : Form
    {
     
        public FormLoginFarmacia()
        {
            InitializeComponent();
        }


        private bool login(Usuario usuario)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuario.user = Convert.ToString(tbUser.Text);
            usuario.password = Convert.ToString(tbPassword.Text);
            return usuarioBLL.login(usuario);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool logged = false;
            Usuario usuario = new Usuario();

            logged = login(usuario);

            try
            {
                if (logged)
                {
                    this.Visible = false;
                    dashboard dash = new dashboard();
                    dash.salvarLogado(usuario.user);
                    dash.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Senha ou usuário incorreto");
                }
            }
            catch(Exception err)
            {
                throw err;
            }


            /*Connection dataConn = new Connection();
            Usuario usuario = new Usuario();

            try
            {
                dataConn.openConnection();
                salvar(usuario);
   
            }
            catch(Exception erro)
            {
                throw erro;
            }*/


        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void FormLoginFarmacia_Load(object sender, EventArgs e)
        {
            try
            {
                Connection connection = new Connection();
                connection.openConnection();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

//private MySqlDataAdapter mAdapter;
//private DataSet mDataSet;

//MySqlCommand command = new MySqlCommand("SELECT user FROM farmaceutico", mConn);

//string usr = Convert.ToString(command.ExecuteScalar());



//PARA IMPRIMIR OS DADOS NO DATAGRIDVIEW

//            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
//
//          dataAdapter.SelectCommand = command;
//            DataSet dSet = new DataSet();
//            dataAdapter.Fill(dSet);

//            dataGridView1.DataSource = dSet;
//            dataGridView1.DataMember = dSet.Tables[0].TableName;       
