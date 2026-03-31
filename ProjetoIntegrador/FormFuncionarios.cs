using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    /// Funcionario -> Não poder cadastras Funcionarios novos , não pode deletar
    /// Gerente -> So Gerente vai poder cadastras novos  
    
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Serve para poder mexer nos dados(EX:agora você pode alterar)
        /// </summary>
        private void btnEditar8_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Serve para guardar o que mudou(EX:pronto, salvou)
        /// </summary>
        private void btnSalvar8_Click(object sender, EventArgs e)
        {

        }
    }
}
