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
    public partial class DeleteDisciplina : Form
    {
        string strConn = Form1.strConn;
        private Form1 ParentForm;
        public DeleteDisciplina(Form1 form)
        {
            InitializeComponent();
            ParentForm = form;
            fillComboBoxs();
        }

        private void fillComboBoxs()
        {
            Dictionary<Int32, string> disc = new Dictionary<Int32, string>();
            comboBoxTurmas.Items.Clear();
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
                            disc.Add((Int32)reader["idDisciplina"], (string)reader["Nome"]);
                        }
                    }
                }

                try
                {
                    comboBoxTurmas.DataSource = new BindingSource(disc, null);
                    comboBoxTurmas.DisplayMember = "Value";
                    comboBoxTurmas.ValueMember = "Key";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Não existem disciplinas!");
                    button1.Enabled = false;
                }

                myConnection.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 idTurma = ((KeyValuePair<Int32, string>)comboBoxTurmas.SelectedItem).Key;

            using (SqlConnection myConnection = new SqlConnection(strConn))
            {
                myConnection.Open();

                using (SqlCommand cmd = myConnection.CreateCommand())
                {
                    cmd.CommandText = "EXEC ApagarDisciplina " + idTurma + ";";
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
