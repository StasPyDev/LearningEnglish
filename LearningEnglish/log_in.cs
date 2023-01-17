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

namespace LearningEnglish
{
    public partial class log_in : Form
    {
        DataBase dataBase = new DataBase();

        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            textBox_Password.PasswordChar = '*';
            textBox_Login.MaxLength= 50;
            textBox_Password.MaxLength= 50;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_Login.Text;
            var passUser = textBox_Password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"SELECT id_user, login_user, password_user FROM Registration WHERE login_user='{loginUser}' and password_user='{passUser}'";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Ви авторизувалися!", "Увійшли!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 frm = new Form1();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Такого акаунту не існує!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel_NewReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up signUp = new sign_up();
            this.Hide();
            signUp.ShowDialog();
        }
    }
}
