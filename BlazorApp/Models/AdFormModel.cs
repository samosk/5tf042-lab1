using System.ComponentModel.DataAnnotations;

public class AdFormModel
{
    [Required(ErrorMessage = "Rubrik krävs")]
    public string Rubrik { get; set; } = string.Empty;

    [Required(ErrorMessage = "Innehåll krävs")]
    public string Innehall { get; set; } = string.Empty;

    [Required(ErrorMessage = "Varupris krävs")]
    [Range(0, double.MaxValue, ErrorMessage = "Varupris måste vara positivt")]
    public decimal Varupris { get; set; }
}