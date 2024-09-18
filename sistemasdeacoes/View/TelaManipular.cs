using sistemasdeacoes.Controller;
using sistemasdeacoes.Model;
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
    public partial class TelaManipular : Form
    {
        public TelaManipular()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ativos.CodigoAtivo = Convert.ToInt32(tbx_pesquisarTelaPesquisar.Text);
            ControllerAtivo controllerAtivo = new ControllerAtivo();
            controllerAtivo.VisualizarCodigoAtivo();

            tbx_tipoAtivotelaPesquisa.Text = Ativos.TipoAtipo;
            tbx_ativoPesquisa.Text = Ativos.NomeAtivo;
            dtp_pesquisaCodigo.Text = Ativos.DataCompraAtivo.ToString();
            tbx_precoAtivo.Text = Ativos.PrecoAtivo.ToString();
            nud_quantidadeCadastrar.Text = Ativos.QdtAtivo.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbx_pesquisarTelaPesquisar.Text == "")
            {
                MessageBox.Show("Digite o Código do Ativo");
            }
            else
            {
                var reposta = MessageBox.Show("Deseja alterar as informações do ativo" + tbx_ativoPesquisa + "?", "Atenção", MessageBoxButtons.YesNo,MessageBoxIcon.Stop);

                if (reposta == DialogResult.Yes)
                {
                    Ativos.TipoAtipo = tbx_tipoAtivotelaPesquisa.Text;
                    Ativos.NomeAtivo = tbx_ativoPesquisa.Text;
                    Ativos.DataCompraAtivo = dtp_pesquisaCodigo.Value;
                    Ativos.QdtAtivo = Convert.ToInt32(nud_quantidadeCadastrar.Text);
                    Ativos.PrecoAtivo = Convert.ToDecimal(tbx_precoAtivo.Text);
                   

                    ControllerAtivo controllerAtivo = new ControllerAtivo();
                    controllerAtivo.AlterarAtivo();
                }
                else
                {
                    tbx_tipoAtivotelaPesquisa.Text = "";
                    tbx_ativoPesquisa.Text = "";
                    dtp_pesquisaCodigo.Value = DateTime.Now;
                    nud_quantidadeCadastrar.Text = "";
                    tbx_precoAtivo.Text = "";
               
                }
            }
        }
    }
}
