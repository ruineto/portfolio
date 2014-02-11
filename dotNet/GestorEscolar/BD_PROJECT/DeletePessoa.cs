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
    public partial class DeletePessoa : Form
    {
        string strConn = Form1.strConn;
        private Form1 ParentForm;
        public DeletePessoa(Form1 form)
        {
            InitializeComponent();
            ParentForm = form;
        }

        private void fillComboBox(string table)
        {
            // ###################### METER NO PESSOA COMBOBOX "BI - Nome" SE DER ################################
            comboBox2.DataSource = null;
            comboBox2.Items.Clear();
            Dictionary<Int32, string>  pessoas = new Dictionary<Int32, string>();
            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                string query = "select Nome, BI from " + table + " e inner join PESSOA pe on refBI=BI;";
                myConnection.Open();
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pessoas.Add((Int32)reader["BI"], (string)reader["Nome"] + " - " + (Int32)reader["BI"]);
                        }
                    }
                }
                myConnection.Close();
            }

            comboBox2.DataSource = new BindingSource(pessoas, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get combobox selection (in handler)
            Int32 bi = ((KeyValuePair<Int32, string>)comboBox2.SelectedItem).Key;
            string proc ="";
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    proc = "ApagarProfessor";
                    break;
                case 1:
                    proc = "ApagarEstudante";
                    break;
                case 2:
                    proc = "ApagarEncarregado";
                    break;
            }
            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                myConnection.Open();

                using (SqlCommand cmd = myConnection.CreateCommand())
                {
                    cmd.CommandText = "EXEC "+proc+" " + bi + ";";
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

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 0 - Professor
            // 1 - Estudante
            // 2 - Enc. Educação
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    fillComboBox("PROFESSOR");
                    break;
                case 1:
                    fillComboBox("ESTUDANTE");
                    break;
                case 2:
                    fillComboBox("ENC_EDUCACAO");
                    break;
            }
        }
    }
}
