using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_template.Forms
{
    public partial class Captcha : Form
    {
        int attemps = 3;

        List<string> tags = new List<string>(){"picture_1", "picture_2", "picture_3", "picture_4"};

        public Captcha() 
        {
            InitializeComponent();        
            picture_1.AllowDrop = true;
            picture_2.AllowDrop = true;
            picture_3.AllowDrop = true;
            picture_4.AllowDrop = true;
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
            List<PictureBox> elements = tableLayoutPanel1.Controls.Cast<PictureBox>().
                OrderBy(c => tableLayoutPanel1.GetRow(c)).
                ThenBy(c => tableLayoutPanel2.GetColumn(c)).ToList();

            for (int i = 0; i < 4; i++)
            {
                if (attemps <= 0) 
                {
                    MessageBox.Show("Ты забанен");
                    //место для блокировки через БД
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }

                try
                {
                    if (elements[i].Tag.ToString() != tags[i])
                    {
                        --attemps;
                        MessageBox.Show($"Капча собрана неверно! Осталось попыток: {attemps}");
                        return;
                    }
                }
                catch {
                    MessageBox.Show("Вы не заполнили каптчу!");
                    return;
                }
            }
            MessageBox.Show("Вы успешно прошли каптчу!");
        }
    }
}