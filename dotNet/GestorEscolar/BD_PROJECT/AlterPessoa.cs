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
    public partial class AlterPessoa : Form {

        string strConn = Form1.strConn;
        private Form1 ParentForm;
        Dictionary<Int32, string> pessoas;
        public AlterPessoa(Form1 form)
        {
            InitializeComponent();
            ParentForm = form;
        }

        private void fillComboBox(string table)
        {
            comboBox2.DataSource = null;
            comboBox2.Items.Clear();
            pessoas = new Dictionary<Int32, string>();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 0 - Professor
            // 1 - Estudante
            // 2 - Enc. Educação
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    fillComboBox("PROFESSOR");
                    dateTimePickerNascimento.Enabled = false;
                    textBoxBIEncEducacao.Enabled = false;
                    textBoxTelefone.Enabled = true;
                    break;
                case 1:
                    fillComboBox("ESTUDANTE");
                    dateTimePickerNascimento.Enabled = true;
                    textBoxBIEncEducacao.Enabled = true;
                    textBoxTelefone.Enabled = false;
                    break;
                case 2:
                    fillComboBox("ENC_EDUCACAO");
                    dateTimePickerNascimento.Enabled = false;
                    textBoxBIEncEducacao.Enabled = false;
                    textBoxTelefone.Enabled = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    query = alterarProfessor();
                    break;
                case 1:
                    query = alterarEstudante();
                    break;
                case 2:
                    query = alterarEncEducacao();
                    break;
            }
            
            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                myConnection.Open();
                
                using (SqlCommand cmd = myConnection.CreateCommand())
                {
                    cmd.CommandText = query;
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string alterarProfessor () 
        {
            return "EXEC AlterarProfessor "
                + ((KeyValuePair<Int32, string>)comboBox2.SelectedItem).Key + ", '"
                + textBoxNIF.Text.ToString() + "', '"
                + textBoxNome.Text.ToString() + "', '"
                + textBoxEmail.Text.ToString() + "', '"
                + textBoxMorada.Text.ToString() + "', '"
                + textBoxTelefone.Text.ToString() +"';";
        }
        
        private string alterarEncEducacao () 
        {
            return "EXEC AlterarEncarregado "
                + ((KeyValuePair<Int32, string>)comboBox2.SelectedItem).Key + ", '"
                + textBoxNIF.Text.ToString() + "', '"
                + textBoxNome.Text.ToString() + "', '"
                + textBoxEmail.Text.ToString() + "', '"
                + textBoxMorada.Text.ToString() + "', '"
                + textBoxTelefone.Text.ToString() +"';";
        }
        
        private string alterarEstudante () 
        {
            return "EXEC AlterarEstudante "
                + ((KeyValuePair<Int32, string>)comboBox2.SelectedItem).Key + ", '"
                + textBoxNIF.Text.ToString() + "', '"
                + textBoxNome.Text.ToString() + "', '"
                + textBoxEmail.Text.ToString() + "', '"
                + textBoxMorada.Text.ToString() + "', '"
                + dateTimePickerNascimento.Value.Date + "', '"
                + textBoxBIEncEducacao.Text.ToString() + "';";
        }
    }
}
