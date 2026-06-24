using BCrypt.Net;
using MySql.Data.MySqlClient;
using seasonPlusHouse.CODE.DTO;
using System;
using System.Collections.Generic;
using System.Text;


namespace seasonPlusHouse.CODE.BLL
{
    public class AluguelTemporada
    {
  
        private string connectionString = @"Data Source=SEU_SERVIDOR;Initial Catalog=SeuBanco;Integrated Security=True;";

        public bool ValidarLogin(usuarioDTO dto)
        {
            string hashSalvoNoBanco = string.Empty;

            
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                
                string query = "SELECT SenhaHash FROM Usuarios WHERE NomeUsuario = @usuario";

                using (MySqlCommand comando = new MySqlCommand(query, conexao))
                {
                
                    comando.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = dto.nomeUsuario1;

                    try
                    {
                        conexao.Open();
                        object resultado = comando.ExecuteScalar();

                        if (resultado != null)
                        {
                            hashSalvoNoBanco = resultado.ToString();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                         throw new Exception("Erro ao conectar com o MySQL: " + ex.Message);
                    }
                }
            }
            bool senhaCorreta = BCrypt.Net.BCrypt.Verify(dto.senhaUsuario1, hashSalvoNoBanco);
            return senhaCorreta;
        }
    }
}


