using SistemaTCC.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTCC.controle
{
    //Controle Usuario nossa regra de negocio 
    public class ControleUsuario
    {
        //chamo o objeto de conexao
        Clonexao con=new Clonexao();

        //metodo para cadastrar usuario
        public bool cadastrar(ModeloUsuariocs usuario)
        {
            //inicializar a variavel resultado do operacao 
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "insert into usuario(nome,email,senha,cargo)values(@nome,@email,@senha,@cargo)";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@nome", "@email", "@senha", "@cargo" };
                //monto o vetor com os valores do formulario
                string[] valores = { usuario.nome, usuario.email, usuario.senha, usuario.cargo.ToString() };
                //testar o insert no banco de dados
                if (con.cadastrar(0, campos, valores, sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            } catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }


        
        }
        public bool editar(ModeloUsuariocs usuario)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "update usuario set nome=@nome,email=@email,senha=@senha,cargo=@cargo where cod_usuario=@id)";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@nome", "@email", "@senha", "@cargo" };
                //monto o vetor com os valores do formulario
                string[] valores = { usuario.nome, usuario.email, usuario.senha, usuario.cargo.ToString() };
                //testar o insert no banco de dados
                if (con.cadastrar(usuario.cod_usuario, campos, valores, sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        public bool excluir (ModeloUsuariocs usuario)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "delete from usuario where cod_usuario=@id)";
                //monto o vetor de atributos da tabela usuario
                if (con.cadastrar(usuario.cod_usuario,sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }



            return resultado;
        }
    }
}
