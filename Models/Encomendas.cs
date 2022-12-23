using System;
using System.Collections.Generic;
using MySqlConnector;

namespace PI_atv5_Juliano_araujo_de_oliveira.Models
{
    public class Encomendas
    {
         private const string DadosConexao = "Database=PI_atv4_Juliano_araujo_de_oliveira; Data Source=localhost; User Id=root;";
        
        public void TestarConexao()
        {
            MySqlConnection Conexao  = new MySqlConnection(DadosConexao);
            Conexao.Open();
            Console.WriteLine("Banco de dados funcionando!");
            Conexao.Close();
        }
        
        
        public void Inserir(DetalheAgenda encomendas)
        {
         MySqlConnection Conexao = new MySqlConnection(DadosConexao);
         Conexao.Open();
         string Query ="INSERT INTO DetalheAgenda(Nome,Data,Telefone,Doce,horario,Quantidade,Descricao) VALUES (@Nome,@Data,@Telefone,@horario,@Quantidade,@Doce)";
        MySqlCommand Comando = new MySqlCommand(Query,Conexao);
        Comando.Parameters.AddWithValue("@Nome",encomendas.nome);
        Comando.Parameters.AddWithValue("@Nome",encomendas.nome);
        Comando.Parameters.AddWithValue("@Data",encomendas.Data);
        Comando.Parameters.AddWithValue("@Telefone",encomendas.telefone);
        Comando.Parameters.AddWithValue("@horario",encomendas.horario);
        Comando.Parameters.AddWithValue("@Quantidade",encomendas.quantidade);
         Comando.Parameters.AddWithValue("@Doce",encomendas.Doce);
        Comando.ExecuteNonQuery();
        Conexao.Close();

        }

     }
}


