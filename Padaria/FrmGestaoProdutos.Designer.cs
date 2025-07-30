namespace Padaria
{
    partial class FrmGestaoProdutos
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
            this.GrbApagarProduto = new System.Windows.Forms.GroupBox();
            this.LblApagar = new System.Windows.Forms.Label();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.GrbEditarProduto = new System.Windows.Forms.GroupBox();
            this.TxtbEditarCategoria = new System.Windows.Forms.TextBox();
            this.LblEditarCategoria = new System.Windows.Forms.Label();
            this.LblPrecoProduto = new System.Windows.Forms.Label();
            this.BtnEditarEmail = new System.Windows.Forms.Button();
            this.LblNomeProduto = new System.Windows.Forms.Label();
            this.TxtbEditarNomeProduto = new System.Windows.Forms.TextBox();
            this.TxtbEditarPreco = new System.Windows.Forms.TextBox();
            this.GrbCadastrarProduto = new System.Windows.Forms.GroupBox();
            this.TxtbCadastrarCategoria = new System.Windows.Forms.TextBox();
            this.LblCadastrarCategoria = new System.Windows.Forms.Label();
            this.BtnCadastrarProdutos = new System.Windows.Forms.Button();
            this.TxtbCadastrarPreco = new System.Windows.Forms.TextBox();
            this.TxtbCadastrarNomeProduto = new System.Windows.Forms.TextBox();
            this.LblCadastrarPreco = new System.Windows.Forms.Label();
            this.LblCadastrarProdutos = new System.Windows.Forms.Label();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.GrbApagarProduto.SuspendLayout();
            this.GrbEditarProduto.SuspendLayout();
            this.GrbCadastrarProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbApagarProduto
            // 
            this.GrbApagarProduto.BackColor = System.Drawing.Color.White;
            this.GrbApagarProduto.Controls.Add(this.LblApagar);
            this.GrbApagarProduto.Controls.Add(this.BtnApagar);
            this.GrbApagarProduto.Enabled = false;
            this.GrbApagarProduto.Location = new System.Drawing.Point(497, 398);
            this.GrbApagarProduto.Name = "GrbApagarProduto";
            this.GrbApagarProduto.Size = new System.Drawing.Size(356, 125);
            this.GrbApagarProduto.TabIndex = 5;
            this.GrbApagarProduto.TabStop = false;
            this.GrbApagarProduto.Text = "Apagar";
            // 
            // LblApagar
            // 
            this.LblApagar.AutoSize = true;
            this.LblApagar.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApagar.Location = new System.Drawing.Point(19, 33);
            this.LblApagar.Name = "LblApagar";
            this.LblApagar.Size = new System.Drawing.Size(303, 21);
            this.LblApagar.TabIndex = 12;
            this.LblApagar.Text = "Selecione o produto que deseja apagar ";
            // 
            // BtnApagar
            // 
            this.BtnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApagar.Location = new System.Drawing.Point(23, 70);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(301, 30);
            this.BtnApagar.TabIndex = 0;
            this.BtnApagar.Text = "Apagar";
            this.BtnApagar.UseVisualStyleBackColor = false;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // GrbEditarProduto
            // 
            this.GrbEditarProduto.BackColor = System.Drawing.Color.White;
            this.GrbEditarProduto.Controls.Add(this.TxtbEditarCategoria);
            this.GrbEditarProduto.Controls.Add(this.LblEditarCategoria);
            this.GrbEditarProduto.Controls.Add(this.LblPrecoProduto);
            this.GrbEditarProduto.Controls.Add(this.BtnEditarEmail);
            this.GrbEditarProduto.Controls.Add(this.LblNomeProduto);
            this.GrbEditarProduto.Controls.Add(this.TxtbEditarNomeProduto);
            this.GrbEditarProduto.Controls.Add(this.TxtbEditarPreco);
            this.GrbEditarProduto.Enabled = false;
            this.GrbEditarProduto.Location = new System.Drawing.Point(497, 208);
            this.GrbEditarProduto.Name = "GrbEditarProduto";
            this.GrbEditarProduto.Size = new System.Drawing.Size(356, 184);
            this.GrbEditarProduto.TabIndex = 4;
            this.GrbEditarProduto.TabStop = false;
            this.GrbEditarProduto.Text = "Editar";
            // 
            // TxtbEditarCategoria
            // 
            this.TxtbEditarCategoria.Location = new System.Drawing.Point(162, 103);
            this.TxtbEditarCategoria.Name = "TxtbEditarCategoria";
            this.TxtbEditarCategoria.Size = new System.Drawing.Size(175, 20);
            this.TxtbEditarCategoria.TabIndex = 19;
            // 
            // LblEditarCategoria
            // 
            this.LblEditarCategoria.AutoSize = true;
            this.LblEditarCategoria.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditarCategoria.Location = new System.Drawing.Point(49, 102);
            this.LblEditarCategoria.Name = "LblEditarCategoria";
            this.LblEditarCategoria.Size = new System.Drawing.Size(77, 20);
            this.LblEditarCategoria.TabIndex = 18;
            this.LblEditarCategoria.Text = "Categoria";
            // 
            // LblPrecoProduto
            // 
            this.LblPrecoProduto.AutoSize = true;
            this.LblPrecoProduto.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecoProduto.Location = new System.Drawing.Point(14, 61);
            this.LblPrecoProduto.Name = "LblPrecoProduto";
            this.LblPrecoProduto.Size = new System.Drawing.Size(137, 20);
            this.LblPrecoProduto.TabIndex = 15;
            this.LblPrecoProduto.Text = "Preço do Produto";
            // 
            // BtnEditarEmail
            // 
            this.BtnEditarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnEditarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarEmail.Location = new System.Drawing.Point(10, 137);
            this.BtnEditarEmail.Name = "BtnEditarEmail";
            this.BtnEditarEmail.Size = new System.Drawing.Size(327, 32);
            this.BtnEditarEmail.TabIndex = 14;
            this.BtnEditarEmail.Text = "Editar";
            this.BtnEditarEmail.UseVisualStyleBackColor = false;
            this.BtnEditarEmail.Click += new System.EventHandler(this.BtnEditarEmail_Click);
            // 
            // LblNomeProduto
            // 
            this.LblNomeProduto.AutoSize = true;
            this.LblNomeProduto.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeProduto.Location = new System.Drawing.Point(6, 22);
            this.LblNomeProduto.Name = "LblNomeProduto";
            this.LblNomeProduto.Size = new System.Drawing.Size(146, 20);
            this.LblNomeProduto.TabIndex = 14;
            this.LblNomeProduto.Text = "Nome do Produtos";
            // 
            // TxtbEditarNomeProduto
            // 
            this.TxtbEditarNomeProduto.Location = new System.Drawing.Point(162, 22);
            this.TxtbEditarNomeProduto.Name = "TxtbEditarNomeProduto";
            this.TxtbEditarNomeProduto.Size = new System.Drawing.Size(175, 20);
            this.TxtbEditarNomeProduto.TabIndex = 9;
            // 
            // TxtbEditarPreco
            // 
            this.TxtbEditarPreco.Location = new System.Drawing.Point(162, 62);
            this.TxtbEditarPreco.Name = "TxtbEditarPreco";
            this.TxtbEditarPreco.Size = new System.Drawing.Size(175, 20);
            this.TxtbEditarPreco.TabIndex = 10;
            // 
            // GrbCadastrarProduto
            // 
            this.GrbCadastrarProduto.BackColor = System.Drawing.Color.White;
            this.GrbCadastrarProduto.Controls.Add(this.TxtbCadastrarCategoria);
            this.GrbCadastrarProduto.Controls.Add(this.LblCadastrarCategoria);
            this.GrbCadastrarProduto.Controls.Add(this.BtnCadastrarProdutos);
            this.GrbCadastrarProduto.Controls.Add(this.TxtbCadastrarPreco);
            this.GrbCadastrarProduto.Controls.Add(this.TxtbCadastrarNomeProduto);
            this.GrbCadastrarProduto.Controls.Add(this.LblCadastrarPreco);
            this.GrbCadastrarProduto.Controls.Add(this.LblCadastrarProdutos);
            this.GrbCadastrarProduto.Location = new System.Drawing.Point(497, 11);
            this.GrbCadastrarProduto.Name = "GrbCadastrarProduto";
            this.GrbCadastrarProduto.Size = new System.Drawing.Size(356, 191);
            this.GrbCadastrarProduto.TabIndex = 3;
            this.GrbCadastrarProduto.TabStop = false;
            this.GrbCadastrarProduto.Text = "Cadastrar";
            // 
            // TxtbCadastrarCategoria
            // 
            this.TxtbCadastrarCategoria.Location = new System.Drawing.Point(162, 107);
            this.TxtbCadastrarCategoria.Multiline = true;
            this.TxtbCadastrarCategoria.Name = "TxtbCadastrarCategoria";
            this.TxtbCadastrarCategoria.Size = new System.Drawing.Size(175, 20);
            this.TxtbCadastrarCategoria.TabIndex = 18;
            // 
            // LblCadastrarCategoria
            // 
            this.LblCadastrarCategoria.AutoSize = true;
            this.LblCadastrarCategoria.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastrarCategoria.Location = new System.Drawing.Point(49, 106);
            this.LblCadastrarCategoria.Name = "LblCadastrarCategoria";
            this.LblCadastrarCategoria.Size = new System.Drawing.Size(77, 20);
            this.LblCadastrarCategoria.TabIndex = 17;
            this.LblCadastrarCategoria.Text = "Categoria";
            // 
            // BtnCadastrarProdutos
            // 
            this.BtnCadastrarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnCadastrarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrarProdutos.Location = new System.Drawing.Point(15, 143);
            this.BtnCadastrarProdutos.Name = "BtnCadastrarProdutos";
            this.BtnCadastrarProdutos.Size = new System.Drawing.Size(321, 32);
            this.BtnCadastrarProdutos.TabIndex = 13;
            this.BtnCadastrarProdutos.Text = "Cadastrar";
            this.BtnCadastrarProdutos.UseVisualStyleBackColor = false;
            this.BtnCadastrarProdutos.Click += new System.EventHandler(this.BtnCadastrarProdutos_Click);
            // 
            // TxtbCadastrarPreco
            // 
            this.TxtbCadastrarPreco.Location = new System.Drawing.Point(162, 66);
            this.TxtbCadastrarPreco.Multiline = true;
            this.TxtbCadastrarPreco.Name = "TxtbCadastrarPreco";
            this.TxtbCadastrarPreco.Size = new System.Drawing.Size(175, 20);
            this.TxtbCadastrarPreco.TabIndex = 4;
            this.TxtbCadastrarPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtbCadastrarPreco_KeyPress);
            // 
            // TxtbCadastrarNomeProduto
            // 
            this.TxtbCadastrarNomeProduto.Location = new System.Drawing.Point(162, 29);
            this.TxtbCadastrarNomeProduto.Name = "TxtbCadastrarNomeProduto";
            this.TxtbCadastrarNomeProduto.Size = new System.Drawing.Size(175, 20);
            this.TxtbCadastrarNomeProduto.TabIndex = 3;
            this.TxtbCadastrarNomeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtbCadastrarProduto_KeyPress);
            // 
            // LblCadastrarPreco
            // 
            this.LblCadastrarPreco.AutoSize = true;
            this.LblCadastrarPreco.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastrarPreco.Location = new System.Drawing.Point(19, 66);
            this.LblCadastrarPreco.Name = "LblCadastrarPreco";
            this.LblCadastrarPreco.Size = new System.Drawing.Size(137, 20);
            this.LblCadastrarPreco.TabIndex = 1;
            this.LblCadastrarPreco.Text = "Preço do Produto";
            // 
            // LblCadastrarProdutos
            // 
            this.LblCadastrarProdutos.AutoSize = true;
            this.LblCadastrarProdutos.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastrarProdutos.Location = new System.Drawing.Point(11, 28);
            this.LblCadastrarProdutos.Name = "LblCadastrarProdutos";
            this.LblCadastrarProdutos.Size = new System.Drawing.Size(146, 20);
            this.LblCadastrarProdutos.TabIndex = 0;
            this.LblCadastrarProdutos.Text = "Nome do Produtos";
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.AllowUserToAddRows = false;
            this.DgvProdutos.AllowUserToDeleteRows = false;
            this.DgvProdutos.AllowUserToResizeColumns = false;
            this.DgvProdutos.AllowUserToResizeRows = false;
            this.DgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Location = new System.Drawing.Point(13, 11);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.ReadOnly = true;
            this.DgvProdutos.Size = new System.Drawing.Size(478, 514);
            this.DgvProdutos.TabIndex = 6;
            this.DgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellClick);
            // 
            // FrmGestaoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(865, 537);
            this.Controls.Add(this.DgvProdutos);
            this.Controls.Add(this.GrbApagarProduto);
            this.Controls.Add(this.GrbEditarProduto);
            this.Controls.Add(this.GrbCadastrarProduto);
            this.Name = "FrmGestaoProdutos";
            this.Text = "FrmGestaoProdutos";
            this.GrbApagarProduto.ResumeLayout(false);
            this.GrbApagarProduto.PerformLayout();
            this.GrbEditarProduto.ResumeLayout(false);
            this.GrbEditarProduto.PerformLayout();
            this.GrbCadastrarProduto.ResumeLayout(false);
            this.GrbCadastrarProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbApagarProduto;
        private System.Windows.Forms.Label LblApagar;
        private System.Windows.Forms.Button BtnApagar;
        private System.Windows.Forms.GroupBox GrbEditarProduto;
        private System.Windows.Forms.Button BtnEditarEmail;
        private System.Windows.Forms.TextBox TxtbEditarNomeProduto;
        private System.Windows.Forms.TextBox TxtbEditarPreco;
        private System.Windows.Forms.GroupBox GrbCadastrarProduto;
        private System.Windows.Forms.Button BtnCadastrarProdutos;
        private System.Windows.Forms.TextBox TxtbCadastrarPreco;
        private System.Windows.Forms.TextBox TxtbCadastrarNomeProduto;
        private System.Windows.Forms.Label LblCadastrarPreco;
        private System.Windows.Forms.Label LblCadastrarProdutos;
        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.Label LblPrecoProduto;
        private System.Windows.Forms.Label LblNomeProduto;
        private System.Windows.Forms.Label LblCadastrarCategoria;
        private System.Windows.Forms.Label LblEditarCategoria;
        private System.Windows.Forms.TextBox TxtbCadastrarCategoria;
        private System.Windows.Forms.TextBox TxtbEditarCategoria;
    }
}