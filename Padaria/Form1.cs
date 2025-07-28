using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Padaria.Model;

namespace Padaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (TxtbEmail.Text.Length < 6)
            {
                MessageBox.Show("E-mail inválido", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtbSenha.Text.Length < 3)
            {
                MessageBox.Show("Senha inválido", "ERRO!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //Instanciar objeto do tipo usuário
                Model.Usuario usuario = new Model.Usuario();
                usuario.Email = TxtbEmail.Text;
                usuario.Senha = TxtbSenha.Text;
                //Variavel para armazenar o resultado do lugar (SELECT)
                DataTable resultado = new DataTable();
                resultado = usuario.Logar();

                //Verificar se a tabela tem pelo menos uma linha 
                if (resultado.Rows.Count > 0)
                {
                    // Armazenar os infos de usuários no obj
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                    usuario.Id = (int)resultado.Rows[0]["id"];
                    //Mudar para o form principal
                    FormMenuPrincipal principal = new FormMenuPrincipal(usuario);
                    this.Hide();
                    principal.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválida", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
