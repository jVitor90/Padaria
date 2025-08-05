using System;
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
    public partial class FrmComandas : Form
    {
        //Variaveis globais 
        Model.Usuario usuario;
        Model.Produto produto = new Model.Produto();
        Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
        public FrmComandas(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            GrbLancamento.Enabled = false;
            AtualizarDgv();
        }
        public void ResetarCampos()
        { 
            GrbInformações.Enabled = true;
            GrbLancamento.Enabled = false;
           
            
            
            //Limpar os campos 
            TxtbComandas.Text = "";
            TxtbProdutos.Text = "";
            TxtbQuantidades.Text = "";
        }
        public void AtualizarDgv()
        {
            DgvComandas.DataSource = produto.ListarProduto();
        }

        private void DgvComandas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = DgvComandas.SelectedCells[0].RowIndex;
            //atribuir o id e nome do produto no txtb
            string idProduto = DgvComandas.Rows[linhaSelecionada].Cells[0].Value.ToString();
            string nomeProduto = DgvComandas.Rows[linhaSelecionada].Cells[1].Value.ToString();
            TxtbProdutos.Text = $"{idProduto} - {nomeProduto}";

        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            //Verificar se os campos forma preenchidos:
            if (TxtbComandas.Text == "")
            {
                MessageBox.Show("Informe o numero da comando", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //habilitar o cmapo de lançamento
                GrbLancamento.Enabled = true;
                TxtbProdutos.Enabled = false;

                //desativar o grbinformações
                GrbInformações.Enabled = false;
            }
        }

        private void BtnLancar_Click(object sender, EventArgs e)
        {
            //Verificar se os campos forma preenchidos:
            if (TxtbComandas.Text == "")
            {
                MessageBox.Show("Informe a comanda!",
                   "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtbQuantidades.Text == "")
            {
                MessageBox.Show("Informe a quantidade de produtos!",
                     "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string produto = TxtbProdutos.Text;
                string nomeProduto = produto.Split('-').Length > 2
                                     ? produto.Split('-')[1] + "-" + produto.Split('-')[2]
                                     : produto.Split('-')[1]; // fallback: usa o texto completo se o split falhar

                DialogResult r = MessageBox.Show( $"Tem certeza que deseja lançar {TxtbQuantidades.Text} " +
                    $"unidades de{nomeProduto} na comanda {TxtbComandas.Text}?", "Atenção!", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    ordemComanda.idResp = usuario.Id;
                    ordemComanda.idProduto = int.Parse(TxtbProdutos.Text.Split('-')[0]);
                    ordemComanda.idFicha = int.Parse(TxtbComandas.Text);
                    ordemComanda.Quantidade = int.Parse(TxtbQuantidades.Text);
                    ordemComanda.Situacao = 1;// Inserir 

                    if (ordemComanda.Cadastrar_Comanda())
                    {
                        MessageBox.Show("Lançamento efetuado com sucesso", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Falha no Lançamento", "ERRO!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    ResetarCampos();
                }

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            ResetarCampos();

            
        }
    }
}

