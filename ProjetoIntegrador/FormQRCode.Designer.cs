namespace ProjetoIntegrador
{
    partial class FormQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQRCode));
            this.button6 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.bntEditar3 = new System.Windows.Forms.Button();
            this.bntCadastro3 = new System.Windows.Forms.Button();
            this.btnLimpar3 = new System.Windows.Forms.Button();
            this.btnDeletar3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDMotoboy1 = new System.Windows.Forms.TextBox();
            this.txtNomeMotoboy = new System.Windows.Forms.TextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(431, -79);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(227, 23);
            this.button6.TabIndex = 43;
            this.button6.Text = "Pesquisa";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.Gray;
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(399, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(227, 288);
            this.listBox3.TabIndex = 40;
            // 
            // bntEditar3
            // 
            this.bntEditar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bntEditar3.FlatAppearance.BorderSize = 0;
            this.bntEditar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntEditar3.Location = new System.Drawing.Point(163, 343);
            this.bntEditar3.Name = "bntEditar3";
            this.bntEditar3.Size = new System.Drawing.Size(81, 45);
            this.bntEditar3.TabIndex = 49;
            this.bntEditar3.Text = "Editar";
            this.bntEditar3.UseVisualStyleBackColor = false;
            // 
            // bntCadastro3
            // 
            this.bntCadastro3.BackColor = System.Drawing.Color.Lime;
            this.bntCadastro3.FlatAppearance.BorderSize = 0;
            this.bntCadastro3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCadastro3.Location = new System.Drawing.Point(30, 343);
            this.bntCadastro3.Name = "bntCadastro3";
            this.bntCadastro3.Size = new System.Drawing.Size(81, 45);
            this.bntCadastro3.TabIndex = 47;
            this.bntCadastro3.Text = "Cadastro";
            this.bntCadastro3.UseVisualStyleBackColor = false;
            // 
            // btnLimpar3
            // 
            this.btnLimpar3.BackColor = System.Drawing.Color.LightCoral;
            this.btnLimpar3.FlatAppearance.BorderSize = 0;
            this.btnLimpar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar3.Location = new System.Drawing.Point(399, 343);
            this.btnLimpar3.Name = "btnLimpar3";
            this.btnLimpar3.Size = new System.Drawing.Size(81, 45);
            this.btnLimpar3.TabIndex = 46;
            this.btnLimpar3.Text = "Limpar";
            this.btnLimpar3.UseVisualStyleBackColor = false;
            // 
            // btnDeletar3
            // 
            this.btnDeletar3.BackColor = System.Drawing.Color.Red;
            this.btnDeletar3.FlatAppearance.BorderSize = 0;
            this.btnDeletar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar3.Location = new System.Drawing.Point(545, 343);
            this.btnDeletar3.Name = "btnDeletar3";
            this.btnDeletar3.Size = new System.Drawing.Size(81, 45);
            this.btnDeletar3.TabIndex = 45;
            this.btnDeletar3.Text = "Deletar";
            this.btnDeletar3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID_Motoboy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nome_Motoboy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "ID_Contato_Motoboy";
            // 
            // txtIDMotoboy1
            // 
            this.txtIDMotoboy1.Location = new System.Drawing.Point(30, 41);
            this.txtIDMotoboy1.Name = "txtIDMotoboy1";
            this.txtIDMotoboy1.Size = new System.Drawing.Size(100, 20);
            this.txtIDMotoboy1.TabIndex = 35;
            // 
            // txtNomeMotoboy
            // 
            this.txtNomeMotoboy.Location = new System.Drawing.Point(30, 109);
            this.txtNomeMotoboy.Name = "txtNomeMotoboy";
            this.txtNomeMotoboy.Size = new System.Drawing.Size(100, 20);
            this.txtNomeMotoboy.TabIndex = 36;
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(30, 194);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(100, 20);
            this.txtContato.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Status";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Ativo ",
            " Inativo"});
            this.cboStatus.Location = new System.Drawing.Point(30, 279);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 50;
            // 
            // FormQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(638, 409);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.bntEditar3);
            this.Controls.Add(this.bntCadastro3);
            this.Controls.Add(this.btnLimpar3);
            this.Controls.Add(this.btnDeletar3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.txtNomeMotoboy);
            this.Controls.Add(this.txtIDMotoboy1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQRCode";
            this.Text = "FormQRCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button bntEditar3;
        private System.Windows.Forms.Button bntCadastro3;
        private System.Windows.Forms.Button btnLimpar3;
        private System.Windows.Forms.Button btnDeletar3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDMotoboy1;
        private System.Windows.Forms.TextBox txtNomeMotoboy;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboStatus;
    }
}