namespace Padaria
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnCaixa = new System.Windows.Forms.Button();
            this.BtnComandas = new System.Windows.Forms.Button();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.PicLogo2 = new System.Windows.Forms.PictureBox();
            this.lblUsuarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Location = new System.Drawing.Point(271, 256);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(396, 50);
            this.BtnUsuarios.TabIndex = 10;
            this.BtnUsuarios.Text = "Gestão de Usuários";
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            this.BtnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // BtnCaixa
            // 
            this.BtnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCaixa.Location = new System.Drawing.Point(271, 200);
            this.BtnCaixa.Name = "BtnCaixa";
            this.BtnCaixa.Size = new System.Drawing.Size(396, 50);
            this.BtnCaixa.TabIndex = 9;
            this.BtnCaixa.Text = "Caixa";
            this.BtnCaixa.UseVisualStyleBackColor = true;
            this.BtnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // BtnComandas
            // 
            this.BtnComandas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComandas.Location = new System.Drawing.Point(271, 144);
            this.BtnComandas.Name = "BtnComandas";
            this.BtnComandas.Size = new System.Drawing.Size(396, 50);
            this.BtnComandas.TabIndex = 8;
            this.BtnComandas.Text = "Lançamento de Comandas";
            this.BtnComandas.UseVisualStyleBackColor = true;
            this.BtnComandas.Click += new System.EventHandler(this.btnComandas_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdutos.Location = new System.Drawing.Point(271, 88);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(396, 50);
            this.BtnProdutos.TabIndex = 7;
            this.BtnProdutos.Text = "Gestão de Produtos";
            this.BtnProdutos.UseVisualStyleBackColor = true;
            this.BtnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Square721 BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(347, 25);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(241, 40);
            this.lblMenu.TabIndex = 6;
            this.lblMenu.Text = "Menu Principal";
            // 
            // PicLogo2
            // 
            this.PicLogo2.Image = global::Padaria.Properties.Resources.bread;
            this.PicLogo2.Location = new System.Drawing.Point(15, 88);
            this.PicLogo2.Name = "PicLogo2";
            this.PicLogo2.Size = new System.Drawing.Size(200, 218);
            this.PicLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo2.TabIndex = 11;
            this.PicLogo2.TabStop = false;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsuarios.Location = new System.Drawing.Point(12, 348);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(203, 16);
            this.lblUsuarios.TabIndex = 12;
            this.lblUsuarios.Text = "Você está logado como: Usuário";
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(690, 387);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.PicLogo2);
            this.Controls.Add(this.BtnUsuarios);
            this.Controls.Add(this.BtnCaixa);
            this.Controls.Add(this.BtnComandas);
            this.Controls.Add(this.BtnProdutos);
            this.Controls.Add(this.lblMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenuPrincipal";
            this.Text = "FormMenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnCaixa;
        private System.Windows.Forms.Button BtnComandas;
        private System.Windows.Forms.Button BtnProdutos;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox PicLogo2;
        private System.Windows.Forms.Label lblUsuarios;
    }
}