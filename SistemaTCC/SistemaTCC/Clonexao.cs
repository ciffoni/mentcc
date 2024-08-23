//adicionar a biblioteca mysql conexao
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaTCC
{
    public class Clonexao
    {
        //variaveis de conexao com o mysql
        //variavel estatica e privada
        //servidor nome do dominio ou IP
        static private string servidor = "localhost";
        //nome do banco de dados 
        static private string DB = "projeto";
        //usuário do banco de dados;
        static private string usuario = "root";
        //senha de acesso ao banco de dados
        static private string senhas = "";
        //variavel de conexao ao banco de dados
        public MySqlConnection conn = null;
        //determinar o caminho da conexao ao banco
        static private string StrConexao = "server=" + servidor + ";database=" + DB +
            ";user id=" + usuario + ";password=" + senhas;

        //criar os metodos de conexao

        public MySqlConnection getConexao()
        {
            //cria uma nova conexao ao banco de dados
            conn = new MySqlConnection(StrConexao);
            //retorna a conexao estabelecida
            return conn;
        }
        //nmetodo de cadastro generico
        //variavel campos são os atributos da entidade
        //variavel valores são os conteúdos preenchidos no form
        //variavel sql  é o comando a ser realizado
        public int cadastrar(int codigo, string[] campos, object[] valores, string SQL)
        {
            //registro de validação do script
            int registro = 0;
            try
            {
                //atribuo a conexao obtida
                conn = getConexao();
                //abro o banco de dados
                conn.Open();
                //preparo para executar o script SQL
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                //monto s script sql
                //pegar os cmapos do vetor
                for (int i = 0; i < valores.Length; i++)
                {
                    //monta a lista de paramentros juntando os campos e valores
                    //pega os valores do formulario com os campos do banco 
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }
                if (codigo > 0)
                {
                    //se o codigo existir no registro será substituido aqui para execução
                    cmd.Parameters.AddWithValue("@id", codigo);
                }
                //executa o script sql
                registro = cmd.ExecuteNonQuery();
                //fecha a conexao com o banco
                conn.Close();
            }
            catch (Exception ex)
            {
                //gera uma excessão há algum erro no codigo
                throw new Exception(ex.Message);
            }

            return registro;
        }
        public int excluir(int codigo, string SQL)
        {
            //registro de validação do script
            int registro = 0;
            try
            {
                //atribuo a conexao obtida
                conn = getConexao();
                //abro o banco de dados
                conn.Open();
                //preparo para executar o script SQL
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                //monto s script sql
                //pegar os cmapos do vetor
                if (codigo > 0)
                {
                    //se o codigo existir no registro será substituido aqui para execução
                    cmd.Parameters.AddWithValue("@id", codigo);
                }
                //executa o script sql
                registro = cmd.ExecuteNonQuery();
                //fecha a conexao com o banco
                conn.Close();
            }
            catch (Exception ex)
            {
                //gera uma excessão há algum erro no codigo
                throw new Exception(ex.Message);
            }

            return registro;
        }

        //metodo para pegar as informações do banco de dados
        //passo o parametro da 
        public DataTable obterdados(string sql)
        {
            //crio uma tabela de dados
            DataTable dt = new DataTable();
            conn = getConexao();//obtenho a conexao
            conn.Open();//abro o banco
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //monto a estrutura das informações obtidas
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            //adiciona a datatable os valores 
            adapter.Fill(dt);

            return dt;
        }
    }
}
