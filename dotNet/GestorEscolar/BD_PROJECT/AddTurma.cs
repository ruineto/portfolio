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
    public partial class AddTurma : Form
    {
        string strConn = Form1.strConn;
        private Form1 ParentForm;
        public AddTurma(Form1 form)
        {
            InitializeComponent();
            fillComboBoxs();
            ParentForm = form;
        }

        private void fillComboBoxs()
        {
            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                string query = "select * from DISCIPLINA;";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    myConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxDisciplinas.Items.Add((string)reader["Nome"]);
                        }
                    }
                }
                myConnection.Close();
            }
            // ultimo elemento
            comboBoxDisciplinas.Items.Add("Outra...");

            // fill Ano Lectivo
            string str;
            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                string query = "select * from ANO_LECTIVO;";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    myConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            str = (Int32)reader["AnoInicio"] + " - " + (Int32)reader["AnoFim"];
                            comboBoxAnoLectivo.Items.Add(str);
                        }
                    }
                }
                myConnection.Close();
            }
            // ultimo elemento
            comboBoxAnoLectivo.Items.Add("Outro...");
        }

        private void comboBoxDisciplinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDisciplinas.SelectedIndex >= comboBoxDisciplinas.Items.Count - 1)
            {
                textBoxDisciplina.Enabled = true;
            }
            else { textBoxDisciplina.Enabled = true; }
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

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string director = textBoxDirector.Text;
            string delegado = textBoxDelegado.Text;
            string max = numericUpDownMaxAlunos.Value.ToString();
            string anoEscolar = (string)comboBoxAnoEscolar.SelectedItem; 

            string disciplina;
            if (comboBoxDisciplinas.SelectedIndex >= comboBoxDisciplinas.Items.Count - 1)
                disciplina = textBoxDisciplina.Text;
            else disciplina = (string)comboBoxDisciplinas.SelectedItem; 

            string inicio, fim;
            if (comboBoxAnoLectivo.SelectedIndex >= comboBoxAnoLectivo.Items.Count - 1)
            {
                inicio = textBoxAnoInicio.Text;
                fim = textBoxAnoFim.Text;
            }
            else
            {
                string[] outs = Regex.Split(((string)comboBoxAnoLectivo.SelectedItem.ToString()), " - ");
                inicio = outs[0];
                fim = outs[1];
            }

            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                myConnection.Open();

                using (SqlCommand cmd = myConnection.CreateCommand())
                {
                    cmd.CommandText = "EXEC CriarTurma '"
                        + nome + "', "
                        + director + ", "
                        + delegado + ", "
                        + max + ", '"
                        + disciplina + "', "
                        + inicio + ", "
                        + fim + ", "
                        + anoEscolar + ";";
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
