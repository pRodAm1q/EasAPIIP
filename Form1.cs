using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.IO;
using Newtonsoft.Json;


namespace EzIPApi
{
    public partial class EasyIPmaster : Form
    {
        public EasyIPmaster()
        {
            InitializeComponent();
        }

        private void EasyIPmaster_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://spott.p.rapidapi.com/places/ip/"+ textBox1.Text),
                Headers =
    {
        { "x-rapidapi-host", "spott.p.rapidapi.com" },
        { "x-rapidapi-key", "8d477c3a60msh209f98ad40efe94p1fd16ajsn22799631e9cd" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                label1.Text = body;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://spott.p.rapidapi.com/places/ip/me"),
                Headers =
    {
        { "x-rapidapi-host", "spott.p.rapidapi.com" },
        { "x-rapidapi-key", "8d477c3a60msh209f98ad40efe94p1fd16ajsn22799631e9cd" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                MessageBox.Show(body);
            }
        }
    }
}