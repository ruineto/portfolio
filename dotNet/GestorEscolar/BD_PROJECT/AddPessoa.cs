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
    public partial class AddPessoa : Form {

        string strConn = Form1.strConn;
        private Form1 ParentForm;
        public AddPessoa(Form1 form)
        {
            InitializeComponent();
            ParentForm = form;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 0 - Professor
            // 1 - Estudante
            // 2 - Enc. Educação
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dateTimePickerNascimento.Enabled = false;
                    textBoxBIEncEducacao.Enabled = false;
                    textBoxTelefone.Enabled = true;
                    break;
                case 1:
                    dateTimePickerNascimento.Enabled = true;
                    textBoxBIEncEducacao.Enabled = true;
                    textBoxTelefone.Enabled = false;
                    break;
                case 2:
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
                    query = criarProfessor();
                    break;
                case 1:
                    query = criarEstudante();
                    break;
                case 2:
                    query = criarEncEducacao();
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
            this.Close();
        }

        private string criarProfessor () 
        {
            return "EXEC CriarProfessor "
                + textBoxBI.Text.ToString() + ", "
                + textBoxNIF.Text.ToString() + ", '"
                + textBoxNome.Text.ToString() + "', '"
                + textBoxEmail.Text.ToString() + "', '"
                + textBoxMorada.Text.ToString() + "', "
                + textBoxTelefone.Text.ToString() +";";
        }
        
        private string criarEncEducacao () 
        {
            return "EXEC CriarEncarregado "
                + textBoxBI.Text.ToString() + ", "
                + textBoxNIF.Text.ToString() + ", '"
                + textBoxNome.Text.ToString() + "', '"
                + textBoxEmail.Text.ToString() + "', '"
                + textBoxMorada.Text.ToString() + "', "
                + textBoxTelefone.Text.ToString() +";";
        }
        
        private string criarEstudante () 
        {
            return "EXEC CriarEstudante "
                + textBoxBI.Text.ToString() + ", "
                + textBoxNIF.Text.ToString() + ", '"
                + textBoxNome.Text.ToString() + "', '"
                + textBoxEmail.Text.ToString() + "', '"
                + textBoxMorada.Text.ToString() + "', '"
                + dateTimePickerNascimento.Value.Date + "', "
                + textBoxBIEncEducacao.Text.ToString() + ";";
        }
    }
}
