﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padaria
{
    public partial class FormMenuPrincipal : Form
    {
        //Variaveis globais 
        Model.Usuario usuario;
        public FormMenuPrincipal(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblUsuarios.Text = $"Você está logado com: {usuario.NomeCompleto}";
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FrmGestaoProdutos frmGestaoProdutos = new FrmGestaoProdutos(usuario);
            frmGestaoProdutos.ShowDialog();
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {
             FrmComandas frmComandas = new FrmComandas(usuario);
            frmComandas.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            FrmCaixa frmCaixa = new FrmCaixa (usuario);
            frmCaixa.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
           FrmGestaoUsuarios frmGestaoUsuarios = new FrmGestaoUsuarios (usuario);
            frmGestaoUsuarios.ShowDialog();
        }
    }
}
