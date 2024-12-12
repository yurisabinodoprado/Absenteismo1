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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            lgn.Validacao(txt_usuario, txt_senha, formLogin: this);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
