using JuniorCodeTest.Interfaces;
using JuniorCodeTest.Models;

using System.Text.Json;

namespace JuniorCodeTest.Services
{
    public class RandomUserApiService : IRandomUserApiService
    {
        private const string randomUserEndPoint = "https://randomuser.me/api";
        private readonly HttpClient _httpClient;

        public RandomUserApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<RequestedUsersModel>> GetRandomUserDataFromApi()
        {
            var requiredDataList = new List<RequestedUsersModel>();
            var response = await _httpClient.GetAsync($"{randomUserEndPoint}?results=5");

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                var randomUserModelData = JsonSerializer.Deserialize<UserModel>(responseData);

                if (randomUserModelData != null && randomUserModelData.results != null)
                {
                    foreach (var randomUser in randomUserModelData.results)
                    {
                        var requiredData = new RequestedUsersModel()
                        {
                            Age = randomUser.dob.age,
                            First = randomUser.name.first,
                            Last = randomUser.name.last,
                            Title = randomUser.name.title,
                            Latitude = randomUser.location.coordinates.latitude,
                            Longitude = randomUser.location.coordinates.longitude,
                            Country = randomUser.location.country
                        };

                        requiredDataList.Add(requiredData);

                        if (requiredDataList.Count >= 5)
                        {
                            break;
                        }
                    }
                }

                return requiredDataList;
            }
            else
            {
                throw new Exception("Failed to fetch data from the random user API");
            }
        }
    }
}
