using sistemasdeacoes.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sistemasdeacoes.Controller
{
    internal class ControllerAtivo
    {
        public void CadastrarAtivo()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_CadastrarAtivo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@tipoAtivo", Ativos.TipoAtipo);
                cmd.Parameters.AddWithValue("@nomeAtivo", Ativos.NomeAtivo);
                cmd.Parameters.AddWithValue("@dataCompraAtivo", Ativos.DataCompraAtivo);
                cmd.Parameters.AddWithValue("@qdtAtivo", Ativos.QdtAtivo);
                cmd.Parameters.AddWithValue("@precoAtivo", Ativos.PrecoAtivo);
                cmd.Parameters.AddWithValue("@custoAtivo", Ativos.CustoAtivo);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Cadastrados com sucesso.");
            }
            catch (Exception) 
            {
                throw;
            }
        }
        public void DeletarAtivo()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_ExcluirAtivo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoAtivo", Ativos.CodigoAtivo);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros Excluido");
            }

            catch (Exception)
            {
                throw;
            }
        }
        public void AlterarAtivo() 
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarAtivo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@tipoAtivo", Ativos.TipoAtipo);
                cmd.Parameters.AddWithValue("@codigoAtivo", Ativos.CodigoAtivo);
                cmd.Parameters.AddWithValue("@nomeAtivo", Ativos.NomeAtivo);
                cmd.Parameters.AddWithValue("@dataCompraAtivo", Ativos.DataCompraAtivo);
                cmd.Parameters.AddWithValue("@qdtAtivo", Ativos.QdtAtivo);
                cmd.Parameters.AddWithValue("@precoAtivo", Ativos.PrecoAtivo);
                cmd.Parameters.AddWithValue("@custoAtivo", Ativos.CustoAtivo);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros Alterados com sucesso");

            }

            catch(Exception)
            { 
                throw;
            }
        }
        public void VisualizarCodigoAtivo()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_VisualizarCodigoAtivo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoAtivo", Ativos.CodigoAtivo);
                cn.Open() ;
                cmd.ExecuteNonQuery();

                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Ativos.CodigoAtivo = Convert.ToInt32(dr["codigoAtivo"]);
                    Ativos.TipoAtipo = (string)dr["tipoAtivo"];
                    Ativos.NomeAtivo = dr["nomeAtivo"].ToString();
                    Ativos.DataCompraAtivo = Convert.ToDateTime(dr["dataCompraAtivo"]);
                    Ativos.QdtAtivo = (int)dr["qdtAtivo"];
                    Ativos.PrecoAtivo = (decimal)dr["precoAtivo"];
                    Ativos.CustoAtivo = (decimal)dr["custoAtivo"];
                }
                else
                {
                    Ativos.CodigoAtivo = 0;
                    Ativos.TipoAtipo = "";
                    Ativos.CustoAtivo = 0;
                    Ativos.PrecoAtivo = 0;
                    Ativos.NomeAtivo = "";
                    MessageBox.Show("Código não localizada.");
                }
            }

            catch (Exception)
            {
                throw;
            }
        }
        public static BindingSource VisualizarNomeAtivo() 
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_VisualizarNomeAtivo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nomeAtivo", Ativos.NomeAtivo);
            cn.Open();
            cmd.ExecuteNonQuery();
            
            SqlDataAdapter sqldata = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqldata.Fill(table);    

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;

        }
    }
}
