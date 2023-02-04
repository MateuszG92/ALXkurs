using HttpClientShowcase;

//var jsonStrings = serializationDemo.RunSerialization();
//serializationDemo.RunDeserialization(jsonStrings);
var client=new HttpClient();
var httpClientDemo = new HttpClientDemo(client);
//var hello = await httpClientDemo.Hello("Mateusz");
//Console.WriteLine(hello);
//await httpClientDemo.GetRandomJoke();
//await httpClientDemo.GetRandomCatInfo();
//await httpClientDemo.GetRandomDogImage();
await httpClientDemo.PredictGender("Mateusz"); 