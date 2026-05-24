using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Demo_template.Forms
{
    public partial class Captcha : Form
    {
        //строки для хранения логина и пароля
        string login;
        int attemps;

        //список тегов для определения правильной каптчи
        List<string> tags = new List<string>(){"picture_1", "picture_2", "picture_3", "picture_4"};

        // конструктор для передачи данных из формы "Логин" и разрешение на перетаскивание в pictureBox
        public Captcha(string Login, int Attempts) 
        {
            InitializeComponent();        
            picture_1.AllowDrop = true;
            picture_2.AllowDrop = true;
            picture_3.AllowDrop = true;
            picture_4.AllowDrop = true;
            login = Login;
            attemps = Attempts;
        }

        // метод для перетаскиваемых PictureBox при зажатии кнопки мыши. Назначаются в событиях для вытаскиваемых PictureBox
        private void image_MouseDown(object sender, MouseEventArgs e)
        {
            //var pictureBox = (PictureBox)sender; // сохранение перетаскиваемого объекта в переменной
            // захват элемента для переноса. В первом аргументе сам объект, а во втором что перетаскиваем (т.к. элемент то Move)
            pictureBox3.DoDragDrop((PictureBox)sender, DragDropEffects.Move); 
        }

        // Событие при перетаскивании объекта мышью при ходе в объект. Присваивается элементу каптчи куда надо перенести картинку
        private void image_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureBox))) // проверка, есть ли в данных объект типа pictureBox 
                e.Effect = DragDropEffects.Move; // Присваиваем визуальный эффект для переноса
        }

        // Событие при отпуске мыши в элементе, куда нужно вставить PictureBox
        private void image_DragDrop(object sender, DragEventArgs e) 
        {
            // сохранение перетаскиваемого элемента из данных и получение
            PictureBox sourcePictureBox = e.Data.GetData(typeof(PictureBox)) as PictureBox;   
            PictureBox targetPictureBox = (PictureBox)sender;
            // присваивание необходимых атрибутов для пустой ячейки
            targetPictureBox.Image = sourcePictureBox.Image;
            targetPictureBox.Tag = sourcePictureBox.Tag;
        }

        //Обработчик события прохождения каптчи
        private void SendCaptcha_Click(object sender, EventArgs e)
        {
            if (attemps <= 0) // при недостатке попыток закрытие формы
            {
                MessageBox.Show("Вы заблокированы! Обратитесь к администратору!");
                DialogResult = DialogResult.Cancel;
                return;
            }

            using (MySqlConnection connect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=mydb"))
            {
                connect.Open();
                //сортировка элементов каптчи по порядку
                List<PictureBox> elements = tableLayoutPanel1.Controls.Cast<PictureBox>().
                OrderBy(c => tableLayoutPanel1.GetRow(c)).
                ThenBy(c => tableLayoutPanel2.GetColumn(c)).ToList();

                //команда для изменения количества попыток в БД
                MySqlCommand adapter = new MySqlCommand($"UPDATE mydb.users SET Captcha_attempts = Captcha_attempts - 1 WHERE Login = '{login}';", connect);

                //Цикл для проверки элементов каптчи
                for (int i = 0; i < 4; i++)
                {                    
                    try // обработка исключения для незаполненных элементов каптчи
                    {
                        if (elements[i].Tag.ToString() != tags[i]) // проверка по тегу элемента
                        {
                            adapter.ExecuteNonQuery(); // выполнение UPDATE запроса
                            --attemps; 
                            MessageBox.Show($"Капча собрана неверно! Осталось попыток: {attemps}");
                            return;
                        }
                    }
                    catch // Если не заполнили элемент/ы
                    {
                        MessageBox.Show("Заполните каптчу корректно!");
                        return;
                    }
                }
            }

            //При совпадении всех тегов в каптче
            MessageBox.Show("Вы успешно прошли каптчу!");
            DialogResult = DialogResult.OK;                    
        }
    }
}