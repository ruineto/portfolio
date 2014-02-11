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
    public partial class InsertEstudanteTurma : Form
    {
        string strConn = Form1.strConn;
        private Form1 ParentForm;
        public InsertEstudanteTurma(Form1 form)
        {
            InitializeComponent();
            ParentForm = form;
            fillComboBoxs();
        }

        private void fillComboBoxs()
        {
            Dictionary<Int32, string> turmas = new Dictionary<Int32, string>();
            Dictionary<Int32, string> alunos = new Dictionary<Int32, string>();
            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                string query = "select * from TURMA;";
                myConnection.Open();
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            turmas.Add((Int32)reader["idTurma"], (string)reader["Nome"]);
                        }
                    }
                }
                query = "select Nome, BI, Nif, DataNascimento as 'Data Nascimento', Email, Morada from GET_ALUNOS where Turma='" + 'A' + "';";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            alunos.Add((Int32)reader["BI"], (string)reader["Nome"]);
                        }
                    }
                }


                comboBoxTurmas.DataSource = new BindingSource(turmas, null);
                comboBoxTurmas.DisplayMember = "Value";
                comboBoxTurmas.ValueMember = "Key";

                try
                {
                    comboBoxAlunos.DataSource = new BindingSource(alunos, null);
                    comboBoxAlunos.DisplayMember = "Value";
                    comboBoxAlunos.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não existem alunos nesta turma!");
                    button1.Enabled = false;
                }

                myConnection.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get combobox selection (in handler)
            Int32 idTurma = ((KeyValuePair<Int32, string>)comboBoxTurmas.SelectedItem).Key;
            Int32 idAluno = ((KeyValuePair<Int32, string>)comboBoxAlunos.SelectedItem).Key;

            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                myConnection.Open();

                using (SqlCommand cmd = myConnection.CreateCommand())
                {
                    cmd.CommandText = "EXEC InserirEstudanteTurma " + idAluno + ", " + idTurma + ";";
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                myConnection.Close();
            }
            ParentForm.updateData();
            this.Close();
        }
    }
}
