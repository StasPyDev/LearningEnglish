using System.Data;
using System.Data.SqlClient;

namespace LearningEnglish
{
    public partial class Form1 : Form
    {

        DataBase dataBase = new DataBase();
        int count = 1;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_StartLerning_Click(object sender, EventArgs e)
        {
            count = 1;
            selectRow(count);
        }

        private void selectRow(int countId)
        {
            string queryString = $"SELECT * FROM EnglishLearning WHERE id = {countId}";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                textBox_ENWord.Text = reader.GetString(1);
            }

            reader.Close();

        }

        private int SelectAllRows()
        {
            int countRows;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = "SELECT * FROM EnglishLearning";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            countRows = table.Rows.Count;

            return countRows;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Audit_Word_Click(object sender, EventArgs e)
        {
            int countRows = SelectAllRows();
            while(count <= countRows)
            {
                bool requestBool = checkWord();
                if (requestBool)
                {
                    count++;
                    selectRow(count);

                    break;
                }
                else
                {
                    break;
                }
            }
        }

        private Boolean checkWord()
        {
            string ENWord = textBox_ENWord.Text;
            string UATranslate = textBox_UATranslate.Text;
            UATranslate = UATranslate.ToLower();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"SELECT * FROM EnglishLearning WHERE EN_word = '{ENWord}' AND UA_translate = '{UATranslate}'";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                textBox_UATranslate.Text = "";
                label_Return.Text = "Вірно!";
                return true;
            }
            else
            {
                label_Return.Text = "Помилка!";
                textBox_UATranslate.Text = "";
                return false;
            }
        }

        // Add new Word to DB

        private void InsertToDB()
        {
            string ENWord = textBox_AddWordEN.Text;
            ENWord= ENWord.ToLower();
            string UAWord = textBox_AddTranslateUA.Text;
            UAWord= UAWord.ToLower();

            string queryString = $"INSERT INTO EnglishLearning(EN_word, UA_translate, WordUnderstanding, StudyWord) VALUES ('{ENWord}', '{UAWord}', 0, 0)";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Add new word");
                textBox_AddWordEN.Text = "";
                textBox_AddTranslateUA.Text = "";
            }
            dataBase.closeConnection();
        }

        private Boolean auditWord()
        {
            string ENWord = textBox_AddWordEN.Text;
            ENWord = ENWord.ToLower();
            string UAWord = textBox_AddTranslateUA.Text;
            UAWord = UAWord.ToLower();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"SELECT * FROM EnglishLearning WHERE EN_word='{ENWord}' AND UA_translate='{UAWord}'";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button_InsertToDB_Click(object sender, EventArgs e)
        {
            bool auditWordToAdd = auditWord();
            if (auditWordToAdd)
            {
                InsertToDB();
            }
            else
            {
                MessageBox.Show("Таке слово вже існує!");
            }
            
        }

    }
}