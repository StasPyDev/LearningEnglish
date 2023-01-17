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
    public partial class sign_up : Form
    {
        DataBase dataBase = new DataBase();

        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            textBox_Password2.PasswordChar = '*';
            textBox_Login2.MaxLength = 50;
            textBox_Password2.MaxLength = 50;
        }

        private void btn_Registration_Click(object sender, EventArgs e)
        {
            var login = textBox_Login2.Text;
            var password = textBox_Password2.Text;

            bool reg = checkUser();

            if (reg == false)
            {
                string queryString = $"INSERT INTO Registration(login_user, password_user) VALUES ('{login}', '{password}')";

                SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

                dataBase.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Реєстрація пройшла успішно", "Зареєструвалися!");
                    log_in lgn = new log_in();
                    this.Hide();
                    lgn.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Акаунт не створено!");
            }
            dataBase.closeConnection();
        }

        private Boolean checkUser()
        {
            var loginUser = textBox_Login2.Text;
            var passwordUser = textBox_Password2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"SELECT id_user, login_user, password_user FROM Registration WHERE login_user='{loginUser}' and password_user='{passwordUser}'";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такий акаунт вже існує!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            log_in lgn = new log_in();
            this.Hide();
            lgn.ShowDialog();
        }
    }
}
