using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;

namespace Farmacia_Toledo
{
    public partial class dashboard : Form
    {

        public String idUsuarioLogado;
        public dashboard()
        {
            InitializeComponent();
        }

        public void salvarLogado(String id)
        {
            this.idUsuarioLogado = id;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
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
            dashboard dash = new dashboard();
            this.Close();

            FormLoginFarmacia frmLogin = new FormLoginFarmacia();
            frmLogin.Visible = true;
        }

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Este é o percentual de lucro de sua empresa\n" +
                "baseado no crescimento a partir do seu primeiro fundo de estoque");


        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            homeEstoqueControl1.Hide();
            userControl11.Hide();
            homeUserControl1.Hide();
            homeVendaControl1.Hide();
            homeUserControl1.Show();
            homeUserControl1.BringToFront();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
           
            homeEstoqueControl1.Hide();
            homeVendaControl1.Hide();
            userControl11.Hide();
            homeUserControl1.BringToFront();
            homeUserControl1.Show();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            homeEstoqueControl1.Hide();
            userControl11.Hide();
            homeUserControl1.Hide();
            homeVendaControl1.BringToFront();
            homeVendaControl1.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            //Mostra a tela estoque e desabilita a de usuario
            homeEstoqueControl1.Show();
            userControl11.Hide();
            homeUserControl1.Hide();
            homeVendaControl1.Hide();
            homeUserControl1.BringToFront();
            homeUserControl1.Hide();
        }

        private void homeEstoqueControl1_Load(object sender, EventArgs e)
        {
        }

        private void homeUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            homeEstoqueControl1.Hide();
            homeUserControl1.Hide();
            userControl11.BringToFront();
            userControl11.Show();
        }
    }
}
