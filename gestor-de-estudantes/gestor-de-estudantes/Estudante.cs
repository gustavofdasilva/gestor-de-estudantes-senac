using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace gestor_de_estudantes
{
    internal class Estudante
    {
        MEU_BD bancoDeDados = new MEU_BD();

        public bool inserirEstudantes(
            string nome, 
            string sobrenome,
            DateTime nascimento,
            string genero,
            string telefone,
            string endereco, 
            MemoryStream foto)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO `estudantes`(`nome`, `sobrenome`, `nascimento`, `genero`, `telefone`, `endereco`, `foto`) VALUES (@nm,@snm,@nsc,@g,@tel,@end,@ft)", bancoDeDados.getConexao);

            comando.Parameters.Add("@nm",MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@snm", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@nsc", MySqlDbType.Date).Value = nascimento;
            comando.Parameters.Add("@g", MySqlDbType.VarChar).Value = genero;
            comando.Parameters.Add("@tel", MySqlDbType.VarChar).Value = telefone;
            comando.Parameters.Add("@end", MySqlDbType.Text).Value = endereco;
            comando.Parameters.Add("@ft", MySqlDbType.LongBlob).Value = foto.ToArray();

            bancoDeDados.abrirConexao();
            if(comando.ExecuteNonQuery() ==1)
            {
                bancoDeDados.fecharConexao();
                return true;
            } else
            {
                bancoDeDados.fecharConexao();
                return false;
            }
        }


        public bool atualizarEstudantes(
            int id,
            string nome,
            string sobrenome,
            DateTime nascimento,
            string genero,
            string telefone,
            string endereco,
            MemoryStream foto)
        {
            MySqlCommand comando = new MySqlCommand("UPDATE `estudantes` SET `nome`=@nm,`sobrenome`=@sn,`nascimento`=@nsc,`genero`=@gen,`telefone`=@tel,`endereco`=@end,`foto`=@ft WHERE `id` = @id", bancoDeDados.getConexao);

            comando.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            comando.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@snm", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@nsc", MySqlDbType.Date).Value = nascimento;
            comando.Parameters.Add("@g", MySqlDbType.VarChar).Value = genero;
            comando.Parameters.Add("@tel", MySqlDbType.VarChar).Value = telefone;
            comando.Parameters.Add("@end", MySqlDbType.Text).Value = endereco;
            comando.Parameters.Add("@ft", MySqlDbType.LongBlob).Value = foto.ToArray();

            bancoDeDados.abrirConexao();
            if (comando.ExecuteNonQuery() == 1)
            {
                bancoDeDados.fecharConexao();
                return true;
            }
            else
            {
                bancoDeDados.fecharConexao();
                return false;
            }
        }

        public bool deletarEstudante(int id)
        {
            MySqlCommand comando = new MySqlCommand("DELETE FROM 'estudantes' WHERE `id`=@id", bancoDeDados.getConexao);

            bancoDeDados.abrirConexao();
            if (comando.ExecuteNonQuery() == 1)
            {
                bancoDeDados.fecharConexao();
                return true;
            } else
            {
                bancoDeDados.fecharConexao();
                return false;
            }
        }


        public DataTable pegarEstudantes(MySqlCommand comando) 
        {
            comando.Connection = bancoDeDados.getConexao;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            return tabela;
        }
    }
}
