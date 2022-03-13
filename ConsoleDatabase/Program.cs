using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDatabase
{
    class Program
    {
        static void Main(string[] args)
        {

            //MySqlConnection conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString);
           
            //conexao.Open();
            
            //string selectUserCommand = "SELECT * FROM tb_usuario";
            //MySqlCommand command = new MySqlCommand(selectUserCommand, conexao);
            //MySqlDataReader reader = command.ExecuteReader();

            //while(reader.Read())
            //{
            //    Console.WriteLine("Código: {0} | Código: {1} | Código: {2} | Código: {3}", 
            //                        reader["usuarioId"], 
            //                        reader["usuarioNome"], 
            //                        reader["usuarioCargo"], 
            //                        reader["usuarioDataNasc"]);
            //};

            //Console.ReadLine();
        }
    }
}
