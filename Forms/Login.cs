using Demo_template.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Demo_template
{
    public partial class Login : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=root;database=mydb";

        public Login() => InitializeComponent();     

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Login_Entry.Text) || string.IsNullOrEmpty(Password_Entry.Text))
            {
                MessageBox.Show("Поля не должны быть пустыми!");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string login = Login_Entry.Text;
                string password = Password_Entry.Text;

                connection.Open();
                MySqlCommand verificationCommand = new MySqlCommand($"SELECT Password, Captcha_attempts FROM mydb.users WHERE Login = '{login}';", connection);
                MySqlDataReader reader = verificationCommand.ExecuteReader();

                if (reader.Read())
                {
                    int attempts = reader.GetInt32("Captcha_attempts");

                    if (attempts <= 0)
                    {
                        MessageBox.Show("Вы заблокированы! Обратитесь к администратору");
                        return;
                    }

                    if (reader.GetString("Password") == password)
                    {
                        MessageBox.Show("Вход совершен успешно!");

                        using (var captcha = new Captcha(login, attempts)) 
                        {
                            if (captcha.ShowDialog() == DialogResult.OK)
                                DialogResult = DialogResult.OK;
                            else
                                captcha.Close();
                        }
                        return;
                    }
                    else
                    {
                        reader.Close();
                        using (var updateCommand = new MySqlCommand($"UPDATE mydb.users SET Captcha_attempts = Captcha_attempts - 1 WHERE Login = '{login}';", connection))
                            updateCommand.ExecuteNonQuery();
                        MessageBox.Show($"Введен неверный пароль! Осталось попыток: {attempts - 1}");
                    }
                }
                else
                    MessageBox.Show("Пользователя не существует!");
            }
        }

    }
}