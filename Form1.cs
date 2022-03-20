using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://spott.p.rapidapi.com/places/ip/{textBox1.Text}?language=%20ru"),
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
                    JObject json = JObject.Parse(body);
                    var Idvalue = json["id"];
                    var LocalContry = json["localizedName"];
                    var Division = json["adminDivision1"];
                    var Jdivision = Division["localizedName"];
                    var Coord = json["coordinates"];
                    var lati = Coord["latitude"];
                    var longy = Coord["longitude"];

                    //  Console.WriteLine(json);
                    MessageBox.Show($"ID: {Idvalue} \n Country: {LocalContry} \n Division: {Jdivision} \n Coordinates: \n  *latitude: {lati} \n  *longitube: {longy}");
                }
            } catch (Exception)
            {
                MessageBox.Show("Error"); 
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage

                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://spott.p.rapidapi.com/places/ip/me?language=%20ru"),
                    Headers =
    {
        { "x-rapidapi-host", "spott.p.rapidapi.com" },
        { "x-rapidapi-key", "8d477c3a60msh209f98ad40efe94p1fd16ajsn22799631e9cd" },
        { "Accept","application/json" },

    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(body);
                    var Idvalue = json["id"];
                    var LocalContry = json["localizedName"];
                    var Division = json["adminDivision1"];
                    var Jdivision = Division["localizedName"];
                    var Coord = json["coordinates"];
                    var lati = Coord["latitude"];
                    var longy = Coord["longitude"];

                    //  Console.WriteLine(json);
                    MessageBox.Show($"ID: {Idvalue} \n Country: {LocalContry} \n Division: {Jdivision} \n Coordinates: \n  *latitude: {lati} \n  *longitube: {longy}");


                }


            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Выполнил: \n студент группы 015 \n Мартьянов Владислав");
        }
    }
}