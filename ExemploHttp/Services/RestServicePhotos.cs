using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using ExemploHttp.Models;
using System.Diagnostics;
using System.Text.Json;
using System.Collections.ObjectModel;
namespace ExemploHttp.Services
{
    public class RestServicePhotos
    {
        private HttpClient client;
        private Photo photos;
        private ObservableCollection<Photo> photo;
        private JsonSerializerOptions serializerOptions;
        public RestServicePhotos()
        {
            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

        }

        public async Task<ObservableCollection<Photo>> getPhotosAsync()
        {

            Uri uri = new Uri("https://jsonplaceholder.typicode.com/photos");
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    photo = JsonSerializer.Deserialize<ObservableCollection<Photo>>(content, serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return photo;
        }


    }


}