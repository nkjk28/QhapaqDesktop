using System;
using Newtonsoft.Json;

namespace QhapaqLibrary {
  public class Ingredient {
    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("menu_id")]
    public int MenuId { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("amount")]
    public int Quantity { get; set; }
    [JsonProperty("unit")]
    public string Unit { get; set; }
    [JsonProperty("cost")]
    public int Cost { get; set; }
    [JsonProperty("description")]
    public string Description { get; set; }
    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }
  }
}
