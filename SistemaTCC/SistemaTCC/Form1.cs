using SistemaTCC.controle;
using SistemaTCC.modelo;

namespace SistemaTCC
{
    public partial class Form1 : Form
    {
        //criar a instancia  do objeto usu�rio 
        ModeloUsuariocs mUsuario= new ModeloUsuariocs();
        ControleUsuario cUsuario = new ControleUsuario();
        Clonexao conexao = new Clonexao();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //chama o metodo de obter as informa��es do banco e carrega no datagrid
            dataGridView1.DataSource = conexao.obterdados("select * from usuario");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //atriuo os valores ao objeto usuario
            mUsuario.cargo = Convert.ToInt32(txtCargo.Text);
            try
            {


                mUsuario.nome = txtNome.Text;
                //verificar se o campo email foi preenchido
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Campo e-mail est� vazio!");
                    return;
                }
                else
                {
                    mUsuario.email = txtEmail.Text;
                }
                mUsuario.senha = txtSenha.Text;
                if (cUsuario.cadastrar(mUsuario) == true)
                {
                    MessageBox.Show("Usu�rio cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro no cadastrado do usu�rio!");

                }
            }catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

        }
    }
}
