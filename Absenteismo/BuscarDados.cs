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
        public void Buscar()
       {
            Form1 f1 = new Form1();
           
            String UNIDADE = "";
            String SETOR = "";
            String TURNO = "";
            String FUNCIONARIO = "";
            String MATRICULA = "";
            OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\yuri_prado\Documents\Absenteismo.mdb");
            OleDbCommand cmd = new OleDbCommand("SELECT NOME_FUNC, UNIDADE, TURNO, SETOR FROM ABS WHERE MATRICULA = @PARAMETRO1", conn);
            cmd.Parameters.AddWithValue("PARAMETRO1", f1.txt_consMatricula.Text);
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MATRICULA = reader["NOME_FUNC"].ToString();
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
                f1.txt_resultNome.Text = FUNCIONARIO;
                f1.txt_resultSetor.Text = SETOR;
                f1.txt_resultUnidade.Text = UNIDADE;
                f1.txt_resultTurno.Text = TURNO;
                String dt = DateTime.Now.ToString("dd/MM/yyyy");
                f1.txt_data.Text = dt;
            }
        }
    }
}
