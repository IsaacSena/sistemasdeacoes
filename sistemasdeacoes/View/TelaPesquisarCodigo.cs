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
    public partial class TelaPesquisarCodigo : Form
    {
        public TelaPesquisarCodigo()
        {
            InitializeComponent();
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
            tbx_qdtCodigo.Text = Ativos.QdtAtivo.ToString();   
        }
    }
}
