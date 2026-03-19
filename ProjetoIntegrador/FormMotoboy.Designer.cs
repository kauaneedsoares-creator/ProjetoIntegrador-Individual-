namespace ProjetoIntegrador
{
    partial class FormMotoboy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMotoboy));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNome1 = new System.Windows.Forms.TextBox();
            this.txtCondicaoMedica = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtAlergia = new System.Windows.Forms.TextBox();
            this.txtCPF1 = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.txtSenha1 = new System.Windows.Forms.TextBox();
            this.txtTelefone1 = new System.Windows.Forms.TextBox();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.btnCadastro1 = new System.Windows.Forms.Button();
            this.btnEditar1 = new System.Windows.Forms.Button();
            this.btnDeletar1 = new System.Windows.Forms.Button();
            this.btnLimpar1 = new System.Windows.Forms.Button();
            this.btnPesquisa1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cboTiposanguineos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Gray;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(440, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 327);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(236, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo sanguíneos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(236, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Alergia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(236, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Condição Medica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Navy;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(140, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Senha";
            // 
            // txtNome1
            // 
            this.txtNome1.Location = new System.Drawing.Point(12, 25);
            this.txtNome1.Name = "txtNome1";
            this.txtNome1.Size = new System.Drawing.Size(100, 20);
            this.txtNome1.TabIndex = 11;
            // 
            // txtCondicaoMedica
            // 
            this.txtCondicaoMedica.Location = new System.Drawing.Point(239, 181);
            this.txtCondicaoMedica.Name = "txtCondicaoMedica";
            this.txtCondicaoMedica.Size = new System.Drawing.Size(100, 20);
            this.txtCondicaoMedica.TabIndex = 12;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Location = new System.Drawing.Point(16, 302);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(323, 20);
            this.txtEndereco.TabIndex = 13;
            // 
            // txtAlergia
            // 
            this.txtAlergia.Location = new System.Drawing.Point(239, 123);
            this.txtAlergia.Name = "txtAlergia";
            this.txtAlergia.Size = new System.Drawing.Size(100, 20);
            this.txtAlergia.TabIndex = 14;
            // 
            // txtCPF1
            // 
            this.txtCPF1.Location = new System.Drawing.Point(12, 73);
            this.txtCPF1.Name = "txtCPF1";
            this.txtCPF1.Size = new System.Drawing.Size(100, 20);
            this.txtCPF1.TabIndex = 16;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(12, 129);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtDataNascimento.TabIndex = 17;
            // 
            // txtSenha1
            // 
            this.txtSenha1.Location = new System.Drawing.Point(143, 245);
            this.txtSenha1.Name = "txtSenha1";
            this.txtSenha1.Size = new System.Drawing.Size(100, 20);
            this.txtSenha1.TabIndex = 18;
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.Location = new System.Drawing.Point(15, 190);
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone1.TabIndex = 19;
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(15, 245);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(100, 20);
            this.txtEmail1.TabIndex = 20;
            // 
            // btnCadastro1
            // 
            this.btnCadastro1.BackColor = System.Drawing.Color.Lime;
            this.btnCadastro1.FlatAppearance.BorderSize = 0;
            this.btnCadastro1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro1.Location = new System.Drawing.Point(20, 364);
            this.btnCadastro1.Name = "btnCadastro1";
            this.btnCadastro1.Size = new System.Drawing.Size(81, 45);
            this.btnCadastro1.TabIndex = 21;
            this.btnCadastro1.Text = "Cadastro";
            this.btnCadastro1.UseVisualStyleBackColor = false;
            // 
            // btnEditar1
            // 
            this.btnEditar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditar1.FlatAppearance.BorderSize = 0;
            this.btnEditar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar1.Location = new System.Drawing.Point(192, 364);
            this.btnEditar1.Name = "btnEditar1";
            this.btnEditar1.Size = new System.Drawing.Size(81, 45);
            this.btnEditar1.TabIndex = 23;
            this.btnEditar1.Text = "Editar";
            this.btnEditar1.UseVisualStyleBackColor = false;
            // 
            // btnDeletar1
            // 
            this.btnDeletar1.BackColor = System.Drawing.Color.Red;
            this.btnDeletar1.FlatAppearance.BorderSize = 0;
            this.btnDeletar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar1.Location = new System.Drawing.Point(538, 364);
            this.btnDeletar1.Name = "btnDeletar1";
            this.btnDeletar1.Size = new System.Drawing.Size(81, 45);
            this.btnDeletar1.TabIndex = 24;
            this.btnDeletar1.Text = "Deletar";
            this.btnDeletar1.UseVisualStyleBackColor = false;
            // 
            // btnLimpar1
            // 
            this.btnLimpar1.BackColor = System.Drawing.Color.LightCoral;
            this.btnLimpar1.FlatAppearance.BorderSize = 0;
            this.btnLimpar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar1.Location = new System.Drawing.Point(389, 364);
            this.btnLimpar1.Name = "btnLimpar1";
            this.btnLimpar1.Size = new System.Drawing.Size(81, 45);
            this.btnLimpar1.TabIndex = 25;
            this.btnLimpar1.Text = "Limpar";
            this.btnLimpar1.UseVisualStyleBackColor = false;
            // 
            // btnPesquisa1
            // 
            this.btnPesquisa1.Location = new System.Drawing.Point(136, 7);
            this.btnPesquisa1.Name = "btnPesquisa1";
            this.btnPesquisa1.Size = new System.Drawing.Size(137, 23);
            this.btnPesquisa1.TabIndex = 26;
            this.btnPesquisa1.Text = "Pesquisa";
            this.btnPesquisa1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cboTiposanguineos
            // 
            this.cboTiposanguineos.FormattingEnabled = true;
            this.cboTiposanguineos.Items.AddRange(new object[] {
            "A +",
            "A -",
            "B +",
            "B -",
            "AB +",
            "AB -",
            "O +",
            "O -"});
            this.cboTiposanguineos.Location = new System.Drawing.Point(239, 73);
            this.cboTiposanguineos.Name = "cboTiposanguineos";
            this.cboTiposanguineos.Size = new System.Drawing.Size(100, 21);
            this.cboTiposanguineos.TabIndex = 27;
            // 
            // FormMotoboy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(638, 437);
            this.Controls.Add(this.cboTiposanguineos);
            this.Controls.Add(this.btnPesquisa1);
            this.Controls.Add(this.btnLimpar1);
            this.Controls.Add(this.btnDeletar1);
            this.Controls.Add(this.btnEditar1);
            this.Controls.Add(this.btnCadastro1);
            this.Controls.Add(this.txtEmail1);
            this.Controls.Add(this.txtTelefone1);
            this.Controls.Add(this.txtSenha1);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtCPF1);
            this.Controls.Add(this.txtAlergia);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCondicaoMedica);
            this.Controls.Add(this.txtNome1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMotoboy";
            this.Text = "FormMotoboy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNome1;
        private System.Windows.Forms.TextBox txtCondicaoMedica;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtAlergia;
        private System.Windows.Forms.TextBox txtCPF1;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.TextBox txtSenha1;
        private System.Windows.Forms.TextBox txtTelefone1;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.Button btnCadastro1;
        private System.Windows.Forms.Button btnEditar1;
        private System.Windows.Forms.Button btnDeletar1;
        private System.Windows.Forms.Button btnLimpar1;
        private System.Windows.Forms.Button btnPesquisa1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cboTiposanguineos;
    }
}