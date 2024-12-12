using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Absenteismo
{
    internal class Login
    {
        public void Validacao(TextBox txt_usuario, TextBox txt_senha, FormLogin formLogin)
        {
            String USUARIO = "";
            String SENHA = "";
            OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\YURIS\OneDrive - LSL Transportes LTDA\Absenteismo.mdb");
            OleDbCommand cmd = new OleDbCommand("SELECT USUARIO, SENHA FROM USUARIOS WHERE USUARIO = @PARAMETRO1 AND SENHA = @PARAMETRO2", conn);
            cmd.Parameters.AddWithValue("PARAMETRO1", txt_usuario.Text);
            cmd.Parameters.AddWithValue("PARAMETRO1", txt_senha.Text);

            conn.Open();

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                USUARIO= reader["USUARIO"].ToString();
            }

            conn.Close();

            if (USUARIO == "")
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
            else
            {
                String bv = "Seja Bem-Vindo ";
                MessageBox.Show(bv + txt_usuario.Text.ToUpper(), "Login efetuado com sucesso!");
                formLogin.Hide();
                FormConsultar fc = new FormConsultar();
                fc.ShowDialog();
                formLogin.Close();
            }

        }
    }
}
