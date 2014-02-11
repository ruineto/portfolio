namespace BD_PROJECT
{
    partial class AddTurma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDelegado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMaxAlunos = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDisciplinas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDisciplina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxAnoLectivo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAnoInicio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAnoFim = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxAnoEscolar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(439, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 30);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(416, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(12, 75);
            this.textBoxDirector.MaxLength = 9;
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(179, 20);
            this.textBoxDirector.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Director de Turma - BI";
            // 
            // textBoxDelegado
            // 
            this.textBoxDelegado.Location = new System.Drawing.Point(249, 75);
            this.textBoxDelegado.MaxLength = 9;
            this.textBoxDelegado.Name = "textBoxDelegado";
            this.textBoxDelegado.Size = new System.Drawing.Size(179, 20);
            this.textBoxDelegado.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delegado de Turma - BI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero Max. de Alunos";
            // 
            // numericUpDownMaxAlunos
            // 
            this.numericUpDownMaxAlunos.Location = new System.Drawing.Point(12, 122);
            this.numericUpDownMaxAlunos.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMaxAlunos.Name = "numericUpDownMaxAlunos";
            this.numericUpDownMaxAlunos.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxAlunos.TabIndex = 10;
            this.numericUpDownMaxAlunos.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // comboBoxDisciplinas
            // 
            this.comboBoxDisciplinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisciplinas.FormattingEnabled = true;
            this.comboBoxDisciplinas.Location = new System.Drawing.Point(12, 169);
            this.comboBoxDisciplinas.Name = "comboBoxDisciplinas";
            this.comboBoxDisciplinas.Size = new System.Drawing.Size(416, 21);
            this.comboBoxDisciplinas.TabIndex = 11;
            this.comboBoxDisciplinas.SelectedIndexChanged += new System.EventHandler(this.comboBoxDisciplinas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Disciplina";
            // 
            // textBoxDisciplina
            // 
            this.textBoxDisciplina.Enabled = false;
            this.textBoxDisciplina.Location = new System.Drawing.Point(12, 209);
            this.textBoxDisciplina.Name = "textBoxDisciplina";
            this.textBoxDisciplina.Size = new System.Drawing.Size(416, 20);
            this.textBoxDisciplina.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nova Disciplina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ano Lectivo";
            // 
            // comboBoxAnoLectivo
            // 
            this.comboBoxAnoLectivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnoLectivo.FormattingEnabled = true;
            this.comboBoxAnoLectivo.Location = new System.Drawing.Point(12, 249);
            this.comboBoxAnoLectivo.Name = "comboBoxAnoLectivo";
            this.comboBoxAnoLectivo.Size = new System.Drawing.Size(130, 21);
            this.comboBoxAnoLectivo.TabIndex = 15;
            this.comboBoxAnoLectivo.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnoLectivo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fim";
            // 
            // textBoxAnoInicio
            // 
            this.textBoxAnoInicio.Enabled = false;
            this.textBoxAnoInicio.Location = new System.Drawing.Point(159, 249);
            this.textBoxAnoInicio.Name = "textBoxAnoInicio";
            this.textBoxAnoInicio.Size = new System.Drawing.Size(78, 20);
            this.textBoxAnoInicio.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Inicio";
            // 
            // textBoxAnoFim
            // 
            this.textBoxAnoFim.Enabled = false;
            this.textBoxAnoFim.Location = new System.Drawing.Point(243, 250);
            this.textBoxAnoFim.Name = "textBoxAnoFim";
            this.textBoxAnoFim.Size = new System.Drawing.Size(78, 20);
            this.textBoxAnoFim.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(246, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Ano Escolar";
            // 
            // comboBoxAnoEscolar
            // 
            this.comboBoxAnoEscolar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnoEscolar.FormattingEnabled = true;
            this.comboBoxAnoEscolar.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxAnoEscolar.Location = new System.Drawing.Point(249, 122);
            this.comboBoxAnoEscolar.Name = "comboBoxAnoEscolar";
            this.comboBoxAnoEscolar.Size = new System.Drawing.Size(179, 21);
            this.comboBoxAnoEscolar.TabIndex = 24;
            // 
            // FormAddTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 322);
            this.Controls.Add(this.comboBoxAnoEscolar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxAnoFim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxAnoInicio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxAnoLectivo);
            this.Controls.Add(this.textBoxDisciplina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDisciplinas);
            this.Controls.Add(this.numericUpDownMaxAlunos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDelegado);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FormAddTurma";
            this.Text = "Criar Nova Turma";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDelegado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxAlunos;
        private System.Windows.Forms.ComboBox comboBoxDisciplinas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDisciplina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxAnoLectivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAnoInicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAnoFim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxAnoEscolar;
    }
}