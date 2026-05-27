using Demo_template.Forms;
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

                    int attempts = 3; // парсинг строки "Попытки"
                    role = "Admin";

                    if (attempts <= 0) // проверка на блокировку
                    {
                        MessageBox.Show("Вы заблокированы! Обратитесь к администратору.", "Превышено количество попыток!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (true)
                        Authorize(attempts, login, role);
                    else                     
                        FailAuthorize(attempts, login);                    
            }

            else
                MessageBox.Show("Пользователя не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public string SendRole() => role; // метод для передачи роли в главную форму        

        private void FailAuthorize(int attempts, string login)
        {
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