using Demo_template.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Demo_template
{
    public partial class Login : Form
    {
        string role; // хранение роли
        public Login() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            string login = Login_Entry.Text;
            string password = Password_Entry.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поля не должны быть пустыми!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //открытие соединения для работы с БД
            using (MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=root;database=mydb"))
            {                
                connection.Open();

                //Выполнение команды SELECT (чтение)
                MySqlCommand verificationCommand = new MySqlCommand($"SELECT Password, Captcha_attempts, Role FROM mydb.users WHERE Login = '{login}';", connection);
                // Получение данных из БД
                MySqlDataReader reader = verificationCommand.ExecuteReader();

                if (reader.Read()) // проверка на совпадение логинов
                {
                    int attempts = reader.GetInt32("Captcha_attempts"); // парсинг строки "Попытки"
                    role = reader.GetString("Role");

                    if (attempts <= 0) // проверка на блокировку
                    {
                        MessageBox.Show("Вы заблокированы! Обратитесь к администратору.", "Превышено количество попыток!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (reader.GetString("Password") == password) // Если пароли совпали                    
                        Authorize(attempts, login, role);
                    else 
                    {
                        reader.Close();
                        FailAuthorize(attempts, login, connection);
                    }
                }
                else
                    MessageBox.Show("Пользователя не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string SendRole() => role; // метод для передачи роли в главную форму        

        private void FailAuthorize(int attempts, string login, MySqlConnection connection)
        {
            //Выполнение команды UPDATE
            using (var updateCommand = new MySqlCommand($"UPDATE mydb.users SET Captcha_attempts = Captcha_attempts - 1 WHERE Login = '{login}';", connection))
                updateCommand.ExecuteNonQuery();

            MessageBox.Show($"Вы ввели неверный логин или пароль. Пожалуйста проверьте ещё раз введенные данные!\nОсталось попыток: {attempts-1}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Authorize(int attempts, string login, string role) 
        {            
            MessageBox.Show("Вы успешно авторизовались!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (role == "Admin") // обход каптчи для админов
            {
                DialogResult = DialogResult.OK;
                return;
            }

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