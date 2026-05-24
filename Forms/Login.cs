using Demo_template.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Demo_template
{
    public partial class Login : Form
    {
        string role;
        public Login() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            string login = Login_Entry.Text;
            string password = Password_Entry.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поля не должны быть пустыми!");
                return;
            }

            //открытие соединения для работы с БД
            using (MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=root;database=mydb"))
            {                
                connection.Open();

                //Выполнение команды SELECT (чтение)
                MySqlCommand verificationCommand = new MySqlCommand($"SELECT Password, Captcha_attempts, Role FROM mydb.users WHERE Login = '{login}';", connection);
                MySqlDataReader reader = verificationCommand.ExecuteReader();

                if (reader.Read()) // проверка на совпадение логинов
                {
                    int attempts = reader.GetInt32("Captcha_attempts"); // парсинг строки "Попытки"
                     role = reader.GetString("Role");

                    if (reader.GetString("Password") == password) // Если пароли совпали                    
                        Authorize(attempts, login, role);
                    else 
                    {
                        reader.Close();
                        FailAuthorize(attempts, login, connection);
                    }
                }
                else
                    MessageBox.Show("Пользователя не существует!");
            }
        }

        public string SendRole() => role;        

        private void FailAuthorize(int attempts, string login, MySqlConnection connection)
        {
            //Выполнение команды UPDATE
            using (var updateCommand = new MySqlCommand($"UPDATE mydb.users SET Captcha_attempts = Captcha_attempts - 1 WHERE Login = '{login}';", connection))
                updateCommand.ExecuteNonQuery();
            MessageBox.Show($"Введен неверный пароль! Осталось попыток: {attempts - 1}");
        }

        private void Authorize(int attempts, string login, string role) 
        {
            if (attempts <= 0) // проверка на блокировку
            {
                MessageBox.Show("Вы заблокированы! Обратитесь к администратору");
                return;
            }
            
            MessageBox.Show("Вход совершен успешно!");

            using (var captcha = new Captcha(login, attempts)) //Открываем Каптчу как диалоговое окно
            {
                if (captcha.ShowDialog() == DialogResult.OK) 
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }

    }
}