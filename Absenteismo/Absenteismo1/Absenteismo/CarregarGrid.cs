using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Absenteismo
{
    public class CarregarGrid
    {
        public void Carregar(DataGridView dataGridView1)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\YURIS\OneDrive - LSL Transportes LTDA\Absenteismo.mdb");
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM ABS_REGISTROS", conn);
            try
            {
                conn.Open();

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                DataTable tabela_temporaria = new DataTable();

                da.Fill(tabela_temporaria);

                dataGridView1.DataSource = tabela_temporaria;

                conn.Close();
            }

            //Caso haja um erro no procedimento: retornar mensagem de erro
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado");
            }
        }
    }
}
