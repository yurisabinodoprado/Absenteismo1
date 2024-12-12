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
        public void Inserir(TextBox txt_consMatricula, TextBox txt_data, TextBox txt_resultUnidade, TextBox txt_resultNome, TextBox txt_resultTurno, TextBox txt_resultSetor, ComboBox cb_motivo)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\YURIS\OneDrive - LSL Transportes LTDA\Absenteismo.mdb");
            OleDbCommand cmd = new OleDbCommand("INSERT INTO ABS_REGISTROS (MATRICULA, DATA, UNIDADE, NOME_FUNC, TURNO, SETOR, MOTIVO) VALUES ( @PARAMETRO1, @PARAMETRO5, @PARAMETRO2, @PARAMETRO3, @PARAMETRO7, @PARAMETRO4, @PARAMETRO6)", conn);
            cmd.Parameters.AddWithValue("PARAMETRO1", txt_consMatricula.Text);
            cmd.Parameters.AddWithValue("PARAMETRO5", txt_data.Text);
            cmd.Parameters.AddWithValue("PARAMETRO2", txt_resultUnidade.Text);
            cmd.Parameters.AddWithValue("PARAMETRO3", txt_resultNome.Text);
            cmd.Parameters.AddWithValue("PARAMETRO7", txt_resultTurno.Text);
            cmd.Parameters.AddWithValue("PARAMETRO4", txt_resultSetor.Text);
            cmd.Parameters.AddWithValue("PARAMETRO6", cb_motivo.Text);
            conn.Open();
            if (String.IsNullOrEmpty(txt_consMatricula.Text) || String.IsNullOrEmpty(txt_data.Text) || String.IsNullOrEmpty(txt_resultUnidade.Text) || String.IsNullOrEmpty(txt_resultNome.Text) || String.IsNullOrEmpty(txt_resultTurno.Text) || String.IsNullOrEmpty(txt_resultSetor.Text) || String.IsNullOrEmpty(cb_motivo.Text))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
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

                txt_resultNome.ResetText();
                txt_resultSetor.ResetText();
                txt_resultTurno.ResetText();
                txt_resultUnidade.ResetText();
                cb_motivo.ResetText();
                txt_consMatricula.ResetText();
                txt_data.ResetText();
            }
        }
    }
}
