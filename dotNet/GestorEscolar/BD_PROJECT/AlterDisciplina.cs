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
    public partial class AlterDisciplina : Form {

        string strConn = Form1.strConn;
        private Form1 ParentForm;
        public AlterDisciplina(Form1 form)
        {
            InitializeComponent();
            ParentForm = form;
            fillComboBox();
        }

        private void fillComboBox()
        {
            comboBox2.Items.Clear();
            Dictionary<Int32, string> disci = new Dictionary<Int32, string>();
            disci.Clear();
            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                string query = "select * from DISCIPLINA;";
                myConnection.Open();
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            disci.Add((Int32)reader["idDisciplina"], (string)reader["Nome"]);
                        }
                    }
                }
                comboBox1.Items.Clear();
                query = "select * from ANO_ESCOLAR;";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add((Int32)reader["Num"]);
                        }
                    }
                }
                myConnection.Close();
            }

            comboBox2.DataSource = new BindingSource(disci, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";

            // ultimo elemento
            comboBox1.Items.Add("Outro...");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= comboBox1.Items.Count - 1)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 disc = ((KeyValuePair<Int32, string>)comboBox2.SelectedItem).Key;
            String ano = "";
            if (comboBox1.SelectedIndex >= comboBox1.Items.Count - 1)
            {
                ano = textBox1.Text.ToString();
            }
            else
            {
                ano += (Int32)comboBox1.SelectedItem;
            }

            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                myConnection.Open();

                using (SqlCommand cmd = myConnection.CreateCommand())
                {
                    cmd.CommandText = "EXEC AlterarDisciplina "+disc+ ", '" + textBoxNome.Text.ToString() + "', " + ano + ";";
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
