using HttpClientShowcase;
using HttpClientShowcase.Models;

//var jsonStrings = serializationDemo.RunSerialization();
//serializationDemo.RunDeserialization(jsonStrings);
var client=new HttpClient();
var httpClientDemo = new HttpClientDemo(client);
//var hello = await httpClientDemo.Hello("Mateusz");
//Console.WriteLine(hello);
//await httpClientDemo.GetRandomJoke();
//await httpClientDemo.GetRandomCatInfo();
//await httpClientDemo.GetRandomDogImage();
//await httpClientDemo.PredictGender("Mateusz"); 
var email = new Email
{
    To = "mateuszg00@gmail.com",
    Subject = "Test",
    Message = "You're awesome"
}; 
await httpClientDemo.SendEmail(email);