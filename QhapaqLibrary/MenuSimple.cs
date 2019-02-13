using System;
using Newtonsoft.Json;

namespace QhapaqLibrary {
  public class MenuSimple {
    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("category_id")]
    public int CategoryId { get; set; }
    [JsonProperty("genre_id")]
    public int GenreId { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("description")]
    public string Description { get; set; }
    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }
  }
}
