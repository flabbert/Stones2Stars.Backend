using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stones2Stars.Backend.Definitions.Plots;
public class BonusInfo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Id { get; set; } = "IRON";
    public string Name { get; set; } = "Iron Deposit";
    public List<IPlotModification> Requirements { get; set; } = [];
}
