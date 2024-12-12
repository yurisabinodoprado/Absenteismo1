using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Absenteismo
{
    public partial class FormConsultar : Form
    {
        BuscarDados bd = new BuscarDados();
        public FormConsultar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bd.Buscar(txt_consMatricula, txt_data, txt_resultUnidade, txt_resultNome, txt_resultTurno, txt_resultSetor);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InserirDados id = new InserirDados();
            id.Inserir(txt_consMatricula, txt_data, txt_resultUnidade, txt_resultNome, txt_resultTurno, txt_resultSetor, cb_motivo);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void txt_data_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_resultSetor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_consMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_registros_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormResgistros formResgistros = new FormResgistros();
            formResgistros.ShowDialog();
            this.Close();
        }
    }
}
