using Demo_entity.Database;
using Demo_entity.Models;
using System.Data;

namespace Demo_template.Forms
{
    public partial class Captcha : Form
    {
        public string Role;

        private User user;
        private MydbContext context;
        //список тегов для определения правильной каптчи
        List<string> tags = new List<string>() { "picture_1", "picture_2", "picture_3", "picture_4" };

        // конструктор для передачи данных из формы "Логин" и разрешение на перетаскивание в pictureBox
        public Captcha(User user, MydbContext context)
        {
            InitializeComponent();
            picture_1.AllowDrop = true; // разрешение на перетаскивание для элементов каптчи
            picture_2.AllowDrop = true;
            picture_3.AllowDrop = true;
            picture_4.AllowDrop = true;
            this.user = user;
            this.context = context;

        }

        // метод для перетаскиваемых PictureBox при зажатии кнопки мыши. Назначаются в событиях для вытаскиваемых PictureBox
        private void image_MouseDown(object sender, MouseEventArgs e)
        {
            // захват элемента для переноса. В первом аргументе сам объект, а во втором что перетаскиваем (т.к. элемент то Move)
            ((PictureBox)sender).DoDragDrop((PictureBox)sender, DragDropEffects.Move);
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
            //сортировка элементов каптчи по порядку
            List<PictureBox> elements = tableLayoutPanel1.Controls.Cast<PictureBox>().
            OrderBy(c => tableLayoutPanel1.GetRow(c)).
            ThenBy(c => tableLayoutPanel2.GetColumn(c)).ToList();

            int rightImages = 0;

            try
            {
                if (user.CaptchaAttempts <= 0) // при недостатке попыток закрытие формы
                    throw new Exception("Вы заблокированы! обратитесь к администратору!");

                //Цикл для проверки элементов каптчи
                for (int i = 0; i < 4; i++)
                    if (elements[i].Tag.ToString() == tags[i]) // проверка по тегу элемента                    
                        rightImages += 1;

                if (rightImages != 4) 
                {
                    user.CaptchaAttempts -= 1;
                    throw new Exception($"Каптча заполнена неверно!\nПопыток осталось: {user.CaptchaAttempts}");
                }

                //При совпадении всех тегов в каптче
                Role = user.Role;
                MessageBox.Show("Вы успешно прошли каптчу!");
                DialogResult = DialogResult.OK;
            }
            catch (NullReferenceException) 
            {
                MessageBox.Show($"Каптча заполнена не полностью!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.None;
                return;
            }
            catch (Exception ex)
            {
                context.SaveChanges();
                MessageBox.Show(ex.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.None;
                return;
            }
        }
    }
}