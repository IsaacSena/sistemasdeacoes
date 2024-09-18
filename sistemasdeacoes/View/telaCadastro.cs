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
    public partial class telaCadastro : Form
    {
        public telaCadastro()
        {
            InitializeComponent();
        }

        private void but_salvarCadastrar_Click(object sender, EventArgs e)
        {
            Ativos.TipoAtipo = cbx_tipoAtivoCadastrar.Text;
            Ativos.NomeAtivo = cbx_AtivoCadastrar.Text;
            Ativos.DataCompraAtivo = dtp_dataCompraCadastrar.Value;
            Ativos.QdtAtivo = (int)nud_quantidadeCadastrar.Value;
            Ativos.PrecoAtivo = Convert.ToDecimal(tbx_precoAtivoCadastrar.Text);
            Ativos.CustoAtivo = Convert.ToDecimal(tbx_custoAtivosCadastrar.Text);




            ControllerAtivo controllerAtivo = new ControllerAtivo();
            controllerAtivo.CadastrarAtivo();

            cbx_tipoAtivoCadastrar.Text = "";
            cbx_AtivoCadastrar.Text = "";
            nud_quantidadeCadastrar.Value = 0;
            tbx_precoAtivoCadastrar.Text = "R$ 0,00";
            tbx_custoAtivosCadastrar.Text = "R$ 0,00";



        }

        private void but_cancelarCadastrar_Click(object sender, EventArgs e)
        {
            cbx_tipoAtivoCadastrar.Text = "";
            cbx_AtivoCadastrar.Text = "";
            nud_quantidadeCadastrar.Value = 0;
            tbx_precoAtivoCadastrar.Text = "0,00";
            tbx_custoAtivosCadastrar.Text = "0,00";
        }

        private void valortotal_Click(object sender, EventArgs e)
        {
            decimal qdtAtivo = nud_quantidadeCadastrar.Value == null ? 0 : nud_quantidadeCadastrar.Value;
            decimal precoAtivo = tbx_precoAtivoCadastrar.Text == "" ? Convert.ToDecimal(0) : Convert.ToDecimal(tbx_precoAtivoCadastrar.Text);
            decimal custoAtivo = tbx_custoAtivosCadastrar.Text == "" ? Convert.ToDecimal(0) : Convert.ToDecimal(tbx_custoAtivosCadastrar.Text);
            decimal total = 0;

            total = qdtAtivo * precoAtivo + custoAtivo;
            valortotal.Text = "Valor Total R$" + total.ToString();
        }

        private void telaCadastro_Load(object sender, EventArgs e)
        {

        }

        
    }
}
