namespace ProjetoIntegrador
{
    partial class FormConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.bntLimpar5 = new System.Windows.Forms.Button();
            this.bntDeletar5 = new System.Windows.Forms.Button();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.bntPesquisar5 = new System.Windows.Forms.Button();
            this.cboAcao = new System.Windows.Forms.ComboBox();
            this.lblDataConsulta = new System.Windows.Forms.Label();
            this.lblPesquisarConsulta = new System.Windows.Forms.Label();
            this.lblAcaoConsulta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtUsuario.Location = new System.Drawing.Point(19, 77);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 19);
            this.txtUsuario.TabIndex = 0;
            // 
            // bntLimpar5
            // 
            this.bntLimpar5.BackColor = System.Drawing.Color.LightCoral;
            this.bntLimpar5.FlatAppearance.BorderSize = 0;
            this.bntLimpar5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLimpar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLimpar5.Location = new System.Drawing.Point(29, 352);
            this.bntLimpar5.Name = "bntLimpar5";
            this.bntLimpar5.Size = new System.Drawing.Size(81, 45);
            this.bntLimpar5.TabIndex = 1;
            this.bntLimpar5.Text = "limpar";
            this.bntLimpar5.UseVisualStyleBackColor = false;
            // 
            // bntDeletar5
            // 
            this.bntDeletar5.BackColor = System.Drawing.Color.Red;
            this.bntDeletar5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bntDeletar5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bntDeletar5.FlatAppearance.BorderSize = 0;
            this.bntDeletar5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntDeletar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDeletar5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntDeletar5.Location = new System.Drawing.Point(545, 352);
            this.bntDeletar5.Name = "bntDeletar5";
            this.bntDeletar5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bntDeletar5.Size = new System.Drawing.Size(81, 45);
            this.bntDeletar5.TabIndex = 2;
            this.bntDeletar5.Text = "Deletar";
            this.bntDeletar5.UseVisualStyleBackColor = false;
            // 
            // listBox5
            // 
            this.listBox5.BackColor = System.Drawing.Color.Gray;
            this.listBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(0, 148);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(639, 182);
            this.listBox5.TabIndex = 3;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.White;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(180, 81);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 19);
            this.txtData.TabIndex = 4;
            // 
            // bntPesquisar5
            // 
            this.bntPesquisar5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bntPesquisar5.FlatAppearance.BorderSize = 0;
            this.bntPesquisar5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPesquisar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPesquisar5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntPesquisar5.Location = new System.Drawing.Point(381, 12);
            this.bntPesquisar5.Name = "bntPesquisar5";
            this.bntPesquisar5.Size = new System.Drawing.Size(245, 23);
            this.bntPesquisar5.TabIndex = 5;
            this.bntPesquisar5.Text = "Pesquisar";
            this.bntPesquisar5.UseVisualStyleBackColor = false;
            // 
            // cboAcao
            // 
            this.cboAcao.FormattingEnabled = true;
            this.cboAcao.Items.AddRange(new object[] {
            "Login",
            "Cadastro",
            "QR Code",
            "Empresa",
            "Contato Motoboy",
            "Motoboy",
            "Funcionarios"});
            this.cboAcao.Location = new System.Drawing.Point(349, 79);
            this.cboAcao.Name = "cboAcao";
            this.cboAcao.Size = new System.Drawing.Size(121, 21);
            this.cboAcao.TabIndex = 28;
            // 
            // lblDataConsulta
            // 
            this.lblDataConsulta.AutoSize = true;
            this.lblDataConsulta.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblDataConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDataConsulta.Location = new System.Drawing.Point(177, 57);
            this.lblDataConsulta.Name = "lblDataConsulta";
            this.lblDataConsulta.Size = new System.Drawing.Size(79, 18);
            this.lblDataConsulta.TabIndex = 29;
            this.lblDataConsulta.Text = "Data inicial";
            // 
            // lblPesquisarConsulta
            // 
            this.lblPesquisarConsulta.AutoSize = true;
            this.lblPesquisarConsulta.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblPesquisarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisarConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPesquisarConsulta.Location = new System.Drawing.Point(15, 54);
            this.lblPesquisarConsulta.Name = "lblPesquisarConsulta";
            this.lblPesquisarConsulta.Size = new System.Drawing.Size(110, 20);
            this.lblPesquisarConsulta.TabIndex = 30;
            this.lblPesquisarConsulta.Text = "Pesquisar por:";
            // 
            // lblAcaoConsulta
            // 
            this.lblAcaoConsulta.AutoSize = true;
            this.lblAcaoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcaoConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAcaoConsulta.Location = new System.Drawing.Point(355, 58);
            this.lblAcaoConsulta.Name = "lblAcaoConsulta";
            this.lblAcaoConsulta.Size = new System.Drawing.Size(99, 18);
            this.lblAcaoConsulta.TabIndex = 31;
            this.lblAcaoConsulta.Text = "Tipo de Ação:";
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(638, 409);
            this.Controls.Add(this.lblAcaoConsulta);
            this.Controls.Add(this.lblPesquisarConsulta);
            this.Controls.Add(this.lblDataConsulta);
            this.Controls.Add(this.cboAcao);
            this.Controls.Add(this.bntPesquisar5);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.bntDeletar5);
            this.Controls.Add(this.bntLimpar5);
            this.Controls.Add(this.txtUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button bntLimpar5;
        private System.Windows.Forms.Button bntDeletar5;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button bntPesquisar5;
        private System.Windows.Forms.ComboBox cboAcao;
        private System.Windows.Forms.Label lblDataConsulta;
        private System.Windows.Forms.Label lblPesquisarConsulta;
        private System.Windows.Forms.Label lblAcaoConsulta;
    }
}