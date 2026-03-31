using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoIntegrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //isso vai fazer que os botoes no inicio permaneça escondido ate clicar no botao de Cadastro
            btnMotoboy.Visible = false;
            btnContato7.Visible = false;
            btnEmpresa.Visible = false;
            bntQRCode7.Visible = false;


        }
        public void Menu(Form form)
        {
            //quando clica no botao de Cadastro vai aparecer as opções 
            btnCadastro7.Visible = true;
            btnMotoboy.Visible = true;
            btnContato7.Visible = true;
            btnEmpresa.Visible = true;
            bntQRCode7.Visible = true;
           


        }
        /// <summary>
        /// Abre um formulário dentro do painel 
        /// </summary>
        public void AbrirFormNoPanel(Form form)
        {
            form.TopLevel = false;
            panelTela.Controls.Clear(); // limpa a tela que faz remove o form anterior
            form.Dock = DockStyle.Fill; //faz o tela ocupar 100 do tamanho do panel
            form.FormBorderStyle = FormBorderStyle.None; // remove a borda e barra de título do formulário
            panelTela.Controls.Add(form); //Adiciona o tela  dentro do panel
            form.BringToFront();
            AutoScroll = true;
            form.Show(); //Exibe o formulário na tela
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Close();
            //Application.Exit();vai garantia que fecha tudos
            FormSenha formsenha = new FormSenha();
            formsenha.Show();
            this.Hide();

        }

        private void btnCadastro7_Click(object sender, EventArgs e)
        {
            Menu(new Form1());
           
            btnCadastro7.Visible = true;
           

        }

        private void bntMotoboy_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new FormMotoboy());
        }

        private void btnContato7_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new FormContatoMotoboy());
        }

        private void bntQRCode7_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new FormQRCode());
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new FormEmpresa());
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new FormConsulta()); 
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

            panelTela.Controls.Clear(); // limpa a tela
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new FormFuncionarios());
        }
    }
    
}
