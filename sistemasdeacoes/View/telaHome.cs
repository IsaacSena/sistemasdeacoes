using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemasdeacoes.View
{
    public partial class telaHome : Form
    {
        public telaHome()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaCadastro telaCadastro = new telaCadastro();
            telaCadastro.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void porCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisarCodigo telaPesquisarCodigo = new TelaPesquisarCodigo();
            telaPesquisarCodigo.Show();
        }

        private void porNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisarNome telaPesquisarNome = new TelaPesquisarNome();
            telaPesquisarNome.Show();
        }

        private void manipularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaManipular telaManipular = new TelaManipular();
            telaManipular.Show();
        }
    }
}
