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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.bntLimpar5 = new System.Windows.Forms.Button();
            this.bntDeletar5 = new System.Windows.Forms.Button();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.bntPesquisar5 = new System.Windows.Forms.Button();
            this.cboAcao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
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
            this.bntLimpar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLimpar5.Location = new System.Drawing.Point(19, 392);
            this.bntLimpar5.Name = "bntLimpar5";
            this.bntLimpar5.Size = new System.Drawing.Size(101, 44);
            this.bntLimpar5.TabIndex = 1;
            this.bntLimpar5.Text = "limpar";
            this.bntLimpar5.UseVisualStyleBackColor = false;
            this.bntLimpar5.Click += new System.EventHandler(this.bntLimpar5_Click);
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
            this.bntDeletar5.Location = new System.Drawing.Point(494, 392);
            this.bntDeletar5.Name = "bntDeletar5";
            this.bntDeletar5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bntDeletar5.Size = new System.Drawing.Size(101, 44);
            this.bntDeletar5.TabIndex = 2;
            this.bntDeletar5.Text = "Deletar";
            this.bntDeletar5.UseVisualStyleBackColor = false;
            // 
            // listBox5
            // 
            this.listBox5.BackColor = System.Drawing.Color.Azure;
            this.listBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(0, 148);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(624, 182);
            this.listBox5.TabIndex = 3;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(203, 80);
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
            this.bntPesquisar5.Location = new System.Drawing.Point(520, 12);
            this.bntPesquisar5.Name = "bntPesquisar5";
            this.bntPesquisar5.Size = new System.Drawing.Size(75, 23);
            this.bntPesquisar5.TabIndex = 5;
            this.bntPesquisar5.Text = "Pesquisar";
            this.bntPesquisar5.UseVisualStyleBackColor = false;
            // 
            // cboAcao
            // 
            this.cboAcao.FormattingEnabled = true;
            this.cboAcao.Location = new System.Drawing.Point(349, 79);
            this.cboAcao.Name = "cboAcao";
            this.cboAcao.Size = new System.Drawing.Size(121, 21);
            this.cboAcao.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(200, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Data inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(25, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(356, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ação";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = "5";
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(623, 459);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAcao);
            this.Controls.Add(this.bntPesquisar5);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.bntDeletar5);
            this.Controls.Add(this.bntLimpar5);
            this.Controls.Add(this.txtUsuario);
            this.Name = "FormConsulta";
            this.Text = "FormConsulta";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
    }
}