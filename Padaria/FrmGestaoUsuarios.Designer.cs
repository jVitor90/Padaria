namespace Padaria
{
    partial class FrmGestaoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestaoUsuarios));
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.GrbCadastrar = new System.Windows.Forms.GroupBox();
            this.GrbEditar = new System.Windows.Forms.GroupBox();
            this.GrbApagar = new System.Windows.Forms.GroupBox();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.LblCadastrarNome = new System.Windows.Forms.Label();
            this.LblCadastrarEmail = new System.Windows.Forms.Label();
            this.LblCadastrarSenha = new System.Windows.Forms.Label();
            this.TxtbCadastrarNome = new System.Windows.Forms.TextBox();
            this.TxtbCadastrarEmail = new System.Windows.Forms.TextBox();
            this.TxtbCadastrarSenha = new System.Windows.Forms.TextBox();
            this.TxtbEditarSenha = new System.Windows.Forms.TextBox();
            this.TxtbEditarEmail = new System.Windows.Forms.TextBox();
            this.TxtbEditarNome = new System.Windows.Forms.TextBox();
            this.LblEditarSenha = new System.Windows.Forms.Label();
            this.LblEditarEmail = new System.Windows.Forms.Label();
            this.LblEditarNome = new System.Windows.Forms.Label();
            this.LblApagar = new System.Windows.Forms.Label();
            this.BtnCadastrarEmail = new System.Windows.Forms.Button();
            this.BtnEditarEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.GrbCadastrar.SuspendLayout();
            this.GrbEditar.SuspendLayout();
            this.GrbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.AllowUserToResizeColumns = false;
            this.DgvUsuarios.AllowUserToResizeRows = false;
            this.DgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(14, 23);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.Size = new System.Drawing.Size(702, 201);
            this.DgvUsuarios.TabIndex = 0;
            this.DgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellClick);
            // 
            // GrbCadastrar
            // 
            this.GrbCadastrar.BackColor = System.Drawing.Color.White;
            this.GrbCadastrar.Controls.Add(this.BtnCadastrarEmail);
            this.GrbCadastrar.Controls.Add(this.TxtbCadastrarSenha);
            this.GrbCadastrar.Controls.Add(this.TxtbCadastrarEmail);
            this.GrbCadastrar.Controls.Add(this.TxtbCadastrarNome);
            this.GrbCadastrar.Controls.Add(this.LblCadastrarSenha);
            this.GrbCadastrar.Controls.Add(this.LblCadastrarEmail);
            this.GrbCadastrar.Controls.Add(this.LblCadastrarNome);
            this.GrbCadastrar.Location = new System.Drawing.Point(40, 255);
            this.GrbCadastrar.Name = "GrbCadastrar";
            this.GrbCadastrar.Size = new System.Drawing.Size(287, 181);
            this.GrbCadastrar.TabIndex = 1;
            this.GrbCadastrar.TabStop = false;
            this.GrbCadastrar.Text = "Cadastrar";
            // 
            // GrbEditar
            // 
            this.GrbEditar.BackColor = System.Drawing.Color.White;
            this.GrbEditar.Controls.Add(this.BtnEditarEmail);
            this.GrbEditar.Controls.Add(this.TxtbEditarSenha);
            this.GrbEditar.Controls.Add(this.TxtbEditarNome);
            this.GrbEditar.Controls.Add(this.TxtbEditarEmail);
            this.GrbEditar.Controls.Add(this.LblEditarNome);
            this.GrbEditar.Controls.Add(this.LblEditarEmail);
            this.GrbEditar.Controls.Add(this.LblEditarSenha);
            this.GrbEditar.Enabled = false;
            this.GrbEditar.Location = new System.Drawing.Point(429, 255);
            this.GrbEditar.Name = "GrbEditar";
            this.GrbEditar.Size = new System.Drawing.Size(287, 181);
            this.GrbEditar.TabIndex = 2;
            this.GrbEditar.TabStop = false;
            this.GrbEditar.Text = "Editar";
            // 
            // GrbApagar
            // 
            this.GrbApagar.BackColor = System.Drawing.Color.White;
            this.GrbApagar.Controls.Add(this.LblApagar);
            this.GrbApagar.Controls.Add(this.BtnApagar);
            this.GrbApagar.Enabled = false;
            this.GrbApagar.Location = new System.Drawing.Point(40, 442);
            this.GrbApagar.Name = "GrbApagar";
            this.GrbApagar.Size = new System.Drawing.Size(676, 99);
            this.GrbApagar.TabIndex = 2;
            this.GrbApagar.TabStop = false;
            this.GrbApagar.Text = "Apagar";
            // 
            // BtnApagar
            // 
            this.BtnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApagar.Location = new System.Drawing.Point(448, 19);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(196, 46);
            this.BtnApagar.TabIndex = 0;
            this.BtnApagar.Text = "Apagar";
            this.BtnApagar.UseVisualStyleBackColor = false;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // LblCadastrarNome
            // 
            this.LblCadastrarNome.AutoSize = true;
            this.LblCadastrarNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastrarNome.Location = new System.Drawing.Point(9, 40);
            this.LblCadastrarNome.Name = "LblCadastrarNome";
            this.LblCadastrarNome.Size = new System.Drawing.Size(111, 19);
            this.LblCadastrarNome.TabIndex = 0;
            this.LblCadastrarNome.Text = "Nome Completo";
            // 
            // LblCadastrarEmail
            // 
            this.LblCadastrarEmail.AutoSize = true;
            this.LblCadastrarEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastrarEmail.Location = new System.Drawing.Point(52, 68);
            this.LblCadastrarEmail.Name = "LblCadastrarEmail";
            this.LblCadastrarEmail.Size = new System.Drawing.Size(48, 19);
            this.LblCadastrarEmail.TabIndex = 1;
            this.LblCadastrarEmail.Text = "E-mail";
            // 
            // LblCadastrarSenha
            // 
            this.LblCadastrarSenha.AutoSize = true;
            this.LblCadastrarSenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastrarSenha.Location = new System.Drawing.Point(52, 93);
            this.LblCadastrarSenha.Name = "LblCadastrarSenha";
            this.LblCadastrarSenha.Size = new System.Drawing.Size(46, 19);
            this.LblCadastrarSenha.TabIndex = 2;
            this.LblCadastrarSenha.Text = "Senha";
            // 
            // TxtbCadastrarNome
            // 
            this.TxtbCadastrarNome.Location = new System.Drawing.Point(125, 40);
            this.TxtbCadastrarNome.Name = "TxtbCadastrarNome";
            this.TxtbCadastrarNome.Size = new System.Drawing.Size(143, 20);
            this.TxtbCadastrarNome.TabIndex = 3;
            // 
            // TxtbCadastrarEmail
            // 
            this.TxtbCadastrarEmail.Location = new System.Drawing.Point(125, 68);
            this.TxtbCadastrarEmail.Name = "TxtbCadastrarEmail";
            this.TxtbCadastrarEmail.Size = new System.Drawing.Size(143, 20);
            this.TxtbCadastrarEmail.TabIndex = 4;
            // 
            // TxtbCadastrarSenha
            // 
            this.TxtbCadastrarSenha.Location = new System.Drawing.Point(125, 94);
            this.TxtbCadastrarSenha.Name = "TxtbCadastrarSenha";
            this.TxtbCadastrarSenha.Size = new System.Drawing.Size(143, 20);
            this.TxtbCadastrarSenha.TabIndex = 5;
            // 
            // TxtbEditarSenha
            // 
            this.TxtbEditarSenha.Location = new System.Drawing.Point(128, 95);
            this.TxtbEditarSenha.Name = "TxtbEditarSenha";
            this.TxtbEditarSenha.Size = new System.Drawing.Size(143, 20);
            this.TxtbEditarSenha.TabIndex = 11;
            // 
            // TxtbEditarEmail
            // 
            this.TxtbEditarEmail.Location = new System.Drawing.Point(128, 69);
            this.TxtbEditarEmail.Name = "TxtbEditarEmail";
            this.TxtbEditarEmail.Size = new System.Drawing.Size(143, 20);
            this.TxtbEditarEmail.TabIndex = 10;
            // 
            // TxtbEditarNome
            // 
            this.TxtbEditarNome.Location = new System.Drawing.Point(128, 41);
            this.TxtbEditarNome.Name = "TxtbEditarNome";
            this.TxtbEditarNome.Size = new System.Drawing.Size(143, 20);
            this.TxtbEditarNome.TabIndex = 9;
            // 
            // LblEditarSenha
            // 
            this.LblEditarSenha.AutoSize = true;
            this.LblEditarSenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditarSenha.Location = new System.Drawing.Point(55, 94);
            this.LblEditarSenha.Name = "LblEditarSenha";
            this.LblEditarSenha.Size = new System.Drawing.Size(46, 19);
            this.LblEditarSenha.TabIndex = 8;
            this.LblEditarSenha.Text = "Senha";
            // 
            // LblEditarEmail
            // 
            this.LblEditarEmail.AutoSize = true;
            this.LblEditarEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditarEmail.Location = new System.Drawing.Point(55, 69);
            this.LblEditarEmail.Name = "LblEditarEmail";
            this.LblEditarEmail.Size = new System.Drawing.Size(48, 19);
            this.LblEditarEmail.TabIndex = 7;
            this.LblEditarEmail.Text = "E-mail";
            // 
            // LblEditarNome
            // 
            this.LblEditarNome.AutoSize = true;
            this.LblEditarNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditarNome.Location = new System.Drawing.Point(12, 41);
            this.LblEditarNome.Name = "LblEditarNome";
            this.LblEditarNome.Size = new System.Drawing.Size(111, 19);
            this.LblEditarNome.TabIndex = 6;
            this.LblEditarNome.Text = "Nome Completo";
            // 
            // LblApagar
            // 
            this.LblApagar.AutoSize = true;
            this.LblApagar.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApagar.Location = new System.Drawing.Point(37, 30);
            this.LblApagar.Name = "LblApagar";
            this.LblApagar.Size = new System.Drawing.Size(321, 22);
            this.LblApagar.TabIndex = 12;
            this.LblApagar.Text = "Selecione o produto que deseja apagar ";
            // 
            // BtnCadastrarEmail
            // 
            this.BtnCadastrarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnCadastrarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrarEmail.Location = new System.Drawing.Point(13, 132);
            this.BtnCadastrarEmail.Name = "BtnCadastrarEmail";
            this.BtnCadastrarEmail.Size = new System.Drawing.Size(255, 32);
            this.BtnCadastrarEmail.TabIndex = 13;
            this.BtnCadastrarEmail.Text = "Cadastrar";
            this.BtnCadastrarEmail.UseVisualStyleBackColor = false;
            this.BtnCadastrarEmail.Click += new System.EventHandler(this.BtnCadastrarEmail_Click);
            // 
            // BtnEditarEmail
            // 
            this.BtnEditarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnEditarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarEmail.Location = new System.Drawing.Point(16, 132);
            this.BtnEditarEmail.Name = "BtnEditarEmail";
            this.BtnEditarEmail.Size = new System.Drawing.Size(255, 32);
            this.BtnEditarEmail.TabIndex = 14;
            this.BtnEditarEmail.Text = "Editar";
            this.BtnEditarEmail.UseVisualStyleBackColor = false;
            this.BtnEditarEmail.Click += new System.EventHandler(this.BtnEditarEmail_Click);
            // 
            // FrmGestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(740, 553);
            this.Controls.Add(this.GrbApagar);
            this.Controls.Add(this.GrbEditar);
            this.Controls.Add(this.GrbCadastrar);
            this.Controls.Add(this.DgvUsuarios);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestaoUsuarios";
            this.Text = "FrmGestaoUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.GrbCadastrar.ResumeLayout(false);
            this.GrbCadastrar.PerformLayout();
            this.GrbEditar.ResumeLayout(false);
            this.GrbEditar.PerformLayout();
            this.GrbApagar.ResumeLayout(false);
            this.GrbApagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.GroupBox GrbCadastrar;
        private System.Windows.Forms.GroupBox GrbEditar;
        private System.Windows.Forms.GroupBox GrbApagar;
        private System.Windows.Forms.Button BtnApagar;
        private System.Windows.Forms.Label LblCadastrarSenha;
        private System.Windows.Forms.Label LblCadastrarEmail;
        private System.Windows.Forms.Label LblCadastrarNome;
        private System.Windows.Forms.TextBox TxtbCadastrarSenha;
        private System.Windows.Forms.TextBox TxtbCadastrarEmail;
        private System.Windows.Forms.TextBox TxtbCadastrarNome;
        private System.Windows.Forms.TextBox TxtbEditarSenha;
        private System.Windows.Forms.TextBox TxtbEditarNome;
        private System.Windows.Forms.TextBox TxtbEditarEmail;
        private System.Windows.Forms.Label LblEditarNome;
        private System.Windows.Forms.Label LblEditarEmail;
        private System.Windows.Forms.Label LblEditarSenha;
        private System.Windows.Forms.Label LblApagar;
        private System.Windows.Forms.Button BtnCadastrarEmail;
        private System.Windows.Forms.Button BtnEditarEmail;
    }
}