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
    public partial class TelaPesquisarNome : Form
    {
        public TelaPesquisarNome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ativos.NomeAtivo = tbx_barrapesquisa.Text;
            dgv_ativo.DataSource = ControllerAtivo.VisualizarNomeAtivo();
            dgv_ativo.Columns[0].Visible = false;
            dgv_ativo.Columns[1].Visible = false;
            dgv_ativo.Columns[2].Visible = false;
            dgv_ativo.Columns[3].Visible = false;
            dgv_ativo.Columns[4].Visible = false;
            dgv_ativo.Columns[5].Visible = false;
            dgv_ativo.Columns[6].Visible = false;

            dgv_ativo.Columns[7].HeaderCell.Value = "Código";
            dgv_ativo.Columns[8].HeaderCell.Value = "Tipo Ativo";
            dgv_ativo.Columns[9].HeaderCell.Value = "Ativo";
            dgv_ativo.Columns[10].HeaderCell.Value = "Data Compra";
            dgv_ativo.Columns[11].HeaderCell.Value = "Qdt";
            dgv_ativo.Columns[12].HeaderCell.Value = "Preço";
            dgv_ativo.Columns[13].HeaderCell.Value = "Custos";

        }
    }
}
