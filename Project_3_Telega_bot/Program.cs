using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
namespace Project_3_Telega_bot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            var client = new TelegramBotClient("7629468270:AAH0i_OeUXJIepFKwDHHC9TcFvr24nB5oPs");
            client.StartReceiving(Update, Error);

            Console.ReadLine();
        }

        private static async Task Update(ITelegramBotClient client, Update update, CancellationToken token)
        {
            var message = update.Message;
            if (message.Text != null)
            {
                Console.WriteLine($"{message.Chat.FirstName} | {message.Text}");
                if (message.Text.ToLower().Contains("start"))
                {
                    await client.SendMessage(message.Chat.Id, "Hellow, choose your region: London, Kiev, Moscow, " +
                        "Washington, Paris, Mexico, Madrid, Rome, Berlin, Petersburg", cancellationToken: token);
                    return;
                }
            }
            if (message.Text != null)
            {
                if (message.Text.Contains("London"))
                {
                    string url = "https://api.openweathermap.org/data/2.5/weather?q=London&units=metric&appid=41c38b3aa394e19344f82ebd8e6b1ec7";
                    HttpWebRequest HttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse httpWebResponse = (HttpWebResponse)HttpWebRequest.GetResponse();
                    string response;
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        response = streamReader.ReadToEnd();
                    }
                    WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
                    await client.SendMessage(message.Chat.Id, $"Temperature in {weatherResponse.Name} is {weatherResponse.Main.Temp} °C", cancellationToken: token);
                    await client.SendMessage(message.Chat.Id, "Choose next.", cancellationToken: token);
                    await client.SendPhoto(message.Chat.Id, photo: "https://thegouldstandard.com/wp-content/uploads/2018/12/76709-640x360-houses-of-parliament-and-london-eye-on-thames-from-above-640.jpg", cancellationToken: token);
                    return;
                }
                if (message.Text.Contains("Kiev"))
                {
                    string url = "https://api.openweathermap.org/data/2.5/weather?q=Kiev&units=metric&appid=41c38b3aa394e19344f82ebd8e6b1ec7";
                    HttpWebRequest HttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse httpWebResponse = (HttpWebResponse)HttpWebRequest.GetResponse();
                    string response;
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        response = streamReader.ReadToEnd();
                    }
                    WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
                    await client.SendMessage(message.Chat.Id, $"Temperature in {weatherResponse.Name} is {weatherResponse.Main.Temp} °C", cancellationToken: token);
                    await client.SendMessage(message.Chat.Id, "Choose next.", cancellationToken: token);
                    await client.SendPhoto(message.Chat.Id, photo: "https://hubs.ua/wp-content/uploads/2020/10/kiev-header-640x360.jpg", cancellationToken: token);
                    return;
                }
                if (message.Text.Contains("Moscow"))
                {
                    string url = "https://api.openweathermap.org/data/2.5/weather?q=Moscow&units=metric&appid=41c38b3aa394e19344f82ebd8e6b1ec7";
                    HttpWebRequest HttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse httpWebResponse = (HttpWebResponse)HttpWebRequest.GetResponse();
                    string response;
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        response = streamReader.ReadToEnd();
                    }
                    WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
                    await client.SendMessage(message.Chat.Id, $"Temperature in {weatherResponse.Name} is {weatherResponse.Main.Temp} °C", cancellationToken: token);
                    await client.SendMessage(message.Chat.Id, "Choose next.", cancellationToken: token);
                    await client.SendPhoto(message.Chat.Id, photo: "https://cdn2.picryl.com/photo/2023/06/07/saint-basils-cathedral-and-the-red-square-6a35c2-640.jpg", cancellationToken: token);
                    return;
                }
                if (message.Text.Contains("Washington"))
                {
                    string url = "https://api.openweathermap.org/data/2.5/weather?q=Washington&units=metric&appid=41c38b3aa394e19344f82ebd8e6b1ec7";
                    HttpWebRequest HttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse httpWebResponse = (HttpWebResponse)HttpWebRequest.GetResponse();
                    string response;
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        response = streamReader.ReadToEnd();
                    }
                    WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
                    await client.SendMessage(message.Chat.Id, $"Temperature in {weatherResponse.Name} is {weatherResponse.Main.Temp} °C", cancellationToken: token);
                    await client.SendMessage(message.Chat.Id, "Choose next.", cancellationToken: token);
                    await client.SendPhoto(message.Chat.Id, photo: "https://ichef.bbci.co.uk/ace/ws/464/amz/worldservice/live/assets/images/2013/10/08/131008223605_sp_us_caiptol_washington_464x261_afp.jpg.webp", cancellationToken: token);
                    return;
                }
                if (message.Text.Contains("Paris"))
                {
                    string url = "https://api.openweathermap.org/data/2.5/weather?q=Paris&units=metric&appid=41c38b3aa394e19344f82ebd8e6b1ec7";
                    HttpWebRequest HttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse httpWebResponse = (HttpWebResponse)HttpWebRequest.GetResponse();
                    string response;
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        response = streamReader.ReadToEnd();
                    }
                    WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
                    await client.SendMessage(message.Chat.Id, $"Temperature in {weatherResponse.Name} is {weatherResponse.Main.Temp} °C", cancellationToken: token);
                    await client.SendMessage(message.Chat.Id, "Choose next.", cancellationToken: token);
                    await client.SendPhoto(message.Chat.Id, photo: "https://www.visitlondon.com/-/media/images/london/visit/things-to-do/sightseeing/sightseeing-tours/best-paris-tours/sunset-in-paris-640x360.jpg?h=360&w=640&rev=f9f8bf07792b42278ad1249332cfed5b&hash=99B5060D3F945341846746329BB2AB50", cancellationToken: token);
                    return;
                }
                if (message.Text.Contains("Mexico"))
                {
                    string url = "https://api.openweathermap.org/data/2.5/weather?q=Mexico&units=metric&appid=41c38b3aa394e19344f82ebd8e6b1ec7";
                    HttpWebRequest HttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse httpWebResponse = (HttpWebResponse)HttpWebRequest.GetResponse();
                    string response;
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        response = streamReader.ReadToEnd();
                    }
                    WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
                    await client.SendMessage(message.Chat.Id, $"Temperature in {weatherResponse.Name} is {weatherResponse.Main.Temp} °C", cancellationToken: token);
                    await client.SendMessage(message.Chat.Id, "Choose next.", cancellationToken: token);
                    await client.SendPhoto(message.Chat.Id, photo: "https://img-cdn.tnwcdn.com/image?fit=1280%2C720&url=https%3A%2F%2Fcdn0.tnwcdn.com%2Fwp-content%2Fblogs.dir%2F1%2Ffiles%2F2012%2F01%2Fmexico-by-schlaeger.jpg&signature=8cce7f6d97968f0d8b2bd7c7c9d4a5cf", cancellationToken: token);
                    return;
                }
                if (message.Text.Contains("Madrid"))
                {
                    string url = "https://api.openweathermap.org/data/2.5/weather?q=Madrid&units=metric&appid=41c38b3aa394e19344f82ebd8e6b1ec7";
                    HttpWebRequest HttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse httpWebResponse = (HttpWebResponse)HttpWebRequest.GetResponse();
                    string response;
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        response = streamReader.ReadToEnd();
                    }
                    WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
                    await client.SendMessage(message.Chat.Id, $"Temperature in {weatherResponse.Name} is {weatherResponse.Main.Temp} °C", cancellationToken: token);
                    await client.SendMessage(message.Chat.Id, "Choose next.", cancellationToken: token);
                    await client.SendPhoto(message.Chat.Id, photo: "https://upload.wikimedia.org/wikipedia/commons/2/23/One_wing%3F_%2818125407702%29.jpg", cancellationToken: token);
                    return;
                }
                if (message.Text.Contains("Rome"))
                {
                    string url = "https://api.openweathermap.org/data/2.5/weather?q=Rome&units=metric&appid=41c38b3aa394e19344f82ebd8e6b1ec7";
                    HttpWebRequest HttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse httpWebResponse = (HttpWebResponse)HttpWebRequest.GetResponse();
                    string response;
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        response = streamReader.ReadToEnd();
                    }
                    WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
                    await client.SendMessage(message.Chat.Id, $"Temperature in {weatherResponse.Name} is {weatherResponse.Main.Temp} °C", cancellationToken: token);
                    await client.SendMessage(message.Chat.Id, "Choose next.", cancellationToken: token);
                    await client.SendPhoto(message.Chat.Id, photo: "https://archaeology-travel.com/cdn-cgi/image/width=600,quality=90,format=auto,onerror=redirect,metadata=none/wp-content/uploads/2022/05/elementor/thumbs/roman-sites-rome-podjou9oo3uh6oasb77p09y7mzk5f1vwg9mg3g87ck.jpg", cancellationToken: token);
                    return;
                }
                if (message.Text.Contains("Berlin"))
                {
                    string url = "https://api.openweathermap.org/data/2.5/weather?q=Berlin&units=metric&appid=41c38b3aa394e19344f82ebd8e6b1ec7";
                    HttpWebRequest HttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse httpWebResponse = (HttpWebResponse)HttpWebRequest.GetResponse();
                    string response;
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        response = streamReader.ReadToEnd();
                    }
                    WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
                    await client.SendMessage(message.Chat.Id, $"Temperature in {weatherResponse.Name} is {weatherResponse.Main.Temp} °C", cancellationToken: token);
                    await client.SendMessage(message.Chat.Id, "Choose next.", cancellationToken: token);
                    await client.SendPhoto(message.Chat.Id, photo: "https://cdn.pixabay.com/photo/2012/07/01/08/35/architecture-51058_960_720.jpg", cancellationToken: token);
                    return;
                }
                if (message.Text.Contains("Petersburg"))
                {
                    string url = "https://api.openweathermap.org/data/2.5/weather?q=Petersburg&units=metric&appid=41c38b3aa394e19344f82ebd8e6b1ec7";
                    HttpWebRequest HttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse httpWebResponse = (HttpWebResponse)HttpWebRequest.GetResponse();
                    string response;
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        response = streamReader.ReadToEnd();
                    }
                    WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
                    await client.SendMessage(message.Chat.Id, $"Temperature in {weatherResponse.Name} is {weatherResponse.Main.Temp} °C", cancellationToken: token);
                    await client.SendMessage(message.Chat.Id, "Choose next.", cancellationToken: token);
                    await client.SendPhoto(message.Chat.Id, photo: "https://ichef.bbci.co.uk/images/ic/640x360/p02fpycc.jpg", cancellationToken: token);
                    return;
                }
            }
        }

        private static async Task Error(ITelegramBotClient client, Exception exception, HandleErrorSource source, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
