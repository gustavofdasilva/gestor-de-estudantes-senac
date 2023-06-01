using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace gestor_de_estudantes
{
    internal class MEU_BD
    {
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=sga_estudantes_bd"); //objeto que representa a conexão com o banco de dados
        public MySqlConnection getConexao //publica do objeto conexao
        {
            get { 
                return conexao; 
            }
        }

        public void abrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }
        public void fecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

    }
}
