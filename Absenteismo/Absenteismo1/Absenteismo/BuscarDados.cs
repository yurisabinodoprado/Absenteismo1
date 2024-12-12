using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Absenteismo
{
    internal class BuscarDados
    {
        public void Buscar(TextBox txt_consMatricula, TextBox txt_data, TextBox txt_resultUnidade, TextBox txt_resultNome, TextBox txt_resultTurno, TextBox txt_resultSetor)
       {    
            String UNIDADE = "";
            String SETOR = "";
            String TURNO = "";
            String FUNCIONARIO = "";
            String MATRICULA = "";
            OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\YURIS\OneDrive - LSL Transportes LTDA\Absenteismo.mdb");
            OleDbCommand cmd = new OleDbCommand("SELECT MATRICULA, NOME_FUNC, UNIDADE, TURNO, SETOR FROM ABS WHERE MATRICULA = @PARAMETRO1", conn);
            cmd.Parameters.AddWithValue("PARAMETRO1", txt_consMatricula.Text);

            conn.Open();

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                MATRICULA = reader["MATRICULA"].ToString();
                FUNCIONARIO = reader["NOME_FUNC"].ToString();
                UNIDADE = reader["UNIDADE"].ToString();
                TURNO = reader["TURNO"].ToString();
                SETOR = reader["SETOR"].ToString();
            }

            conn.Close();

            if (MATRICULA == "")
            {
                MessageBox.Show("Matrícula Inválida");
            }
            else
            {
                txt_resultNome.Text = FUNCIONARIO;
                txt_resultSetor.Text = SETOR;
                txt_resultUnidade.Text = UNIDADE;
                txt_resultTurno.Text = TURNO;
                String dt = DateTime.Now.ToString("dd/MM/yyyy");
                txt_data.Text = dt;
            }
        }
    }
}
