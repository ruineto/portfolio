using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace BD_PROJECT
{
    public partial class Form1 : Form
    {
        public const string strConn = @"Server=tcp:193.136.175.33\SQLSERVER2012,8293; user id=p5g4; Password=bdp5g4;  Database=p5g4;";
        public Form1()
        {
            InitializeComponent();
            updateData();
            labelProfDisciplina.Visible = false;
            listBoxTurmas.SelectedIndex = 0;
            listBoxDisciplinas.SelectedIndex = 0;
        }

        public void updateData()
        {
            fillListBoxTurmas();
            fillListBoxDisciplinas((string)listBoxTurmas.SelectedItem);
            fillTableAlunos((string)listBoxTurmas.SelectedItem);
        }

        private void fillListBoxTurmas()
        {
            listBoxTurmas.Items.Clear();
            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                string query = "SELECT Nome FROM TURMA ORDER BY Nome;";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    myConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBoxTurmas.Items.Add((string)reader["Nome"]);
                        }
                    }
                }
                myConnection.Close();
            }
            listBoxTurmas.SelectedIndex = 0;
        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Gestor Escolar",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
       {
               panelInfo.Location = new Point(3, dataGridViewAlunos.Bottom);
       }

        private void listBoxTurmas_SelectedIndexChanged(object sender, EventArgs e)
        {
            String str = (string)((ListBox)sender).SelectedItem;
            labelProfDisciplina.Visible = false;
            labelProfDisciplinaBI.Visible = false;
            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                string query = "select * from GET_TURMA_INFO where Turma='" + str + "';";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    myConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            labelDirector.Text = (string)reader["Director"];
                            labelDelegado.Text = (string)reader["Delegado"];  
                        }
                    }
                }
                myConnection.Close();
            }
            fillTableAlunos(str);
            fillListBoxDisciplinas(str);
        }

        private void fillListBoxDisciplinas(string str)
        {
            listBoxDisciplinas.Items.Clear();
            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                myConnection.Open();
                String query = "select * from GET_DISCIPLINAS where Turma='" + str + "' order by Disciplina;";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBoxDisciplinas.Items.Add((string)reader["Disciplina"]);
                        }
                    }
                }
                myConnection.Close();
            }
            listBoxDisciplinas.SelectedIndex = 0;
        }

        private void fillTableAlunos(String turma)
        {
            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                myConnection.Open();
                String query2 = "select Nome, BI, Nif, DataNascimento as 'Data Nascimento', Email, Morada from GET_ALUNOS where Turma='" + turma + "';";
                SqlDataAdapter dAdapter = new SqlDataAdapter(query2, myConnection);
                SqlCommandBuilder cBuilder = new SqlCommandBuilder(dAdapter);

                DataTable dTable = new DataTable();
                dAdapter.Fill(dTable);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = dTable;

                dataGridViewAlunos.DataSource = bSource;
                dataGridViewAlunos.EndEdit();
                bSource.EndEdit();
                myConnection.Close();
            }
        }

        private void dataGridViewAlunos_SelectionChanged (object sender, EventArgs e)
        {
            string bi = (dataGridViewAlunos.CurrentRow).Cells[1].Value.ToString();
            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                string query = "select * from GET_INFO_ALUNO where BI='" + bi + "';";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    myConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            labelDATANasc.Text = ((DateTime)reader["DataNascimento"]).ToShortDateString();
                            labelMORADA.Text = (string)reader["Morada"];
                            labelEMAIL.Text = (string)reader["Email"];
                            labelENC_EDU.Text = (string)reader["Enc_educacao"];
                            labelTELF_ENC.Text = reader["Telemovel"].ToString();
                            labelENC_EMAIL.Text = (string)reader["Enc_Email"];
                        }
                    }
                }
                myConnection.Close();
            }
        }


        private void dataGridViewAlunos_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Ver"));
                m.MenuItems.Add(new MenuItem("Copiar"));

                /*int currentMouseOverRow = dataGridViewAlunos.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                }*/

                m.Show(dataGridViewAlunos, new Point(e.X, e.Y));

            }
        }

        private void listBoxDisciplinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string disciplina = (string)listBoxDisciplinas.SelectedItem;
            string turma = (string)listBoxTurmas.SelectedItem;
            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                myConnection.Open();
                String query = "select * from GET_DISCIPLINAS where Turma='" + turma + "' and Disciplina='"+disciplina+"';";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            labelProfDisciplina.Text = (string)reader["Professor"];
                            labelProfDisciplina.Visible = true;
                            labelProfDisciplinaBI.Text = reader["BI"].ToString();
                            labelProfDisciplinaBI.Visible = true;
                        }
                    }
                }
                myConnection.Close();
            }
        }
        
        /* CRIAR */
        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddPessoa(this).Show();
        }

        private void turmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddTurma(this).Show();
        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddDisciplina(this).Show();
        }

        private void sumárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddSumario(this).Show();
        }

        /* INSERIR */
        private void estturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertEstudanteTurma(this).Show();
        }

        private void profturToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new InsertProfessorTurma(this).Show();
        }

        /* ALTERAR */

        private void pessoaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new AlterPessoa(this).Show();
        }

        private void turmaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new AlterTurma(this).Show();
        }

        private void disciplinaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new AlterDisciplina(this).Show();
        }

        private void sumárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AlterSumario(this).Show();
        }

        /* REMOVER */

        private void estudanteTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RemoveEstudanteTurma(this).Show();
        }

        private void professorTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RemoveProfessorTurma(this).Show();
        }

        private void pessoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new DeletePessoa(this).Show();
        }

        private void turmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new DeleteTurma(this).Show();
        }  
        
        private void disciplinaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new DeleteDisciplina(this).Show();
        }

        
    }
}
