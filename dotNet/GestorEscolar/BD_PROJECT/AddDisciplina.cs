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
    public partial class AddDisciplina : Form {

        string strConn = Form1.strConn;
        private Form1 ParentForm;
        public AddDisciplina(Form1 form)
        {
            InitializeComponent();
            ParentForm = form;
            fillComboBox();
        }

        private void fillComboBox()
        {
            comboBox1.Items.Clear();
            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                string query = "select * from ANO_ESCOLAR;";
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    myConnection.Open();
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
            // ultimo elemento
            comboBox1.Items.Add("Outro...");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= comboBox1.Items.Count - 1)
            {
                textBoxNovo.Enabled = true;
            }
            else
            {
                textBoxNovo.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ano = "";
            if (comboBox1.SelectedIndex >= comboBox1.Items.Count - 1)
            {
                ano = textBoxNovo.Text.ToString();
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
                    cmd.CommandText = "EXEC CriarDisciplina '"+textBoxNome.Text.ToString()+"', "+ ano + ";";
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
