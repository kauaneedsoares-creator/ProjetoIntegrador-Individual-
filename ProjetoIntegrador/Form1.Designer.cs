namespace ProjetoIntegrador
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTela = new System.Windows.Forms.Panel();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.bntQRCode7 = new System.Windows.Forms.Button();
            this.btnContato7 = new System.Windows.Forms.Button();
            this.bntMotoboy = new System.Windows.Forms.Button();
            this.btnCadastro7 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelTela
            // 
            this.panelTela.Location = new System.Drawing.Point(230, 2);
            this.panelTela.Name = "panelTela";
            this.panelTela.Size = new System.Drawing.Size(645, 463);
            this.panelTela.TabIndex = 0;
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(12, 150);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(212, 29);
            this.btnEmpresa.TabIndex = 5;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(12, 330);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(212, 29);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(12, 232);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(212, 29);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // bntQRCode7
            // 
            this.bntQRCode7.Location = new System.Drawing.Point(12, 115);
            this.bntQRCode7.Name = "bntQRCode7";
            this.bntQRCode7.Size = new System.Drawing.Size(212, 29);
            this.bntQRCode7.TabIndex = 4;
            this.bntQRCode7.Text = "QR Code";
            this.bntQRCode7.UseVisualStyleBackColor = true;
            this.bntQRCode7.Click += new System.EventHandler(this.bntQRCode7_Click);
            // 
            // btnContato7
            // 
            this.btnContato7.Location = new System.Drawing.Point(12, 80);
            this.btnContato7.Name = "btnContato7";
            this.btnContato7.Size = new System.Drawing.Size(212, 29);
            this.btnContato7.TabIndex = 3;
            this.btnContato7.Text = "Contato Motoboy";
            this.btnContato7.UseVisualStyleBackColor = true;
            this.btnContato7.Click += new System.EventHandler(this.btnContato7_Click);
            // 
            // bntMotoboy
            // 
            this.bntMotoboy.Location = new System.Drawing.Point(12, 48);
            this.bntMotoboy.Name = "bntMotoboy";
            this.bntMotoboy.Size = new System.Drawing.Size(212, 29);
            this.bntMotoboy.TabIndex = 2;
            this.bntMotoboy.Text = "Motoboy";
            this.bntMotoboy.UseVisualStyleBackColor = true;
            this.bntMotoboy.Click += new System.EventHandler(this.bntMotoboy_Click);
            // 
            // btnCadastro7
            // 
            this.btnCadastro7.Location = new System.Drawing.Point(12, 2);
            this.btnCadastro7.Name = "btnCadastro7";
            this.btnCadastro7.Size = new System.Drawing.Size(212, 40);
            this.btnCadastro7.TabIndex = 1;
            this.btnCadastro7.Text = "Cadastro";
            this.btnCadastro7.UseVisualStyleBackColor = true;
            this.btnCadastro7.Click += new System.EventHandler(this.btnCadastro7_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 393);
            this.btnSair.Name = "btnSair";
            this.btnSair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSair.Size = new System.Drawing.Size(212, 72);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 470);
            this.Controls.Add(this.btnCadastro7);
            this.Controls.Add(this.bntMotoboy);
            this.Controls.Add(this.bntQRCode7);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.btnContato7);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panelTela);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTela;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button bntQRCode7;
        private System.Windows.Forms.Button btnContato7;
        private System.Windows.Forms.Button bntMotoboy;
        private System.Windows.Forms.Button btnCadastro7;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnSair;
    }
}

