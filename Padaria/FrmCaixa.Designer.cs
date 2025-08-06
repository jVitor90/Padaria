namespace Padaria
{
    partial class FrmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaixa));
            this.DgvListaComandas = new System.Windows.Forms.DataGridView();
            this.TxtbNumComanda = new System.Windows.Forms.TextBox();
            this.LblComanda = new System.Windows.Forms.Label();
            this.ChbPagamento = new System.Windows.Forms.CheckBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnEncerrarComanda = new System.Windows.Forms.Button();
            this.LblPreco = new System.Windows.Forms.Label();
            this.PicbLogo = new System.Windows.Forms.PictureBox();
            this.BtnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaComandas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListaComandas
            // 
            this.DgvListaComandas.AllowUserToAddRows = false;
            this.DgvListaComandas.AllowUserToDeleteRows = false;
            this.DgvListaComandas.AllowUserToResizeColumns = false;
            this.DgvListaComandas.AllowUserToResizeRows = false;
            this.DgvListaComandas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListaComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaComandas.Location = new System.Drawing.Point(12, 50);
            this.DgvListaComandas.Name = "DgvListaComandas";
            this.DgvListaComandas.Size = new System.Drawing.Size(587, 195);
            this.DgvListaComandas.TabIndex = 10;
            // 
            // TxtbNumComanda
            // 
            this.TxtbNumComanda.BackColor = System.Drawing.Color.White;
            this.TxtbNumComanda.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.TxtbNumComanda.Location = new System.Drawing.Point(125, 12);
            this.TxtbNumComanda.Multiline = true;
            this.TxtbNumComanda.Name = "TxtbNumComanda";
            this.TxtbNumComanda.Size = new System.Drawing.Size(167, 29);
            this.TxtbNumComanda.TabIndex = 1;
            // 
            // LblComanda
            // 
            this.LblComanda.AutoSize = true;
            this.LblComanda.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComanda.Location = new System.Drawing.Point(15, 12);
            this.LblComanda.Name = "LblComanda";
            this.LblComanda.Size = new System.Drawing.Size(104, 27);
            this.LblComanda.TabIndex = 2;
            this.LblComanda.Text = "Comanda";
            // 
            // ChbPagamento
            // 
            this.ChbPagamento.AutoSize = true;
            this.ChbPagamento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbPagamento.ForeColor = System.Drawing.Color.Black;
            this.ChbPagamento.Location = new System.Drawing.Point(360, 329);
            this.ChbPagamento.Name = "ChbPagamento";
            this.ChbPagamento.Size = new System.Drawing.Size(153, 23);
            this.ChbPagamento.TabIndex = 11;
            this.ChbPagamento.Text = "Pagamento realizado";
            this.ChbPagamento.UseVisualStyleBackColor = true;
            this.ChbPagamento.CheckedChanged += new System.EventHandler(this.ChbPagamento_CheckedChanged);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(355, 288);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(71, 25);
            this.LblTotal.TabIndex = 12;
            this.LblTotal.Text = "Valor: ";
            // 
            // BtnEncerrarComanda
            // 
            this.BtnEncerrarComanda.BackColor = System.Drawing.Color.Black;
            this.BtnEncerrarComanda.Enabled = false;
            this.BtnEncerrarComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEncerrarComanda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEncerrarComanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnEncerrarComanda.Location = new System.Drawing.Point(360, 370);
            this.BtnEncerrarComanda.Name = "BtnEncerrarComanda";
            this.BtnEncerrarComanda.Size = new System.Drawing.Size(184, 40);
            this.BtnEncerrarComanda.TabIndex = 13;
            this.BtnEncerrarComanda.Text = "Encerrar Comanda";
            this.BtnEncerrarComanda.UseVisualStyleBackColor = false;
            this.BtnEncerrarComanda.Click += new System.EventHandler(this.BtnEncerrarComanda_Click);
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreco.Location = new System.Drawing.Point(419, 291);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(33, 22);
            this.LblPreco.TabIndex = 14;
            this.LblPreco.Text = "R$";
            // 
            // PicbLogo
            // 
            this.PicbLogo.Image = global::Padaria.Properties.Resources.shopping_cart;
            this.PicbLogo.Location = new System.Drawing.Point(77, 301);
            this.PicbLogo.Name = "PicbLogo";
            this.PicbLogo.Size = new System.Drawing.Size(169, 109);
            this.PicbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicbLogo.TabIndex = 15;
            this.PicbLogo.TabStop = false;
            // 
            // BtnListar
            // 
            this.BtnListar.BackColor = System.Drawing.Color.Black;
            this.BtnListar.BackgroundImage = global::Padaria.Properties.Resources.arrow_right;
            this.BtnListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnListar.Location = new System.Drawing.Point(298, 12);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(50, 32);
            this.BtnListar.TabIndex = 7;
            this.BtnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnListar.UseVisualStyleBackColor = false;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(611, 437);
            this.Controls.Add(this.PicbLogo);
            this.Controls.Add(this.LblPreco);
            this.Controls.Add(this.BtnEncerrarComanda);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.ChbPagamento);
            this.Controls.Add(this.LblComanda);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.TxtbNumComanda);
            this.Controls.Add(this.DgvListaComandas);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCaixa";
            this.Text = "FrmCaixa";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaComandas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaComandas;
        private System.Windows.Forms.TextBox TxtbNumComanda;
        private System.Windows.Forms.Label LblComanda;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.CheckBox ChbPagamento;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnEncerrarComanda;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.PictureBox PicbLogo;
    }
}