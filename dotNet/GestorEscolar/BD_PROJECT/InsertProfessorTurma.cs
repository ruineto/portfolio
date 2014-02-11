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
    public partial class InsertProfessorTurma : Form
    {
        string strConn = Form1.strConn;
        private Form1 ParentForm;
        public InsertProfessorTurma(Form1 form)
        {
            InitializeComponent();
            ParentForm = form;
            fillComboBoxs();
        }

        private void fillComboBoxs()
        {
            Dictionary<Int32, string> turmas = new Dictionary<Int32, string>();
            Dictionary<Int32, string> profs = new Dictionary<Int32, string>();
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

                query = "select * from GET_PROFESSOR_WITH_TURMAS where refTurma=1";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                profs.Add((Int32)reader["BI"], (string)reader["Nome"] + " - " + (Int32)reader["BI"]);
                            }
                            catch (ArgumentException arg) { }
                        }
                    }
                }

                query = "select distinct Disciplina from GET_DISCIPLINAS where idTurma=1;";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                comboBox1.Items.Add((string)reader["Disciplina"] + "**");
                            }
                            catch (ArgumentException arg) { }
                        }
                    }
                }

                comboBoxTurmas.DataSource = new BindingSource(turmas, null);
                comboBoxTurmas.DisplayMember = "Value";
                comboBoxTurmas.ValueMember = "Key";

                try
                {
                    comboBoxProfs.DataSource = new BindingSource(profs, null);
                    comboBoxProfs.DisplayMember = "Value";
                    comboBoxProfs.ValueMember = "Key";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Não existem professores nessa turma!");
                    button1.Enabled = false;
                }
                myConnection.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get combobox selection (in handler)
            Int32 turma = ((KeyValuePair<Int32, string>)comboBoxTurmas.SelectedItem).Key;
            Int32 prof = ((KeyValuePair<Int32, string>)comboBoxProfs.SelectedItem).Key;
            string disc = (string)comboBox1.SelectedItem;

            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                myConnection.Open();

                using (SqlCommand cmd = myConnection.CreateCommand())
                {
                    cmd.CommandText = "EXEC InserirProfessorTurma " + prof + ", " + turma + ", '"+disc+"';";
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
