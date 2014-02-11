namespace BD_PROJECT
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.criarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profturToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sumárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudanteTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxDisciplinas = new System.Windows.Forms.ListBox();
            this.listBoxTurmas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProfDisciplinaBI = new System.Windows.Forms.Label();
            this.labelProfDisciplina = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.labelENC_EMAIL = new System.Windows.Forms.Label();
            this.labelTELF_ENC = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDATANasc = new System.Windows.Forms.Label();
            this.labelENC_EDU = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelEMAIL = new System.Windows.Forms.Label();
            this.labelInfoAluno = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelMORADA = new System.Windows.Forms.Label();
            this.labelDelegado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewAlunos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.professorTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarToolStripMenuItem,
            this.inserirToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.removerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // criarToolStripMenuItem
            // 
            this.criarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaToolStripMenuItem,
            this.turmaToolStripMenuItem,
            this.disciplinaToolStripMenuItem,
            this.sumárioToolStripMenuItem});
            this.criarToolStripMenuItem.Name = "criarToolStripMenuItem";
            this.criarToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.criarToolStripMenuItem.Text = "Criar";
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.pessoaToolStripMenuItem.Text = "Pessoa";
            this.pessoaToolStripMenuItem.Click += new System.EventHandler(this.pessoaToolStripMenuItem_Click);
            // 
            // turmaToolStripMenuItem
            // 
            this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            this.turmaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.turmaToolStripMenuItem.Text = "Turma";
            this.turmaToolStripMenuItem.Click += new System.EventHandler(this.turmaToolStripMenuItem_Click);
            // 
            // disciplinaToolStripMenuItem
            // 
            this.disciplinaToolStripMenuItem.Name = "disciplinaToolStripMenuItem";
            this.disciplinaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.disciplinaToolStripMenuItem.Text = "Disciplina";
            this.disciplinaToolStripMenuItem.Click += new System.EventHandler(this.disciplinaToolStripMenuItem_Click);
            // 
            // sumárioToolStripMenuItem
            // 
            this.sumárioToolStripMenuItem.Name = "sumárioToolStripMenuItem";
            this.sumárioToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.sumárioToolStripMenuItem.Text = "Sumário";
            this.sumárioToolStripMenuItem.Click += new System.EventHandler(this.sumárioToolStripMenuItem_Click);
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estturToolStripMenuItem,
            this.profturToolStripMenuItem1});
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.inserirToolStripMenuItem.Text = "Inserir";
            // 
            // estturToolStripMenuItem
            // 
            this.estturToolStripMenuItem.Name = "estturToolStripMenuItem";
            this.estturToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.estturToolStripMenuItem.Text = "Estudante - Turma";
            this.estturToolStripMenuItem.Click += new System.EventHandler(this.estturToolStripMenuItem_Click);
            // 
            // profturToolStripMenuItem1
            // 
            this.profturToolStripMenuItem1.Name = "profturToolStripMenuItem1";
            this.profturToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.profturToolStripMenuItem1.Text = "Professor - Turma";
            this.profturToolStripMenuItem1.Click += new System.EventHandler(this.profturToolStripMenuItem1_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaToolStripMenuItem2,
            this.turmaToolStripMenuItem2,
            this.disciplinaToolStripMenuItem2,
            this.sumárioToolStripMenuItem1});
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.alterarToolStripMenuItem.Text = "Alterar";
            // 
            // pessoaToolStripMenuItem2
            // 
            this.pessoaToolStripMenuItem2.Name = "pessoaToolStripMenuItem2";
            this.pessoaToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.pessoaToolStripMenuItem2.Text = "Pessoa";
            this.pessoaToolStripMenuItem2.Click += new System.EventHandler(this.pessoaToolStripMenuItem2_Click);
            // 
            // turmaToolStripMenuItem2
            // 
            this.turmaToolStripMenuItem2.Name = "turmaToolStripMenuItem2";
            this.turmaToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.turmaToolStripMenuItem2.Text = "Turma";
            this.turmaToolStripMenuItem2.Click += new System.EventHandler(this.turmaToolStripMenuItem2_Click);
            // 
            // disciplinaToolStripMenuItem2
            // 
            this.disciplinaToolStripMenuItem2.Name = "disciplinaToolStripMenuItem2";
            this.disciplinaToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.disciplinaToolStripMenuItem2.Text = "Disciplina";
            this.disciplinaToolStripMenuItem2.Click += new System.EventHandler(this.disciplinaToolStripMenuItem2_Click);
            // 
            // sumárioToolStripMenuItem1
            // 
            this.sumárioToolStripMenuItem1.Name = "sumárioToolStripMenuItem1";
            this.sumárioToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.sumárioToolStripMenuItem1.Text = "Sumário";
            this.sumárioToolStripMenuItem1.Click += new System.EventHandler(this.sumárioToolStripMenuItem1_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudanteTurmaToolStripMenuItem,
            this.professorTurmaToolStripMenuItem,
            this.pessoaToolStripMenuItem1,
            this.turmaToolStripMenuItem1,
            this.disciplinaToolStripMenuItem3});
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.removerToolStripMenuItem.Text = "Remover";
            // 
            // estudanteTurmaToolStripMenuItem
            // 
            this.estudanteTurmaToolStripMenuItem.Name = "estudanteTurmaToolStripMenuItem";
            this.estudanteTurmaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.estudanteTurmaToolStripMenuItem.Text = "Estudante - Turma";
            this.estudanteTurmaToolStripMenuItem.Click += new System.EventHandler(this.estudanteTurmaToolStripMenuItem_Click);
            // 
            // pessoaToolStripMenuItem1
            // 
            this.pessoaToolStripMenuItem1.Name = "pessoaToolStripMenuItem1";
            this.pessoaToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.pessoaToolStripMenuItem1.Text = "Pessoa";
            this.pessoaToolStripMenuItem1.Click += new System.EventHandler(this.pessoaToolStripMenuItem1_Click);
            // 
            // turmaToolStripMenuItem1
            // 
            this.turmaToolStripMenuItem1.Name = "turmaToolStripMenuItem1";
            this.turmaToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.turmaToolStripMenuItem1.Text = "Turma";
            this.turmaToolStripMenuItem1.Click += new System.EventHandler(this.turmaToolStripMenuItem1_Click);
            // 
            // disciplinaToolStripMenuItem3
            // 
            this.disciplinaToolStripMenuItem3.Name = "disciplinaToolStripMenuItem3";
            this.disciplinaToolStripMenuItem3.Size = new System.Drawing.Size(172, 22);
            this.disciplinaToolStripMenuItem3.Text = "Disciplina";
            this.disciplinaToolStripMenuItem3.Click += new System.EventHandler(this.disciplinaToolStripMenuItem3_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxDisciplinas);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxTurmas);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.labelProfDisciplinaBI);
            this.splitContainer1.Panel2.Controls.Add(this.labelProfDisciplina);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.panelInfo);
            this.splitContainer1.Panel2.Controls.Add(this.labelDelegado);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.labelDirector);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewAlunos);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(812, 596);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Disciplinas";
            // 
            // listBoxDisciplinas
            // 
            this.listBoxDisciplinas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDisciplinas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDisciplinas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listBoxDisciplinas.FormattingEnabled = true;
            this.listBoxDisciplinas.ItemHeight = 20;
            this.listBoxDisciplinas.Location = new System.Drawing.Point(3, 292);
            this.listBoxDisciplinas.Name = "listBoxDisciplinas";
            this.listBoxDisciplinas.Size = new System.Drawing.Size(126, 304);
            this.listBoxDisciplinas.TabIndex = 2;
            this.listBoxDisciplinas.SelectedIndexChanged += new System.EventHandler(this.listBoxDisciplinas_SelectedIndexChanged);
            // 
            // listBoxTurmas
            // 
            this.listBoxTurmas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTurmas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTurmas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listBoxTurmas.FormattingEnabled = true;
            this.listBoxTurmas.ItemHeight = 20;
            this.listBoxTurmas.Location = new System.Drawing.Point(3, 22);
            this.listBoxTurmas.Name = "listBoxTurmas";
            this.listBoxTurmas.Size = new System.Drawing.Size(126, 244);
            this.listBoxTurmas.TabIndex = 1;
            this.listBoxTurmas.SelectedIndexChanged += new System.EventHandler(this.listBoxTurmas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turmas";
            // 
            // labelProfDisciplinaBI
            // 
            this.labelProfDisciplinaBI.AutoSize = true;
            this.labelProfDisciplinaBI.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfDisciplinaBI.Location = new System.Drawing.Point(250, 43);
            this.labelProfDisciplinaBI.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.labelProfDisciplinaBI.Name = "labelProfDisciplinaBI";
            this.labelProfDisciplinaBI.Size = new System.Drawing.Size(104, 17);
            this.labelProfDisciplinaBI.TabIndex = 15;
            this.labelProfDisciplinaBI.Text = "ProfDisciplinaBI";
            // 
            // labelProfDisciplina
            // 
            this.labelProfDisciplina.AutoSize = true;
            this.labelProfDisciplina.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfDisciplina.Location = new System.Drawing.Point(152, 43);
            this.labelProfDisciplina.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.labelProfDisciplina.Name = "labelProfDisciplina";
            this.labelProfDisciplina.Size = new System.Drawing.Size(92, 17);
            this.labelProfDisciplina.TabIndex = 14;
            this.labelProfDisciplina.Text = "ProfDisciplina";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Professor da Disciplina:";
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BackColor = System.Drawing.SystemColors.Window;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInfo.Controls.Add(this.label9);
            this.panelInfo.Controls.Add(this.labelENC_EMAIL);
            this.panelInfo.Controls.Add(this.labelTELF_ENC);
            this.panelInfo.Controls.Add(this.label7);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.labelDATANasc);
            this.panelInfo.Controls.Add(this.labelENC_EDU);
            this.panelInfo.Controls.Add(this.label14);
            this.panelInfo.Controls.Add(this.label11);
            this.panelInfo.Controls.Add(this.labelEMAIL);
            this.panelInfo.Controls.Add(this.labelInfoAluno);
            this.panelInfo.Controls.Add(this.label8);
            this.panelInfo.Controls.Add(this.labelMORADA);
            this.panelInfo.Location = new System.Drawing.Point(3, 466);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(673, 131);
            this.panelInfo.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Email:";
            // 
            // labelENC_EMAIL
            // 
            this.labelENC_EMAIL.AutoSize = true;
            this.labelENC_EMAIL.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelENC_EMAIL.Location = new System.Drawing.Point(66, 107);
            this.labelENC_EMAIL.Name = "labelENC_EMAIL";
            this.labelENC_EMAIL.Size = new System.Drawing.Size(58, 17);
            this.labelENC_EMAIL.TabIndex = 23;
            this.labelENC_EMAIL.Text = "Director";
            // 
            // labelTELF_ENC
            // 
            this.labelTELF_ENC.AutoSize = true;
            this.labelTELF_ENC.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTELF_ENC.Location = new System.Drawing.Point(84, 89);
            this.labelTELF_ENC.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.labelTELF_ENC.Name = "labelTELF_ENC";
            this.labelTELF_ENC.Size = new System.Drawing.Size(66, 17);
            this.labelTELF_ENC.TabIndex = 21;
            this.labelTELF_ENC.Text = "Delegado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Data Nascimento:";
            // 
            // labelDATANasc
            // 
            this.labelDATANasc.AutoSize = true;
            this.labelDATANasc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDATANasc.Location = new System.Drawing.Point(128, 19);
            this.labelDATANasc.Name = "labelDATANasc";
            this.labelDATANasc.Size = new System.Drawing.Size(58, 17);
            this.labelDATANasc.TabIndex = 19;
            this.labelDATANasc.Text = "Director";
            // 
            // labelENC_EDU
            // 
            this.labelENC_EDU.AutoSize = true;
            this.labelENC_EDU.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelENC_EDU.Location = new System.Drawing.Point(147, 71);
            this.labelENC_EDU.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.labelENC_EDU.Name = "labelENC_EDU";
            this.labelENC_EDU.Size = new System.Drawing.Size(66, 17);
            this.labelENC_EDU.TabIndex = 17;
            this.labelENC_EDU.Text = "Delegado";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Encarregado de Edu.:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Email:";
            // 
            // labelEMAIL
            // 
            this.labelEMAIL.AutoSize = true;
            this.labelEMAIL.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEMAIL.Location = new System.Drawing.Point(44, 53);
            this.labelEMAIL.Name = "labelEMAIL";
            this.labelEMAIL.Size = new System.Drawing.Size(58, 17);
            this.labelEMAIL.TabIndex = 15;
            this.labelEMAIL.Text = "Director";
            // 
            // labelInfoAluno
            // 
            this.labelInfoAluno.AutoSize = true;
            this.labelInfoAluno.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoAluno.Location = new System.Drawing.Point(3, 0);
            this.labelInfoAluno.Name = "labelInfoAluno";
            this.labelInfoAluno.Size = new System.Drawing.Size(89, 19);
            this.labelInfoAluno.TabIndex = 7;
            this.labelInfoAluno.Text = "Info Aluno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Morada:";
            // 
            // labelMORADA
            // 
            this.labelMORADA.AutoSize = true;
            this.labelMORADA.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMORADA.Location = new System.Drawing.Point(66, 36);
            this.labelMORADA.Name = "labelMORADA";
            this.labelMORADA.Size = new System.Drawing.Size(58, 17);
            this.labelMORADA.TabIndex = 9;
            this.labelMORADA.Text = "Director";
            // 
            // labelDelegado
            // 
            this.labelDelegado.AutoSize = true;
            this.labelDelegado.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelegado.Location = new System.Drawing.Point(133, 19);
            this.labelDelegado.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.labelDelegado.Name = "labelDelegado";
            this.labelDelegado.Size = new System.Drawing.Size(66, 17);
            this.labelDelegado.TabIndex = 6;
            this.labelDelegado.Text = "Delegado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Delegado de Turma:";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirector.Location = new System.Drawing.Point(133, 2);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(58, 17);
            this.labelDirector.TabIndex = 4;
            this.labelDirector.Text = "Director";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Director de Turma:";
            // 
            // dataGridViewAlunos
            // 
            this.dataGridViewAlunos.AllowUserToAddRows = false;
            this.dataGridViewAlunos.AllowUserToDeleteRows = false;
            this.dataGridViewAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlunos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAlunos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlunos.Location = new System.Drawing.Point(4, 89);
            this.dataGridViewAlunos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.dataGridViewAlunos.Name = "dataGridViewAlunos";
            this.dataGridViewAlunos.ReadOnly = true;
            this.dataGridViewAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlunos.Size = new System.Drawing.Size(673, 381);
            this.dataGridViewAlunos.TabIndex = 2;
            this.dataGridViewAlunos.SelectionChanged += new System.EventHandler(this.dataGridViewAlunos_SelectionChanged);
            this.dataGridViewAlunos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewAlunos_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alunos";
            // 
            // professorTurmaToolStripMenuItem
            // 
            this.professorTurmaToolStripMenuItem.Name = "professorTurmaToolStripMenuItem";
            this.professorTurmaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.professorTurmaToolStripMenuItem.Text = "Professor - Turma";
            this.professorTurmaToolStripMenuItem.Click += new System.EventHandler(this.professorTurmaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 620);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestão Escolar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAlunos;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem criarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profturToolStripMenuItem1;
        private System.Windows.Forms.ListBox listBoxTurmas;
        private System.Windows.Forms.Label labelDelegado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelInfoAluno;
        private System.Windows.Forms.Label labelMORADA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelEMAIL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDATANasc;
        private System.Windows.Forms.Label labelENC_EDU;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelTELF_ENC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelENC_EMAIL;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxDisciplinas;
        private System.Windows.Forms.Label labelProfDisciplina;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelProfDisciplinaBI;
        private System.Windows.Forms.ToolStripMenuItem disciplinaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem disciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disciplinaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem estudanteTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorTurmaToolStripMenuItem;
    }
}

