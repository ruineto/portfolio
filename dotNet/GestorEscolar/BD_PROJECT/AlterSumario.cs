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
    public partial class AlterSumario : Form {

        string strConn = Form1.strConn;
        private Form1 ParentForm;
        private bool creating = true;
        public AlterSumario(Form1 form)
        {
            InitializeComponent();
            ParentForm = form;
            fillComboBoxs();
            creating = false;
        }

        private void fillComboBoxs()
        {
            Dictionary<Int32, string> turmas = new Dictionary<Int32, string>();
            Dictionary<Int32, string> disc = new Dictionary<Int32, string>();
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
                query = "select * from GET_DISCIPLINAS where Turma='" + 'A' + "';";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            disc.Add((Int32)reader["BI"], (string)reader["Disciplina"]);
                        }
                    }
                }


                comboBox1.DataSource = new BindingSource(turmas, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";

                try
                {
                    comboBox2.DataSource = new BindingSource(disc, null);
                    comboBox2.DisplayMember = "Value";
                    comboBox2.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não existem disciplinas nesta turma!");
                    button1.Enabled = false;
                }

                myConnection.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (creating != true)
            {
                Dictionary<Int32, string> disc = new Dictionary<Int32, string>();
                using (SqlConnection myConnection = new SqlConnection(strConn))
                {
                    string turma = ((KeyValuePair<Int32, string>)comboBox1.SelectedItem).Value;
                    string query = "select * from GET_DISCIPLINAS where Turma='" + turma + "';";
                    myConnection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, myConnection))
                    {

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                disc.Add((Int32)reader["BI"], (string)reader["Disciplina"]);
                            }
                        }
                    }

                    try
                    {
                        comboBox2.DataSource = new BindingSource(disc, null);
                        comboBox2.DisplayMember = "Value";
                        comboBox2.ValueMember = "Key";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não existem disciplinas nesta turma!");
                        button1.Enabled = false;
                    }

                    myConnection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 idTurma = ((KeyValuePair<Int32, string>)comboBox1.SelectedItem).Key;
            string disc = ((KeyValuePair<Int32, string>)comboBox2.SelectedItem).Value;
            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                myConnection.Open();

                using (SqlCommand cmd = myConnection.CreateCommand())
                {
                    cmd.CommandText = "EXEC AlterarSumario '" + disc + "', " + idTurma + ", '" + dateTimePicker.Value.Date + "', '" + textBoxSumario.Text.ToString() + "';";
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
