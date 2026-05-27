using Demo_entity.Database;
using Demo_entity.Models;
using Demo_template.Forms;

namespace Demo_template
{
    public partial class Login : Form
    {
        private MydbContext context;
        string role; // хранение роли
        public Login()
        {
            context = new MydbContext();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Login_Entry.Text) || string.IsNullOrEmpty(Password_Entry.Text))
                    throw new Exception("Поля не должны быть пустыми!");

                User? user = context.Users.FirstOrDefault(u => u.Login == Login_Entry.Text);

                if (user is null)
                    throw new Exception("Пользователя не существует!");
                if (user.CaptchaAttempts <= 0)
                    throw new Exception("Вы заблокированы! обратитесь к администратору!");

                role = user.Role;
                Authorize(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string SendRole() => role; // метод для передачи роли в главную форму        

        private void Authorize(User user)
        {
            if (user.Password == Password_Entry.Text)
            {
                using (var captcha = new Captcha(user, context)) //Открываем Каптчу как диалоговое окно
                {
                    if (captcha.ShowDialog() == DialogResult.OK)
                    {
                        role = captcha.Role;
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Вы успешно авторизовались!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                user.CaptchaAttempts -= 1;
                context.SaveChanges();
                MessageBox.Show($"Неверно введен пароль!\nПопыток осталось: {user.CaptchaAttempts}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            context?.Dispose();
        }
    }
}