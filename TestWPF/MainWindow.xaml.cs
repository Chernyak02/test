using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Test.Models;

namespace TestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string api = "https://localhost:7241/api/";
        public List<Tiptovara> List = new List<Tiptovara>();
        public MainWindow()
        {
            InitializeComponent();
            InitAsync();
        }
        private async Task InitAsync()
        {
            ListView.Items.Clear();

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(api + "tiptovars");
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            List = (List<Tiptovara>) JsonConvert.DeserializeObject(json, typeof(List<Tiptovara>));

            foreach (var listitem in List)
            {
                ListView.Items.Add(listitem.TipName);
            }

           
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            Tiptovara newModel = new Tiptovara
            {
                TiptovaraId = null,
                TipName = TextBox.Text
            };
            string json = JsonConvert.SerializeObject(newModel);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(api + "Tiptovars", content);
            InitAsync();
        }
    }
}
