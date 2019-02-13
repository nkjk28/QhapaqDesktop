using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QhapaqLibrary {
  public class Qhapaq {
    public async static Task<GenreSimple[]> GetGenres() {
      return JsonConvert.DeserializeObject<GenreSimple[]>(await GetAsync("http://localhost:4567/genres"));
    }

    public async static Task<Menu[]> GetMenus(int genreId) {
      MenuSimple[] menuSimple = JsonConvert.DeserializeObject<MenuSimple[]>(await GetAsync("http://localhost:4567/genre/" + genreId.ToString()));
      Menu[] menus = new Menu[menuSimple.Length];
      for (int i = 0; i < menuSimple.Length; i++) {
        menus[i] = await GetMenu(menuSimple[i].Id);
      }
      return menus;
    }

    public async static Task<Menu> GetMenu(int menuId) {
      return JsonConvert.DeserializeObject<Menu>(await GetAsync("http://localhost:4567/menu/" + menuId.ToString()));
    }

    private static async Task<string> PostAsync(object obj, string url) {
      HttpClient client = new HttpClient();
      string requestJson = JsonConvert.SerializeObject(obj);
      HttpContent requestContent = new StringContent(requestJson, Encoding.UTF8, "application/json");
      HttpResponseMessage response = await client.PostAsync(url, requestContent);
      HttpContent responseContent = response.Content;
      string responseJson = await responseContent.ReadAsStringAsync();
      return responseJson;
    }

    private static async Task<string> GetAsync(string url) {
      HttpClient client = new HttpClient();
      HttpResponseMessage response = await client.GetAsync(url);
      HttpContent content = response.Content;
      string json = await content.ReadAsStringAsync();
      return json;
    }
  }
}
