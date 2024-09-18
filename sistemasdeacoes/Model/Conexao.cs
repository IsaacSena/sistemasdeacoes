using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasdeacoes.Model
{
    internal class Conexao
    {
        public static string Conectar() 
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isaac.smartins1\source\repos\sistemasdeacoes\sistemasdeacoes\Dados\bdAcoes.mdf;Integrated Security=True";
        }
    }
}
