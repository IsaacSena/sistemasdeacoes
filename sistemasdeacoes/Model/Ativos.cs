using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasdeacoes.Model
{
    internal class Ativos
    {

        private static int codigoAtivo;
        private static string tipoAtipo;
        private static string nomeAtivo;
        private static DateTime dataCompraAtivo;
        private static int qdtAtivo;
        private static decimal precoAtivo;
        private static decimal custoAtivo;

        public static int CodigoAtivo { get => codigoAtivo; set => codigoAtivo = value; }
        public static string TipoAtipo { get => tipoAtipo; set => tipoAtipo = value; }
        public static string NomeAtivo { get => nomeAtivo; set => nomeAtivo = value; }
        public static DateTime DataCompraAtivo { get => dataCompraAtivo; set => dataCompraAtivo = value; }
        public static int QdtAtivo { get => qdtAtivo; set => qdtAtivo = value; }
        public static decimal PrecoAtivo { get => precoAtivo; set => precoAtivo = value; }
        public static decimal CustoAtivo { get => custoAtivo; set => custoAtivo = value; }
    }
}
