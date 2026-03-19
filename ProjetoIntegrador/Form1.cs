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
           
        }
        public void Menu(Form form)
        {
            btnCadastro7.Visible = false;
            btnCadastro7.Visible = true; 
        }
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
            this.Close();
        }

        private void btnCadastro7_Click(object sender, EventArgs e)
        {
            Menu(new FormMotoboy());
            
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

       
    }
    
}
