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
    public partial class FrmGestaoProdutos : Form
    {
        //Variaveis globais 
        Model.Usuario usuario;
        Model.Produto produto = new Model.Produto();
        public FrmGestaoProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            atualizarProdutosDgv();
        }

        private void DgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = DgvProdutos.SelectedCells[0].RowIndex;
            // Atribuir os dados da linha selecionada  no grbEditar
            this.produto.Id = (int)DgvProdutos.Rows[linhaSelecionada].Cells[0].Value;
            this.produto.nome = DgvProdutos.Rows[linhaSelecionada].Cells[1].Value.ToString();
            this.produto.preco = (double)DgvProdutos.Rows[linhaSelecionada].Cells[2].Value;
            this.produto.id_categoria = (int)DgvProdutos.Rows[linhaSelecionada].Cells[3].Value;

            TxtbEditarNomeProduto.Text = this.produto.nome;
            TxtbEditarPreco.Text = this.produto.preco.ToString();
            TxtbEditarCategoria.Text = this.produto.id_categoria.ToString();
            // Ativar o grbEditor
            GrbEditarProduto.Enabled = true;
            // Ativar o grvApagar
            GrbApagarProduto.Enabled = true;
        }
        public void atualizarProdutosDgv()
        {
            DgvProdutos.DataSource = produto.ListarProduto();
        }
        private void TxtbCadastrarProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // impede a digitação
                MessageBox.Show("Não é permitido digitar números no nome.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void TxtbCadastrarPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas números no campo de preço.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            DialogResult apagar = MessageBox.Show("Tem certeza que deseja apagar esse produto? ", "Atenção!",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (apagar == DialogResult.Yes)
            {
                //Puxar os dados da tabela produto
                if (this.produto.RemoverProdutos())
                {
                    MessageBox.Show("Produto removido com sucesso! ", "Sucesso!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizarProdutosDgv();
                    //Limpar os campos e desabilitar os grbs e os txtb
                    GrbEditarProduto.Enabled = false;
                    GrbApagarProduto.Enabled = false;
                    TxtbEditarNomeProduto.Clear();
                    TxtbEditarPreco.Clear();
                    LblApagar.Text = "Selecione o produto que deseja apagar. ";
                }
                else
                {
                    MessageBox.Show("Falha ao remover o produto! ", "Erro!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCadastrarProdutos_Click(object sender, EventArgs e)
        {
            // Validação de Erros:
            if (string.IsNullOrWhiteSpace(TxtbCadastrarNomeProduto.Text))
            {
                MessageBox.Show("O campo 'Nome do Produto' não pode estar vazio!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(TxtbCadastrarPreco.Text))
            {
                MessageBox.Show("O campo 'Preço' não pode estar vazio!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(TxtbCadastrarCategoria.Text))
            {
                MessageBox.Show("O campo 'Categoria' não pode estar vazio!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.produto.nome = TxtbCadastrarNomeProduto.Text;
                this.produto.preco = double.Parse(TxtbCadastrarPreco.Text);
                this.produto.id_categoria = int.Parse(TxtbCadastrarCategoria.Text);
                this.produto.id_respcadastro = usuario.Id;

                if (produto.CadastrarProduto())
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "SUCESSO!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpar os campos de cadastro 
                    TxtbCadastrarNomeProduto.Text = "";
                    TxtbCadastrarPreco.Text = "";
                    TxtbCadastrarCategoria.Text = "";
                    atualizarProdutosDgv();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o produto!", "ERRO!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEditarProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtbEditarNomeProduto.Text))
            {
                MessageBox.Show("O nome do produto informado é invalido!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(TxtbEditarPreco.Text))
            {
                MessageBox.Show("O Preço informado é invalido!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(TxtbEditarCategoria.Text))
            {
                MessageBox.Show("A categoria informada é invalida!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Iniciar edicão no BD
                this.produto.nome = TxtbEditarNomeProduto.Text;
                this.produto.preco = double.Parse(TxtbEditarPreco.Text);
                this.produto.id_categoria = int.Parse(TxtbEditarCategoria.Text);
                //Exucutar o .ModificarProduto()
                if (this.produto.ModificarProdutos())
                {
                    MessageBox.Show("Usuário editado com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizarProdutosDgv();
                    //limpar os campos e desatualizar o Dgvs
                    GrbApagarProduto.Enabled = false;
                    GrbEditarProduto.Enabled = false;
                    TxtbEditarPreco.Text = "";
                    TxtbEditarNomeProduto.Text = "";
                    TxtbEditarCategoria.Text = "";
                }
                else
                {
                    MessageBox.Show("Falha ao editar o produto!", "ERRO!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
