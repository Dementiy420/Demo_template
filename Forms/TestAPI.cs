using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Demo_template.Forms
{
    public partial class TestAPI : Form
    {
        private HttpClient _httpClient;

        public TestAPI() {
            InitializeComponent();
        }

        //При загрузке формы (2 нажатия по самой форме) происходит подключение к API
        private void Form1_Load(object sender, EventArgs e)
        {
            _httpClient = new HttpClient() 
            {
                BaseAddress = new Uri("http://localhost:4444/TransferSimulator/")
            };
        }

        //Кнопка получения ФИО
        private async void Button1_Click(object sender, EventArgs e)
        {
            var responce = await _httpClient.GetAsync("fullName");
            var result = await responce.Content.ReadFromJsonAsync<Message>();

            label1.Text = result.value;
        }

        //Кнопка валидации ФИО
        private void Button2_Click(object sender, EventArgs e)
        {
            string value = label1.Text;

            if (Regex.IsMatch(value, @"[^а-яА-я \-]"))
            {
                label2.Text = "ФИО содержит запрещенные символы";
            }
            else
                label2.Text = "ФИО не содержит запрещенные символы";
        }
    }

    // класс - обертка для получения ФИО 
    class Message { public string value { get; set; } }
}