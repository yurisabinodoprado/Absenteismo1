namespace Absenteismo
{
    partial class FormConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_consMatricula = new System.Windows.Forms.TextBox();
            this.txt_resultNome = new System.Windows.Forms.TextBox();
            this.txt_resultUnidade = new System.Windows.Forms.TextBox();
            this.btn_cons = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_motivo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_resultTurno = new System.Windows.Forms.TextBox();
            this.txt_resultSetor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_registros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(335, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(335, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Setor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(173, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "CONTROLE DIÁRIO DE ABSENTEÍSMO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_consMatricula
            // 
            this.txt_consMatricula.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_consMatricula.Location = new System.Drawing.Point(270, 76);
            this.txt_consMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.txt_consMatricula.Name = "txt_consMatricula";
            this.txt_consMatricula.Size = new System.Drawing.Size(129, 32);
            this.txt_consMatricula.TabIndex = 5;
            this.txt_consMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_consMatricula.TextChanged += new System.EventHandler(this.txt_consMatricula_TextChanged);
            // 
            // txt_resultNome
            // 
            this.txt_resultNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultNome.Location = new System.Drawing.Point(393, 146);
            this.txt_resultNome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_resultNome.Name = "txt_resultNome";
            this.txt_resultNome.Size = new System.Drawing.Size(270, 22);
            this.txt_resultNome.TabIndex = 7;
            // 
            // txt_resultUnidade
            // 
            this.txt_resultUnidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultUnidade.Location = new System.Drawing.Point(96, 195);
            this.txt_resultUnidade.Margin = new System.Windows.Forms.Padding(2);
            this.txt_resultUnidade.Name = "txt_resultUnidade";
            this.txt_resultUnidade.Size = new System.Drawing.Size(129, 22);
            this.txt_resultUnidade.TabIndex = 9;
            // 
            // btn_cons
            // 
            this.btn_cons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(173)))));
            this.btn_cons.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cons.ForeColor = System.Drawing.Color.White;
            this.btn_cons.Location = new System.Drawing.Point(321, 347);
            this.btn_cons.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cons.Name = "btn_cons";
            this.btn_cons.Size = new System.Drawing.Size(140, 58);
            this.btn_cons.TabIndex = 10;
            this.btn_cons.Text = "Consultar";
            this.btn_cons.UseVisualStyleBackColor = false;
            this.btn_cons.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(173)))));
            this.btn_cadastrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(491, 347);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(140, 58);
            this.btn_cadastrar.TabIndex = 11;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_data
            // 
            this.txt_data.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.Location = new System.Drawing.Point(96, 150);
            this.txt_data.Margin = new System.Windows.Forms.Padding(2);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(127, 22);
            this.txt_data.TabIndex = 13;
            this.txt_data.TextChanged += new System.EventHandler(this.txt_data_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(39, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(86, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Motivo";
            // 
            // cb_motivo
            // 
            this.cb_motivo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_motivo.FormattingEnabled = true;
            this.cb_motivo.Items.AddRange(new object[] {
            "FALTA INJUSTIFICADA",
            "ATESTADO MÉDICO",
            "PARTICULAR",
            "ACOMPANHAMENTO FAMILIAR"});
            this.cb_motivo.Location = new System.Drawing.Point(15, 290);
            this.cb_motivo.Margin = new System.Windows.Forms.Padding(2);
            this.cb_motivo.Name = "cb_motivo";
            this.cb_motivo.Size = new System.Drawing.Size(208, 24);
            this.cb_motivo.TabIndex = 17;
            this.cb_motivo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(335, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Turno";
            // 
            // txt_resultTurno
            // 
            this.txt_resultTurno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultTurno.Location = new System.Drawing.Point(393, 232);
            this.txt_resultTurno.Name = "txt_resultTurno";
            this.txt_resultTurno.Size = new System.Drawing.Size(42, 22);
            this.txt_resultTurno.TabIndex = 20;
            // 
            // txt_resultSetor
            // 
            this.txt_resultSetor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultSetor.Location = new System.Drawing.Point(393, 192);
            this.txt_resultSetor.Name = "txt_resultSetor";
            this.txt_resultSetor.Size = new System.Drawing.Size(165, 22);
            this.txt_resultSetor.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(201, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Digite a matrícula do funcionário";
            // 
            // btn_registros
            // 
            this.btn_registros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(173)))));
            this.btn_registros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registros.ForeColor = System.Drawing.Color.White;
            this.btn_registros.Location = new System.Drawing.Point(491, 271);
            this.btn_registros.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registros.Name = "btn_registros";
            this.btn_registros.Size = new System.Drawing.Size(140, 58);
            this.btn_registros.TabIndex = 23;
            this.btn_registros.Text = "Ver Registros";
            this.btn_registros.UseVisualStyleBackColor = false;
            this.btn_registros.Click += new System.EventHandler(this.btn_registros_Click);
            // 
            // FormConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(674, 412);
            this.Controls.Add(this.btn_registros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_resultSetor);
            this.Controls.Add(this.txt_resultTurno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_motivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_cons);
            this.Controls.Add(this.txt_resultUnidade);
            this.Controls.Add(this.txt_resultNome);
            this.Controls.Add(this.txt_consMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 451);
            this.MinimumSize = new System.Drawing.Size(690, 451);
            this.Name = "FormConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Absenteísmo LSL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cons;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_consMatricula;
        public System.Windows.Forms.TextBox txt_resultNome;
        public System.Windows.Forms.TextBox txt_resultUnidade;
        public System.Windows.Forms.TextBox txt_data;
        public System.Windows.Forms.ComboBox cb_motivo;
        public System.Windows.Forms.TextBox txt_resultTurno;
        public System.Windows.Forms.TextBox txt_resultSetor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_registros;
    }
}

