using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LojinhaServer.Collections;

[Table("products")]
[BsonIgnoreExtraElements]
public class Product
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id;

    [BsonElement("name")]
    [JsonPropertyName("Nome")]
    public string Name { get; set; }

    [BsonElement("description")]
    [JsonPropertyName("Descrição")]
    public string Description { get; set; }

    [BsonElement("price")]
    [JsonPropertyName("Preço")]
    public decimal Price { get; set; }


    [BsonElement("offPrice")]
    [JsonPropertyName("Preço Promocional")]
    public decimal OffPrice { get; set; }


    [BsonElement("categories")]
    [JsonPropertyName("Categorias")]
    public List<string> Categories { get; set; }

    [BsonElement("tags")]
    public List<string> Tags { get; set; }

    [BsonElement("brand")]
    [JsonPropertyName("Marca")]
    public string Brand { get; set; }
}
