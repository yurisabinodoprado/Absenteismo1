using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Absenteismo
{
    internal class InserirDados
    {
        public void Inserir()
        {
            OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\yuri_prado\Documents\Absenteismo.mdb");
            Form1 f1 = new Form1();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO ABS_REGISTROS (MATRICULA, DATA, UNIDADE, NOME_FUNC, TURNO, SETOR, MOTIVO) VALUES ( @PARAMETRO1, @PARAMETRO5, @PARAMETRO2, @PARAMETRO3, @PARAMETRO7, @PARAMETRO4, @PARAMETRO6)", conn);
            cmd.Parameters.AddWithValue("PARAMETRO1", f1.txt_consMatricula.Text);
            cmd.Parameters.AddWithValue("PARAMETRO5", f1.txt_data.Text);
            cmd.Parameters.AddWithValue("PARAMETRO2", f1.txt_resultUnidade.Text);
            cmd.Parameters.AddWithValue("PARAMETRO3", f1.txt_resultNome.Text);
            cmd.Parameters.AddWithValue("PARAMETRO7", f1.txt_resultTurno.Text);
            cmd.Parameters.AddWithValue("PARAMETRO4", f1.txt_resultSetor.Text);
            cmd.Parameters.AddWithValue("PARAMETRO6", f1.cb_motivo.Text);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Falha ao cadastrar absenteísmo");
            }
            conn.Close();

            f1.txt_resultNome.ResetText();
            f1.txt_resultSetor.ResetText();
            f1.txt_resultTurno.ResetText();
            f1.txt_resultUnidade.ResetText();
            f1.cb_motivo.ResetText();
            f1.txt_consMatricula.ResetText();
            f1.txt_data.ResetText();
        }
    }
}
