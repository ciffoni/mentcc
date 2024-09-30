using Org.BouncyCastle.Tls.Crypto.Impl.BC;
using System.Data;

namespace SistemaTCC
{
    public partial class FrmCatalogo : Form
    {
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCatalogo_Load(object sender, EventArgs e)
        {
            Clonexao conexao = new Clonexao();
            DataTable dt = new DataTable();
            dt = conexao.obterdados("select * from usuario");
            int registros = 0;//obter o numero de registros
            int x = 0, y = 0;// definir posição x e y da tela
            for (registros = 0; registros < dt.Rows.Count; registros++)
            {
                // novo painel
                Panel cliente = new Panel();

                cliente.BorderStyle = BorderStyle.FixedSingle;
                //posiciono o painel na posição x e y
                cliente.Location = new Point(x, y);
                //defino o tamanho do quadro
                cliente.Height = 800;
                cliente.Width = 600;
                //criando os objetos manualmente

                Label idcliente = new Label();
                idcliente.Name = "cod_usuario";
                idcliente.Text = dt.Rows[registros][0].ToString();
                //defino
                idcliente.Location = new Point(20, y);

                Label nome = new Label();
                nome.Name = "nome";
                nome.Text = dt.Rows[registros][1].ToString();
                nome.Location = new Point(20, 35);
                //inserir a foto no paibel
                PictureBox foto = new PictureBox();
                foto.Location = new Point(20, 0);
                foto.SizeMode = PictureBoxSizeMode.StretchImage;
                foto.Name = "foto";
                foto.Image = Image.FromFile(dt.Rows[registros][2].ToString());
                Label cargo = new Label();
                cargo.Name = "cargo";
                cargo.Text = dt.Rows[registros][4].ToString();
                cargo.Location = new Point(22, 35);
                //adicionando o objeto ao painel
                Button consultar = new Button();
                consultar.Name = "consultar";
                consultar.Text = "Consultar";
                consultar.Location = new Point(25, y);
                consultar.Click += new EventHandler((sender,e1)=> ReservarClick(sender,e1,idcliente.Text));  
                cliente.Controls.Add(idcliente);
                cliente.Controls.Add(nome);
                cliente.Controls.Add(cargo);
                cliente.Controls.Add(foto);
                cliente.Controls.Add(consultar);
                //adiciono o painel ao layout
                flowLayoutPanel1.Controls.Add(cliente);
                y += 100; //pular 100 pixel da coluna
                x = 0;
            }

        }
        private void ReservarClick(object sender, EventArgs e,string id)
        {
            MessageBox.Show("Id =" + id);
        }
    }
}
