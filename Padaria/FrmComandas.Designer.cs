namespace Padaria
{
    partial class FrmComandas
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
            this.DgvComandas = new System.Windows.Forms.DataGridView();
            this.TxtbComandas = new System.Windows.Forms.TextBox();
            this.LblComanda = new System.Windows.Forms.Label();
            this.TxtbProdutos = new System.Windows.Forms.TextBox();
            this.TxtbQuantidades = new System.Windows.Forms.TextBox();
            this.LblProduto = new System.Windows.Forms.Label();
            this.LblQuantidade = new System.Windows.Forms.Label();
            this.BtnContinuar = new System.Windows.Forms.Button();
            this.GrbInformações = new System.Windows.Forms.GroupBox();
            this.GrbLancamento = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLancar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComandas)).BeginInit();
            this.GrbInformações.SuspendLayout();
            this.GrbLancamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvComandas
            // 
            this.DgvComandas.AllowUserToAddRows = false;
            this.DgvComandas.AllowUserToDeleteRows = false;
            this.DgvComandas.AllowUserToResizeColumns = false;
            this.DgvComandas.AllowUserToResizeRows = false;
            this.DgvComandas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvComandas.Location = new System.Drawing.Point(413, 20);
            this.DgvComandas.Name = "DgvComandas";
            this.DgvComandas.Size = new System.Drawing.Size(373, 453);
            this.DgvComandas.TabIndex = 0;
            this.DgvComandas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvComandas_CellClick);
            // 
            // TxtbComandas
            // 
            this.TxtbComandas.BackColor = System.Drawing.Color.White;
            this.TxtbComandas.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.TxtbComandas.Location = new System.Drawing.Point(143, 34);
            this.TxtbComandas.Multiline = true;
            this.TxtbComandas.Name = "TxtbComandas";
            this.TxtbComandas.Size = new System.Drawing.Size(214, 36);
            this.TxtbComandas.TabIndex = 1;
            // 
            // LblComanda
            // 
            this.LblComanda.AutoSize = true;
            this.LblComanda.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComanda.Location = new System.Drawing.Point(11, 43);
            this.LblComanda.Name = "LblComanda";
            this.LblComanda.Size = new System.Drawing.Size(104, 27);
            this.LblComanda.TabIndex = 2;
            this.LblComanda.Text = "Comanda";
            // 
            // TxtbProdutos
            // 
            this.TxtbProdutos.BackColor = System.Drawing.Color.White;
            this.TxtbProdutos.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbProdutos.Location = new System.Drawing.Point(136, 34);
            this.TxtbProdutos.Multiline = true;
            this.TxtbProdutos.Name = "TxtbProdutos";
            this.TxtbProdutos.Size = new System.Drawing.Size(214, 36);
            this.TxtbProdutos.TabIndex = 3;
            // 
            // TxtbQuantidades
            // 
            this.TxtbQuantidades.BackColor = System.Drawing.Color.White;
            this.TxtbQuantidades.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbQuantidades.Location = new System.Drawing.Point(136, 118);
            this.TxtbQuantidades.Multiline = true;
            this.TxtbQuantidades.Name = "TxtbQuantidades";
            this.TxtbQuantidades.Size = new System.Drawing.Size(214, 36);
            this.TxtbQuantidades.TabIndex = 4;
            // 
            // LblProduto
            // 
            this.LblProduto.AutoSize = true;
            this.LblProduto.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProduto.Location = new System.Drawing.Point(27, 45);
            this.LblProduto.Name = "LblProduto";
            this.LblProduto.Size = new System.Drawing.Size(89, 27);
            this.LblProduto.TabIndex = 5;
            this.LblProduto.Text = "Produto";
            // 
            // LblQuantidade
            // 
            this.LblQuantidade.AutoSize = true;
            this.LblQuantidade.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantidade.Location = new System.Drawing.Point(11, 127);
            this.LblQuantidade.Name = "LblQuantidade";
            this.LblQuantidade.Size = new System.Drawing.Size(123, 27);
            this.LblQuantidade.TabIndex = 6;
            this.LblQuantidade.Text = "Quantidade";
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.BackColor = System.Drawing.Color.Black;
            this.BtnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContinuar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinuar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnContinuar.Location = new System.Drawing.Point(17, 104);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(340, 37);
            this.BtnContinuar.TabIndex = 7;
            this.BtnContinuar.Text = "Continuar";
            this.BtnContinuar.UseVisualStyleBackColor = false;
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            // 
            // GrbInformações
            // 
            this.GrbInformações.Controls.Add(this.BtnContinuar);
            this.GrbInformações.Controls.Add(this.LblComanda);
            this.GrbInformações.Controls.Add(this.TxtbComandas);
            this.GrbInformações.Location = new System.Drawing.Point(12, 12);
            this.GrbInformações.Name = "GrbInformações";
            this.GrbInformações.Size = new System.Drawing.Size(379, 175);
            this.GrbInformações.TabIndex = 8;
            this.GrbInformações.TabStop = false;
            this.GrbInformações.Text = "Informações";
            // 
            // GrbLancamento
            // 
            this.GrbLancamento.Controls.Add(this.BtnCancelar);
            this.GrbLancamento.Controls.Add(this.BtnLancar);
            this.GrbLancamento.Controls.Add(this.LblQuantidade);
            this.GrbLancamento.Controls.Add(this.LblProduto);
            this.GrbLancamento.Controls.Add(this.TxtbQuantidades);
            this.GrbLancamento.Controls.Add(this.TxtbProdutos);
            this.GrbLancamento.Location = new System.Drawing.Point(12, 193);
            this.GrbLancamento.Name = "GrbLancamento";
            this.GrbLancamento.Size = new System.Drawing.Size(379, 258);
            this.GrbLancamento.TabIndex = 9;
            this.GrbLancamento.TabStop = false;
            this.GrbLancamento.Text = "Lançamentos";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Black;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCancelar.Location = new System.Drawing.Point(206, 194);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(144, 37);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar ";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnLancar
            // 
            this.BtnLancar.BackColor = System.Drawing.Color.Black;
            this.BtnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLancar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLancar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnLancar.Location = new System.Drawing.Point(17, 194);
            this.BtnLancar.Name = "BtnLancar";
            this.BtnLancar.Size = new System.Drawing.Size(144, 37);
            this.BtnLancar.TabIndex = 8;
            this.BtnLancar.Text = "Lançar";
            this.BtnLancar.UseVisualStyleBackColor = false;
            this.BtnLancar.Click += new System.EventHandler(this.BtnLancar_Click);
            // 
            // FrmComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.GrbLancamento);
            this.Controls.Add(this.GrbInformações);
            this.Controls.Add(this.DgvComandas);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmComandas";
            this.Text = "FrmComandas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvComandas)).EndInit();
            this.GrbInformações.ResumeLayout(false);
            this.GrbInformações.PerformLayout();
            this.GrbLancamento.ResumeLayout(false);
            this.GrbLancamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvComandas;
        private System.Windows.Forms.TextBox TxtbComandas;
        private System.Windows.Forms.Label LblComanda;
        private System.Windows.Forms.TextBox TxtbProdutos;
        private System.Windows.Forms.TextBox TxtbQuantidades;
        private System.Windows.Forms.Label LblProduto;
        private System.Windows.Forms.Label LblQuantidade;
        private System.Windows.Forms.Button BtnContinuar;
        private System.Windows.Forms.GroupBox GrbInformações;
        private System.Windows.Forms.GroupBox GrbLancamento;
        private System.Windows.Forms.Button BtnLancar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}