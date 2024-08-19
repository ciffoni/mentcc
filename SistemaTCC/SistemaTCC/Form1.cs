using SistemaTCC.controle;
using SistemaTCC.modelo;

namespace SistemaTCC
{
    public partial class Form1 : Form
    {
        //criar a instancia  do objeto usuário 
        ModeloUsuariocs mUsuario = new ModeloUsuariocs();
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


            //chama o metodo de obter as informações do banco e carrega no datagrid
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
                    MessageBox.Show("Campo e-mail está vazio!");
                    return;
                }
                else
                {
                    mUsuario.email = txtEmail.Text;
                }
                mUsuario.senha = txtSenha.Text;
                if (cUsuario.cadastrar(mUsuario) == true)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro no cadastrado do usuário!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {




            //populo meu objeto usuário
            mUsuario.cod_usuario = Convert.ToInt32(txtCodigo.Text);
            mUsuario.nome = txtNome.Text;
            mUsuario.senha = txtSenha.Text;
            mUsuario.cargo = Convert.ToInt32(txtCargo.Text);
            mUsuario.email = txtEmail.Text;
            //chama o metodo de editar as informações do usuario
            if (cUsuario.editar(mUsuario) == true)
            {
                MessageBox.Show("Atualizado o usuário com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar as infomrações");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridView dvg = (DataGridView)sender;
            //Check first if datagridview has data and
            //Check if you are selecting a valid row
            // if (dvg.Rows.Count > 0 && dvg.CurrentCell.RowIndex > 0)
            //{
            int index = dvg.CurrentCell.RowIndex;

            DataGridViewRow row = dvg.Rows[index];
            txtCodigo.Text = row.Cells["cod_usuario"].Value.ToString();
            txtNome.Text = row.Cells["nome"].Value.ToString();
            txtEmail.Text = row.Cells["email"].Value.ToString();
            txtSenha.Text= row.Cells["senha"].Value.ToString() ;
            txtCargo.Text = row.Cells["cargo"].Value.ToString();
            //Or you can store the information you've got here to some
            //Variable you can use to open the form you want.         
            //}

        }
    }
}
