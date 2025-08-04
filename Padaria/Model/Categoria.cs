using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Padaria.model;

namespace Padaria.Model
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public DataTable ListarCategoria()
        {
            //Select id_nome_completo,email
            string comando = "SELECT id,nome FROM categorias";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
    }
}

