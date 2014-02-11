namespace BD_PROJECT
{
    partial class RemoveEstudanteTurma
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
            this.comboBoxTurmas = new System.Windows.Forms.ComboBox();
            this.comboBoxAlunos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(439, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turma";
            // 
            // comboBoxTurmas
            // 
            this.comboBoxTurmas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTurmas.FormattingEnabled = true;
            this.comboBoxTurmas.Location = new System.Drawing.Point(12, 29);
            this.comboBoxTurmas.Name = "comboBoxTurmas";
            this.comboBoxTurmas.Size = new System.Drawing.Size(415, 21);
            this.comboBoxTurmas.TabIndex = 2;
            this.comboBoxTurmas.SelectedIndexChanged += new System.EventHandler(this.comboBoxTurmas_SelectedIndexChanged);
            // 
            // comboBoxAlunos
            // 
            this.comboBoxAlunos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlunos.FormattingEnabled = true;
            this.comboBoxAlunos.Location = new System.Drawing.Point(12, 92);
            this.comboBoxAlunos.Name = "comboBoxAlunos";
            this.comboBoxAlunos.Size = new System.Drawing.Size(415, 21);
            this.comboBoxAlunos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estudante";
            // 
            // FormRemoveEstudanteTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 164);
            this.Controls.Add(this.comboBoxAlunos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTurmas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRemoveEstudanteTurma";
            this.Text = "Remover Estudante da Turma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTurmas;
        private System.Windows.Forms.ComboBox comboBoxAlunos;
        private System.Windows.Forms.Label label2;
    }
}