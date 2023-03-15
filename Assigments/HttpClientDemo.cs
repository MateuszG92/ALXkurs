using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Net;
using Assigments.Models;

namespace Assigments
{
    public class HttpClientDemo
    {
        private readonly HttpClient _httpClient;
        private const string OutputFolder = @"C:\praca";

        public HttpClientDemo(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task GetSubjectToLearn()
        {
            var requestUri = "https://www.boredapi.com/api/activity";
            var response = await _httpClient.GetAsync(requestUri);
            var responseJson = await response.Content.ReadAsStringAsync();
            var subject = JsonConvert.DeserializeObject<LearningThings>(responseJson);
            Console.WriteLine($"Learning subject:\n{subject.Activity}\nType: {subject.Type}\nParticipants: {subject.Participants}\nPrice: {subject.Price}\nLink: {subject.Link}\nKey: {subject.Key}\nAccessibility: {subject.Accessibility}");
        }

        public async Task GetMonayInfo()
        {
            var requestUri = "https://api.coindesk.com/v1/bpi/currentprice.json";
            var response = await _httpClient.GetAsync(requestUri);
            var responseJson = await response.Content.ReadAsStringAsync();
            var usdInfo = JsonConvert.DeserializeObject<USD>(responseJson);
            var eurInfo = JsonConvert.DeserializeObject<EUR>(responseJson);
            var gbpInfo = JsonConvert.DeserializeObject<GBP>(responseJson);
            Console.WriteLine($"symbol:\n{usdInfo.Description}\nUSD rate float: {usdInfo.Rate_float}\n");
            Console.WriteLine($"symbol:\n{eurInfo.Description}\nUSD rate float: {eurInfo.Rate_float}\n");
            Console.WriteLine($"symbol:\n{gbpInfo.Description}\nUSD rate float: {gbpInfo.Rate_float}\n");
        }

        public async Task GetMoonImage()
        {
            var requestUri = "https://go-apod.herokuapp.com/apod";
            var response = await _httpClient.GetAsync(requestUri);
            var responseContentJson = await response.Content.ReadAsStringAsync();
            var moonImage = JsonConvert.DeserializeObject<Moon>(responseContentJson);
            try
            {
                SaveImage(moonImage.Url, moonImage.Title);
                Console.WriteLine(moonImage.Explanation);
                Process.Start("explorer.exe", OutputFolder);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void SaveImage(string imageUri, string fileName)
        {
            using (WebClient webClient = new WebClient())
            {
                var stream = webClient.OpenRead(imageUri);
                var bitmap = new Bitmap(stream);
                if (bitmap != null)
                    bitmap.Save($"{OutputFolder}\\{fileName}.png", ImageFormat.Png);
            }
        }
    }
}
