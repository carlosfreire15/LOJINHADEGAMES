using LOJADEGAMES.Repositorio;
using MySql.Data.MySqlClient;
using LOJADEGAMES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOJADEGAMES.Repositorio
{
    public class Acoes
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarFuncionario(CLASS_FUNCIONARIO funcionario)
        {
            string data_sistemas = Convert.ToDateTime(funcionario.DATA_NASC_FUNC).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into CLASS_FUNCIONARIO values(@COD_FUNC, @NOME_FUNC, @CPF_FUNC, @RG_FUNC, @DATA_NASC_FUNC, @END_FUNC, @CEL_FUNC, @EMAIL_FUNC, @CARGO_FUNC", con.ConectarBD());
            cmd.Parameters.Add("@COD_FUNC", MySqlDbType.VarChar).Value = funcionario.COD_FUNC;
            cmd.Parameters.Add("@NOME_FUNC", MySqlDbType.VarChar).Value = funcionario.NOME_FUNC;
            cmd.Parameters.Add("@CPF_FUNC", MySqlDbType.VarChar).Value = funcionario.CPF_FUNC;
            cmd.Parameters.Add("@RG_FUNC", MySqlDbType.VarChar).Value = funcionario.RG_FUNC;
            cmd.Parameters.Add("@DATA_NASC_FUNC", MySqlDbType.VarChar).Value = funcionario.DATA_NASC_FUNC;
            cmd.Parameters.Add("@END_FUNC", MySqlDbType.VarChar).Value = funcionario.END_FUNC;
            cmd.Parameters.Add("@CEL_FUNC", MySqlDbType.VarChar).Value = funcionario.CEL_FUNC;
            cmd.Parameters.Add("@EMAIL_FUNC", MySqlDbType.VarChar).Value = funcionario.EMAIL_FUNC;
            cmd.Parameters.Add("@CARGO_FUNC", MySqlDbType.VarChar).Value = funcionario.CARGO_FUNC;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public void CadastrarJogo(CLASS_JOGO jogo)
        {
            MySqlCommand cmd = new MySqlCommand("insert into CLASS_JOGO values(@COD_JOGO, @NOME_JOGO, @VER_JOGO, @EST_DEV_JOGO, @GEN_JOGO, @CLASSIFI_JOGO, @PLATAFORMA_JOGO, @ANO_JOGO, @SINOPSE_JOGO", con.ConectarBD());
            cmd.Parameters.Add("@COD_JOGO", MySqlDbType.VarChar).Value = jogo.COD_JOGO;
            cmd.Parameters.Add("@NOME_JOGO", MySqlDbType.VarChar).Value = jogo.NOME_JOGO;
            cmd.Parameters.Add("@VER_JOGO", MySqlDbType.VarChar).Value = jogo.VER_JOGO;
            cmd.Parameters.Add("@EST_DEV_JOGO", MySqlDbType.VarChar).Value = jogo.EST_DEV_JOGO;
            cmd.Parameters.Add("@GEN_JOGO", MySqlDbType.VarChar).Value = jogo.GEN_JOGO;
            cmd.Parameters.Add("@CLASSIFI_JOGO", MySqlDbType.VarChar).Value = jogo.CLASSIFI_JOGO;
            cmd.Parameters.Add("@PLATAFORMA_JOGO", MySqlDbType.VarChar).Value = jogo.PLATAFORMA_JOGO;
            cmd.Parameters.Add("@ANO_JOGO", MySqlDbType.VarChar).Value = jogo.ANO_JOGO;
            cmd.Parameters.Add("@SINOPSE_JOGO", MySqlDbType.VarChar).Value = jogo.SINOPSE_JOGO;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public void CadastrarCliente(CLASS_CLI cliente)
        {
            string data_sistemas = Convert.ToDateTime(cliente.DATA_NASC_CLIENTE).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into CLASS_FUNCIONARIO values(@NOME_CLIENTE, @CPF_CLIENTE, @DATA_NASC_CLIENTE, @CEL_CLIENTE, @END_CLIENTE", con.ConectarBD());
            cmd.Parameters.Add("@NOME_CLIENTE", MySqlDbType.VarChar).Value = cliente.NOME_CLIENTE;
            cmd.Parameters.Add("@CPF_CLIENTE", MySqlDbType.VarChar).Value = cliente.CPF_CLIENTE;
            cmd.Parameters.Add("@DATA_NASC_CLIENTE", MySqlDbType.VarChar).Value = cliente.DATA_NASC_CLIENTE;
            cmd.Parameters.Add("@CEL_CLIENTE", MySqlDbType.VarChar).Value = cliente.CEL_CLIENTE;
            cmd.Parameters.Add("@END_CLIENTE", MySqlDbType.VarChar).Value = cliente.END_CLIENTE;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public List<CLASS_FUNCIONARIO> ListarFuncionario()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from CLASS_FUNCIONARIO", con.ConectarBD());
            var DadosFuncionario = cmd.ExecuteReader();
            return ListarTodosFuncionario(DadosFuncionario);
        }

        public List<CLASS_FUNCIONARIO> ListarTodosFuncionario(MySqlDataReader dt)
        {
            var todosFuncionario = new List<CLASS_FUNCIONARIO>();
            while (dt.Read())
            {
                var FuncionarioTemp = new CLASS_FUNCIONARIO()
                {
                    COD_FUNC = ushort.Parse(dt["COD_FUNC"].ToString()),
                    NOME_FUNC = dt["NOME_FUNC"].ToString(),
                    CPF_FUNC = dt["CPF_FUNC"].ToString(),
                    RG_FUNC = dt["RG_FUNC"].ToString(),
                    DATA_NASC_FUNC = DateTime.Parse(dt["DATA_NASC_FUNC"].ToString()),
                    END_FUNC = dt["END_FUNC"].ToString(),
                    CEL_FUNC = ushort.Parse(dt["CEL_FUNC"].ToString()),
                    EMAIL_FUNC = dt["EMAIL_FUNC"].ToString(),
                    CARGO_FUNC = dt["CARGO_FUNC"].ToString(),
                };
            todosFuncionario.Add(FuncionarioTemp);
            }
        dt.Close();
         return todosFuncionario;
        }
    }
}