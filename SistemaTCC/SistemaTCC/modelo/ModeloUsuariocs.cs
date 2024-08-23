namespace SistemaTCC.modelo
{
    //crio o modelo com as informações do usuario
    public class ModeloUsuariocs
    {
        //declaro as variaveis do sistema com relação ao banco de dados
        public int cod_usuario;
        public string nome;
        public string email;
        public string senha;
        public int cargo;
        //construtor da classe usuario 
        public ModeloUsuariocs()
        {
            //inicializar as variaveis zeradas
            nome = null;
            email = null;
            senha = null;
            cargo = 0;

        }
    }
}
