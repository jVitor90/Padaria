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
    public partial class FrmGestaoUsuarios : Form
    {
        //Variaveis globais 
        Model.Usuario usuario;
        public FrmGestaoUsuarios(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            //Puxar os dados da tabela "usuario"
            atualizarUsuarioDgv();
        }
        public void atualizarUsuarioDgv()
        {
            DgvUsuarios.DataSource = usuario.Listar();
        }

        private void BtnCadastrarEmail_Click(object sender, EventArgs e)
        {
            //Validação de Erros:
            if (TxtbCadastrarEmail.Text.Length < 6)
            {
                MessageBox.Show("O E-mail informado é invalido!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtbCadastrarNome.Text.Length < 7)
            {
                MessageBox.Show("O Nome informado é invalido!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtbCadastrarSenha.Text.Length < 5)
            {
                MessageBox.Show("a senha informado é invalido!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Instanciar o usuário 
                Model.Usuario usuario = new Model.Usuario();
                usuario.NomeCompleto = TxtbCadastrarNome.Text;
                usuario.Email = TxtbCadastrarEmail.Text;
                usuario.Senha = TxtbCadastrarSenha.Text;

                if (usuario.Cadastrar())
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "SUCESSO!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpar os campos de cadastro 
                    TxtbCadastrarEmail.Text = "";
                    TxtbCadastrarNome.Text = "";
                    TxtbCadastrarSenha.Text = "";
                    atualizarUsuarioDgv();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o usuário!", "ERRO!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BtnEditarEmail_Click(object sender, EventArgs e)
        {
            //Validação de Erros:
            if (TxtbEditarEmail.Text.Length < 6)
            {
                MessageBox.Show("O E-mail informado é invalido!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtbEditarNome.Text.Length < 7)
            {
                MessageBox.Show("O Nome informado é invalido!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtbEditarSenha.Text.Length < 5)
            {
                MessageBox.Show("O Senha informado é invalido!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Iniciar edicão no BD
                this.usuario.NomeCompleto = TxtbEditarNome.Text;
                this.usuario.Email = TxtbEditarEmail.Text;
                this.usuario.Senha = TxtbEditarSenha.Text;
                //Exucutar o .modificar()
                if (this.usuario.Modificar())
                {
                    MessageBox.Show("Usuário editado com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizarUsuarioDgv();
                    //limpar os campos e desatualizar o Dgvs
                    GrbApagar.Enabled = false;
                    GrbEditar.Enabled = false;
                    TxtbEditarEmail.Text = "";
                    TxtbEditarNome.Text = "";
                    TxtbEditarSenha.Text = "";
                }
                else
                {
                    MessageBox.Show("Falha ao editar o usuário!", "ERRO!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {

            DialogResult apagar = MessageBox.Show("Tem certeza que deseja apagar o usuário?", "Atenção!",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (apagar == DialogResult.Yes)
            {
                //Puxar os dados da tabela funcionario 
                if (this.usuario.Remover())
                {
                    MessageBox.Show("Usuário removido com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    atualizarUsuarioDgv();
                    //limpar os campos e desatualizar o Dgvs
                    GrbApagar.Enabled = false;
                    GrbEditar.Enabled = false;
                    TxtbEditarEmail.Text = "";
                    TxtbEditarNome.Text = "";
                    TxtbEditarSenha.Text = "";
                }
                else
                {
                    MessageBox.Show("Falha ao remover o usuário!", "ERRO!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int LinhaSelecionada = DgvUsuarios.SelectedCells[0].RowIndex;
            
            this.usuario.NomeCompleto = DgvUsuarios.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            this.usuario.Email = DgvUsuarios.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            this.usuario.Id = (int)DgvUsuarios.Rows[LinhaSelecionada].Cells[0].Value;
            
            //Atribuir os dados da linha selecionada no grbEditar
            TxtbEditarNome.Text = this.usuario.NomeCompleto;
            TxtbCadastrarEmail.Text = this.usuario.Email;
            //Ativar GrbEditar
            GrbEditar.Enabled = true;
            //Ativar GrbApagar
            GrbApagar.Enabled = true;
            LblApagar.Text = $"{this.usuario.Id} - {this.usuario.NomeCompleto}";
        }

        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    } 
}
