namespace Absenteismo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_consMatricula = new System.Windows.Forms.TextBox();
            this.txt_resultSetor = new System.Windows.Forms.TextBox();
            this.txt_resultNome = new System.Windows.Forms.TextBox();
            this.txt_resultUnidade = new System.Windows.Forms.TextBox();
            this.btn_cons = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_registros = new System.Windows.Forms.Button();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_motivo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_resultTurno = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_resulSetor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(119, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(119, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(119, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Setor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(107, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(520, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Digite a matrícula do funcionário";
            // 
            // txt_consMatricula
            // 
            this.txt_consMatricula.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_consMatricula.Location = new System.Drawing.Point(251, 62);
            this.txt_consMatricula.Name = "txt_consMatricula";
            this.txt_consMatricula.Size = new System.Drawing.Size(192, 44);
            this.txt_consMatricula.TabIndex = 5;
            this.txt_consMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_resultSetor
            // 
            this.txt_resultSetor.Location = new System.Drawing.Point(266, 318);
            this.txt_resultSetor.Name = "txt_resultSetor";
            this.txt_resultSetor.Size = new System.Drawing.Size(245, 26);
            this.txt_resultSetor.TabIndex = 6;
            this.txt_resultSetor.TextChanged += new System.EventHandler(this.txt_resultSetor_TextChanged);
            // 
            // txt_resultNome
            // 
            this.txt_resultNome.Location = new System.Drawing.Point(266, 234);
            this.txt_resultNome.Name = "txt_resultNome";
            this.txt_resultNome.Size = new System.Drawing.Size(352, 26);
            this.txt_resultNome.TabIndex = 7;
            // 
            // txt_resultUnidade
            // 
            this.txt_resultUnidade.Location = new System.Drawing.Point(266, 189);
            this.txt_resultUnidade.Name = "txt_resultUnidade";
            this.txt_resultUnidade.Size = new System.Drawing.Size(192, 26);
            this.txt_resultUnidade.TabIndex = 9;
            // 
            // btn_cons
            // 
            this.btn_cons.BackColor = System.Drawing.Color.White;
            this.btn_cons.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cons.Location = new System.Drawing.Point(266, 434);
            this.btn_cons.Name = "btn_cons";
            this.btn_cons.Size = new System.Drawing.Size(177, 46);
            this.btn_cons.TabIndex = 10;
            this.btn_cons.Text = "Consultar";
            this.btn_cons.UseVisualStyleBackColor = false;
            this.btn_cons.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.White;
            this.btn_cadastrar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(12, 434);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(177, 46);
            this.btn_cadastrar.TabIndex = 11;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_registros
            // 
            this.btn_registros.BackColor = System.Drawing.Color.White;
            this.btn_registros.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registros.Location = new System.Drawing.Point(479, 434);
            this.btn_registros.Name = "btn_registros";
            this.btn_registros.Size = new System.Drawing.Size(199, 46);
            this.btn_registros.TabIndex = 12;
            this.btn_registros.Text = "Ver Registros";
            this.btn_registros.UseVisualStyleBackColor = false;
            this.btn_registros.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(266, 139);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(109, 26);
            this.txt_data.TabIndex = 13;
            this.txt_data.TextChanged += new System.EventHandler(this.txt_data_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(119, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(119, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Motivo";
            // 
            // cb_motivo
            // 
            this.cb_motivo.FormattingEnabled = true;
            this.cb_motivo.Items.AddRange(new object[] {
            "FALTA INJUSTIFICADA",
            "ATESTADO MÉDICO",
            "PARTICULAR",
            "ACOMPANHAMENTO FAMILIAR"});
            this.cb_motivo.Location = new System.Drawing.Point(266, 363);
            this.cb_motivo.Name = "cb_motivo";
            this.cb_motivo.Size = new System.Drawing.Size(245, 28);
            this.cb_motivo.TabIndex = 17;
            this.cb_motivo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(119, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Turno";
            // 
            // txt_resultTurno
            // 
            this.txt_resultTurno.Location = new System.Drawing.Point(266, 277);
            this.txt_resultTurno.Name = "txt_resultTurno";
            this.txt_resultTurno.Size = new System.Drawing.Size(57, 26);
            this.txt_resultTurno.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(266, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.txt_resultSetor_TextChanged);
            // 
            // txt_resulSetor
            // 
            this.txt_resulSetor.Location = new System.Drawing.Point(266, 278);
            this.txt_resulSetor.Name = "txt_resulSetor";
            this.txt_resulSetor.Size = new System.Drawing.Size(57, 26);
            this.txt_resulSetor.TabIndex = 20;
            this.txt_resulSetor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 547);
            this.Controls.Add(this.txt_resulSetor);
            this.Controls.Add(this.txt_resultTurno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_motivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.btn_registros);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_cons);
            this.Controls.Add(this.txt_resultUnidade);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_resultNome);
            this.Controls.Add(this.txt_resultSetor);
            this.Controls.Add(this.txt_consMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_resultSetor;
        private System.Windows.Forms.Button btn_cons;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_registros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_resultTurno;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txt_resulSetor;
        public System.Windows.Forms.TextBox txt_consMatricula;
        public System.Windows.Forms.TextBox txt_resultNome;
        public System.Windows.Forms.TextBox txt_resultUnidade;
        public System.Windows.Forms.TextBox txt_data;
        public System.Windows.Forms.ComboBox cb_motivo;
    }
}

