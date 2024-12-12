using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Absenteismo
{
    public partial class FormResgistros : Form
    {
        public FormResgistros()
        {
            InitializeComponent();
            CarregarGrid carregarDataGridView = new CarregarGrid();
            carregarDataGridView.Carregar(dataGridView1: gridAbsenteismo);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarGrid carregarDataGridView = new CarregarGrid();
            carregarDataGridView.Carregar(dataGridView1:gridAbsenteismo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConsultar fc =  new FormConsultar();
            fc.ShowDialog();
            this.Close();
        }
    }
}
