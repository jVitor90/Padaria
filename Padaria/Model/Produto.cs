using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyEncryption;
using MySqlConnector;
using Padaria.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Padaria.Model
{
    internal class Produto
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }
        public int id_categoria { get; set; }
        public int id_respcadastro {get; set;}

        public bool CadastrarProduto()
        {
            string comando = "INSERT INTO produtos (nome, preco, id_categoria, id_respcadastro) " +
             "VALUES (@nome, @preco, @id_categoria, @id_respcadastro )";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome", nome); // string nome = "Coca-Cola";
            cmd.Parameters.AddWithValue("@preco", preco); // decimal preco = 7.00M;
            cmd.Parameters.AddWithValue("@id_categoria", id_categoria); // int idCategoria = 2;
            cmd.Parameters.AddWithValue("@id_respcadastro", id_respcadastro); // int idRespCategoria = 1;
            cmd.Prepare();
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
            public DataTable ListarProduto()
             {
            //Select id_nome_completo,email
            string comando = "SELECT * FROM produtos";

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
        public bool RemoverProdutos()
        {
            string comando = "DELETE FROM produtos WHERE id = @id";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();
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
        public bool ModificarProdutos()
        {
            string comando = "UPDATE produtos SET nome = @nome, " +
            "preco = @preco, id_categoria = @id_categoria WHERE id = @id";
            
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@preco", preco); 
            cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
            cmd.Parameters.AddWithValue("@id_respcadastro", id_respcadastro); 
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();
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

