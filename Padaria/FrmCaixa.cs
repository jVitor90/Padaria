using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Padaria.Model;

namespace Padaria
{
    public partial class FrmCaixa : Form
    {
        //Variaveis globais 
        Model.Usuario usuario;
        Model.OrdemComanda ordemComanda = new OrdemComanda();
        public FrmCaixa(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        public void AtualizarDgv()
        {
            DgvListaComandas.DataSource = ordemComanda.listar();
        }


        private void BtnListar_Click(object sender, EventArgs e)
        {
            if (TxtbNumComanda.Text == "" || TxtbNumComanda.Text.Length <=0 )
            {
                MessageBox.Show("Preencha o número de comanda", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ordemComanda.idFicha = int.Parse(TxtbNumComanda.Text);
                DataTable consulta = ordemComanda.BuscarFicha();

                //Verificar se existe lançamentos na comanda
                if (consulta.Rows.Count == 0)
                {
                    MessageBox.Show("Não existe lançamento nesta comanda", "ERRO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Mostrar no DatagridView
                    DgvListaComandas.DataSource = consulta;
                    //Mostrar no label o total 
                    LblPreco.Text = "R$" + consulta.Compute("Sum(Total_Item)", "true").ToString();

                }
            }
        }

        private void ChbPagamento_CheckedChanged(object sender, EventArgs e)
        {
            //Ativar e desativar o BtnEncerrar
            BtnEncerrarComanda.Enabled = ChbPagamento.Checked; 
        }

        private void BtnEncerrarComanda_Click(object sender, EventArgs e)
        {
            DialogResult pergunta = MessageBox.Show($"Tem certeza que deseja encerrar a comanda {ordemComanda.idFicha}?", 
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(pergunta == DialogResult.Yes)
            {
                if(ordemComanda.Encerrar())
                {
                    MessageBox.Show("Comanda encerrada", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Desabilitar o botão encerrar e o chb
                    BtnEncerrarComanda.Enabled = false;
                    ChbPagamento.Checked = false;
                    //Limpar o dgv
                    DgvListaComandas.DataSource = null;
                    //Apagar o numero da comanda
                    TxtbNumComanda.Text = ""; 
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a comanda", "ERRO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
