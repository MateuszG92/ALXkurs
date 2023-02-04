using HttpClientShowcase.Interfaces;
using HttpClientShowcase.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientShowcase
{
    public class HttpClientDemo:IHttpClientDemo
    {
        private readonly HttpClient _httpClient;
        private const string OutputFolder = @"C:\praca";
        public HttpClientDemo(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<string> Hello(string name)
        {
            return $"Hello {name}";
        }

        public async Task GetRandomJoke()
        {
            var requestUri = "https://official-joke-api.appspot.com/random_joke";
            var response = await _httpClient.GetAsync(requestUri);
            var responseJson = await response.Content.ReadAsStringAsync();
            var joke = JsonConvert.DeserializeObject<JokeResponse>(responseJson);
            Console.WriteLine($"Joke for today:\n{joke.Setup}\n-> {joke.Punchline}\n");
        }

        public async Task GetRandomCatInfo()
        {
            var requestUri = "https://catfact.ninja/fact";
            var response = await _httpClient.GetAsync(requestUri);
            var responseJson = await response.Content.ReadAsStringAsync();
            var catFact = JsonConvert.DeserializeObject<CatFact>(responseJson);
            Console.WriteLine($"Cat fact fo today:\n{catFact.Fact}\nFact length: {catFact.Length}\n");
        }

        public async Task GetRandomDogImage()
        {
            var requestUri = "https://dog.ceo/api/breeds/image/random";
            var response = await _httpClient.GetAsync(requestUri);
            var responseContentJson  = await response.Content.ReadAsStringAsync();
            var dogImage = JsonConvert.DeserializeObject<GetDogImage>(responseContentJson);
            try
            {
                SaveImage(dogImage.Message, "something");
                Process.Start("explorer.exe", OutputFolder);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task PredictGender(string name)
        {
            var baseRequestUri = "https://api.genderize.io/";
            var uriBuilder = new UriBuilder(baseRequestUri);
            uriBuilder.Query = $"name={name}";
            var uri = uriBuilder.Uri;
            var response = await _httpClient.GetAsync(uri);
            var responseContentJson = await response.Content.ReadAsStringAsync();
            var genderPrediction = JsonConvert.DeserializeObject<GenderPrediction>(responseContentJson);
            Console.WriteLine($"Name: {genderPrediction.Name} \nGender: {genderPrediction.Gender}\nProbability: {genderPrediction.Probability*100}%");
        }

        public async Task SendEmail(Email email)
        {
            
        }

        private void SaveImage(string imageUri, string fileName)
        {
            using(WebClient webClient=new WebClient())
            {
                var stream = webClient.OpenRead(imageUri);
                var bitmap = new Bitmap(stream);
                if (bitmap != null)
                    bitmap.Save($"{OutputFolder}\\{fileName}.png", ImageFormat.Png);
            }
        }
    }
}
