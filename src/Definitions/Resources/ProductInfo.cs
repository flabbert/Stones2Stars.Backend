using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stones2Stars.Backend.Definitions.Resources;
public class ProductInfo : IResource
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Id { get; set; } = "IRON_ORE";
    public string Name { get; set; } = string.Empty;
    public string ProducedBy { get; set; } = string.Empty;
}
