using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTCC
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            modelo.ModeloUsuariocs musuario = new modelo.ModeloUsuariocs();
            musuario.senha=txtsenha.Text;
            musuario.email=txtEmail.Text;

            controle.ControleUsuario cusuario = new controle.ControleUsuario();
            if (cusuario.logar(musuario)>=1)
            {
                MessageBox.Show("Acesso autorizado!");
                Form1 usuario= new Form1();
                usuario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acesso não autorizado!");
            }
        }
    }
}
