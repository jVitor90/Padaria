using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyEncryption;
using MySqlConnector;
using Padaria.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Padaria.Model
{
    //Variaveis globais 
    internal class OrdemComanda
    {
        public int id { get; set; }
        public int idFicha { get; set; }
        public int idProduto { get; set; }
        public int Quantidade { get; set; }
        public int idResp { get; set; }
        public DateTime DataAdic { get; set; }
        public int Situacao { get; set; }

        public DataTable listar()
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
        public bool Cadastrar_Comanda()
        {
            string comando = "INSERT INTO ordens_comandas(`id_ficha`, `id_produto`," +
                " `quantidade`, `id_resp`, `situacao`) VALUES " +
                 "VALUES (@id, @id_ficha, @id_produto, @quantidade, @id_resp, @situacao)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id_ficha", idFicha);
            cmd.Parameters.AddWithValue("@id_produto", idProduto);
            cmd.Parameters.AddWithValue("@quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@id_resp", idResp);
            cmd.Parameters.AddWithValue("@situacao", Situacao);

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }

    }
}

