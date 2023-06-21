using e_net.Data.Base;
using NSwag.Annotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace e_net.Models
{
    public class Item: IEntityBase
    {
      [JsonIgnore]
      public int Id { get; set; }
      public string ImageUrl { get; set; }
      public string Name { get; set; }
      public int Quantity { get; set; }
      public float Price { get; set; }    
    }
}
