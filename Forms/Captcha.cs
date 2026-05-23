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
        string login;
        int attemps;

        List<string> tags = new List<string>(){"picture_1", "picture_2", "picture_3", "picture_4"};

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

        private void image_DragEnter(object sender, DragEventArgs e) 
        {
            if (e.Data.GetDataPresent(typeof(PictureBox)))
                e.Effect = DragDropEffects.Move;
        }

        private void image_MouseDown(object sender, MouseEventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            pictureBox3.DoDragDrop((PictureBox)sender, DragDropEffects.Move);
        }

        private void image_DragDrop(object sender, DragEventArgs e) 
        {
            PictureBox sourcePictureBox = e.Data.GetData(typeof(PictureBox)) as PictureBox;
            PictureBox targetPictureBox = (PictureBox)sender;          
            targetPictureBox.Image = sourcePictureBox.Image;
            targetPictureBox.Tag = sourcePictureBox.Tag;
        }

        private void SendCaptcha_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=mydb"))
            {
                connect.Open();
                List<PictureBox> elements = tableLayoutPanel1.Controls.Cast<PictureBox>().
                OrderBy(c => tableLayoutPanel1.GetRow(c)).
                ThenBy(c => tableLayoutPanel2.GetColumn(c)).ToList();

                MySqlCommand adapter = new MySqlCommand($"UPDATE mydb.users SET Captcha_attempts = Captcha_attempts - 1 WHERE Login = '{login}';", connect);

                for (int i = 0; i < 4; i++)
                {
                    if (attemps <= 0)
                    {
                        MessageBox.Show("Вы заблокированы! Обратитесь к администратору!");
                        DialogResult = DialogResult.Cancel;
                        return;
                    }

                    try
                    {
                        if (elements[i].Tag.ToString() != tags[i])
                        {
                            adapter.ExecuteNonQuery();
                            --attemps;
                            MessageBox.Show($"Капча собрана неверно! Осталось попыток: {attemps}");
                            return;
                        }
                }
                    catch
                    {
                        MessageBox.Show("Заполните каптчу корректно!");
                        return;
                    }
            }
        }
            
            MessageBox.Show("Вы успешно прошли каптчу!");

            DialogResult = DialogResult.OK;
                        
            Close();
        }
    }
}