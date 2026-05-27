using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Demo_template.Forms
{
    public partial class TestAPI : Form
    {
        private HttpClient _httpClient = new HttpClient();

        public TestAPI() => InitializeComponent();        

        //Кнопка получения ФИО
        private async void Button1_Click(object sender, EventArgs e)
        {
            var responce = await _httpClient.GetAsync("http://localhost:4444/TransferSimulator/fullName");
            var result = await responce.Content.ReadFromJsonAsync<Message>();

            label1.Text = result.value;
        }

        //Кнопка валидации ФИО
        private void Button2_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(label1.Text, @"[^а-яА-я \-]"))
                label2.Text = "ФИО содержит запрещенные символы";
            else
                label2.Text = "ФИО не содержит запрещенные символы";
        }
    }

    // класс - обертка для получения ФИО 
    class Message { public string value { get; set; } }
}