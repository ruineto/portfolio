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
using System.Text.RegularExpressions;

namespace BD_PROJECT
{
    public partial class AlterTurma : Form
    {
        string strConn = Form1.strConn;
        private Form1 ParentForm;
        public AlterTurma(Form1 form)
        {
            InitializeComponent();
            fillComboBoxs();
            ParentForm = form;
        }

        private void fillComboBoxs()
        {
            Dictionary<Int32, string> turmas = new Dictionary<Int32, string>();
            Dictionary<Int32, string> profs = new Dictionary<Int32, string>();
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
                query = "select * from GET_PROFESSOR_WITH_TURMAS where refTurma=" + 1 + ";";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            profs.Add((Int32)reader["BI"], (string)reader["Nome"] + " #" + (Int32)reader["BI"]);
                        }
                    }
                }

                query = "select * from GET_ALUNOS where Turma='" + 'A' + "';";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            alunos.Add((Int32)reader["BI"], (string)reader["Nome"] + " #" + (Int32)reader["BI"]);
                        }
                    }
                }

                comboBox1.DataSource = new BindingSource(turmas, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";

                try
                {
                    comboBoxDirector.DataSource = new BindingSource(profs, null);
                    comboBoxDirector.DisplayMember = "Value";
                    comboBoxDirector.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não existem professores nesta turma!");
                    button1.Enabled = false;
                }

                try
                {
                    comboBoxDelegado.DataSource = new BindingSource(alunos, null);
                    comboBoxDelegado.DisplayMember = "Value";
                    comboBoxDelegado.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não existem alunos nesta turma!");
                    button1.Enabled = false;
                }

                // fill Ano Lectivo
                string str;

                query = "select * from ANO_LECTIVO;";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            str = (Int32)reader["AnoInicio"] + " - " + (Int32)reader["AnoFim"];
                            comboBoxAnoLectivo.Items.Add(str);
                        }
                    }
                }
                // ultimo elemento
                comboBoxAnoLectivo.Items.Add("Outro...");

                myConnection.Close();
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Int32 turma = ((KeyValuePair<Int32, string>)comboBox1.SelectedItem).Key;
            string nome = textBoxNome.Text;
            Int32 director = ((KeyValuePair<Int32, string>)comboBoxDirector.SelectedItem).Key;
            Int32 delegado = ((KeyValuePair<Int32, string>)comboBoxDelegado.SelectedItem).Key;
            string max = numericUpDownMaxAlunos.Value.ToString();

            string inicio, fim;
            if (comboBoxAnoLectivo.SelectedIndex >= comboBoxAnoLectivo.Items.Count - 1)
            {
                inicio = textBoxAnoInicio.Text;
                fim = textBoxAnoFim.Text;
            }
            else
            {
                string ano;
                try
                {

                    ano = ((string)comboBoxAnoLectivo.SelectedItem.ToString());
                }
                catch (NullReferenceException en)
                {
                    ano = " - ";
                }
                string[] outs = Regex.Split(ano, " - ");
                inicio = outs[0];
                fim = outs[1];
            }

            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                myConnection.Open();

                using (SqlCommand cmd = myConnection.CreateCommand())
                {
                    cmd.CommandText = "EXEC AlterarTurma  @idTurma=" + turma + ", @Nome='"
                        + nome + "', @Director="
                        + director + ", @Delegado="
                        + delegado + ", @Max_Alunos="
                        + max + ", @AnoInicio="
                        + inicio + ", @AnoFim="
                        + fim + ";";
                    cmd.ExecuteNonQuery();
                }
                myConnection.Close();
            }
            ParentForm.updateData();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<Int32, string> profs = new Dictionary<Int32, string>();
            Dictionary<Int32, string> alunos = new Dictionary<Int32, string>();
            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                myConnection.Open();

                string query = "select * from GET_PROFESSOR_WITH_TURMAS where refTurma=" + ((KeyValuePair<Int32, string>)comboBox1.SelectedItem).Key + ";";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            profs.Add((Int32)reader["BI"], (string)reader["Nome"] + " #" + (Int32)reader["BI"]);
                        }
                    }
                }

                query = "select * from GET_ALUNOS where Turma='" + ((KeyValuePair<Int32, string>)comboBox1.SelectedItem).Value + "';";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            alunos.Add((Int32)reader["BI"], (string)reader["Nome"] + " #" + (Int32)reader["BI"]);
                        }
                    }
                }

                try
                {
                    comboBoxDirector.DataSource = new BindingSource(profs, null);
                    comboBoxDirector.DisplayMember = "Value";
                    comboBoxDirector.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não existem professores nesta turma!");
                    button1.Enabled = false;
                }

                try
                {
                    comboBoxDelegado.DataSource = new BindingSource(alunos, null);
                    comboBoxDelegado.DisplayMember = "Value";
                    comboBoxDelegado.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não existem alunos nesta turma!");
                    button1.Enabled = false;
                }

                myConnection.Close();
            }
        }

        private void comboBoxAnoLectivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAnoLectivo.SelectedIndex >= comboBoxAnoLectivo.Items.Count - 1)
            {
                textBoxAnoInicio.Enabled = true;
                textBoxAnoFim.Enabled = true;
            }
            else
            {
                textBoxAnoInicio.Enabled = false;
                textBoxAnoFim.Enabled = false;
            }
        }
    }
}
