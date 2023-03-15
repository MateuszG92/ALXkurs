using Assigments;

var client = new HttpClient();
var httpClientDemo = new HttpClientDemo(client);
await httpClientDemo.GetSubjectToLearn();
Console.WriteLine("---------------------------------------------");
await httpClientDemo.GetMoonImage();
Console.WriteLine("---------------------------------------------");
await httpClientDemo.GetMonayInfo();

