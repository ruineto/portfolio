namespace BD_PROJECT
{
    partial class AlterTurma
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMaxAlunos = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxDirector = new System.Windows.Forms.ComboBox();
            this.comboBoxDelegado = new System.Windows.Forms.ComboBox();
            this.textBoxAnoFim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAnoInicio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxAnoLectivo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 201);
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
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 70);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(416, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Director de Turma - BI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delegado de Turma - BI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max. de Alunos";
            // 
            // numericUpDownMaxAlunos
            // 
            this.numericUpDownMaxAlunos.Location = new System.Drawing.Point(12, 162);
            this.numericUpDownMaxAlunos.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMaxAlunos.Name = "numericUpDownMaxAlunos";
            this.numericUpDownMaxAlunos.Size = new System.Drawing.Size(72, 20);
            this.numericUpDownMaxAlunos.TabIndex = 10;
            this.numericUpDownMaxAlunos.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Turma";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(416, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxDirector
            // 
            this.comboBoxDirector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDirector.FormattingEnabled = true;
            this.comboBoxDirector.Location = new System.Drawing.Point(12, 115);
            this.comboBoxDirector.Name = "comboBoxDirector";
            this.comboBoxDirector.Size = new System.Drawing.Size(179, 21);
            this.comboBoxDirector.TabIndex = 27;
            // 
            // comboBoxDelegado
            // 
            this.comboBoxDelegado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDelegado.FormattingEnabled = true;
            this.comboBoxDelegado.Location = new System.Drawing.Point(249, 115);
            this.comboBoxDelegado.Name = "comboBoxDelegado";
            this.comboBoxDelegado.Size = new System.Drawing.Size(179, 21);
            this.comboBoxDelegado.TabIndex = 28;
            // 
            // textBoxAnoFim
            // 
            this.textBoxAnoFim.Enabled = false;
            this.textBoxAnoFim.Location = new System.Drawing.Point(349, 163);
            this.textBoxAnoFim.Name = "textBoxAnoFim";
            this.textBoxAnoFim.Size = new System.Drawing.Size(78, 20);
            this.textBoxAnoFim.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Fim";
            // 
            // textBoxAnoInicio
            // 
            this.textBoxAnoInicio.Enabled = false;
            this.textBoxAnoInicio.Location = new System.Drawing.Point(265, 162);
            this.textBoxAnoInicio.Name = "textBoxAnoInicio";
            this.textBoxAnoInicio.Size = new System.Drawing.Size(78, 20);
            this.textBoxAnoInicio.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Inicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ano Lectivo";
            // 
            // comboBoxAnoLectivo
            // 
            this.comboBoxAnoLectivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnoLectivo.FormattingEnabled = true;
            this.comboBoxAnoLectivo.Location = new System.Drawing.Point(121, 161);
            this.comboBoxAnoLectivo.Name = "comboBoxAnoLectivo";
            this.comboBoxAnoLectivo.Size = new System.Drawing.Size(130, 21);
            this.comboBoxAnoLectivo.TabIndex = 29;
            this.comboBoxAnoLectivo.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnoLectivo_SelectedIndexChanged);
            // 
            // AlterTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 238);
            this.Controls.Add(this.textBoxAnoFim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxAnoInicio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxAnoLectivo);
            this.Controls.Add(this.comboBoxDelegado);
            this.Controls.Add(this.comboBoxDirector);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDownMaxAlunos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AlterTurma";
            this.Text = "Altera Turma";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxAlunos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxDirector;
        private System.Windows.Forms.ComboBox comboBoxDelegado;
        private System.Windows.Forms.TextBox textBoxAnoFim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAnoInicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxAnoLectivo;
    }
}