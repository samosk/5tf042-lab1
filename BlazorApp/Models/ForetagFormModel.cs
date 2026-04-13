using System.ComponentModel.DataAnnotations;

public class ForetagFormModel
{
    [Required(ErrorMessage = "Företagsnamn krävs")]
    [MaxLength(200)]
    public string Namn { get; set; } = string.Empty;

    [Required(ErrorMessage = "Organisationsnummer krävs")]
    [MaxLength(20)]
    public string Organisationsnummer { get; set; } = string.Empty;

    [MaxLength(20)]
    public string? Telefonnummer { get; set; }

    [Required(ErrorMessage = "Utdelningsadress krävs")]
    [MaxLength(200)]
    public string Utdelningsadress { get; set; } = string.Empty;

    [Required(ErrorMessage = "Postnummer krävs")]
    [MaxLength(10)]
    public string Postnummer { get; set; } = string.Empty;

    [Required(ErrorMessage = "Ort krävs")]
    [MaxLength(100)]
    public string Ort { get; set; } = string.Empty;

    [Required(ErrorMessage = "Fakturaadress krävs")]
    [MaxLength(200)]
    public string FakturaAdress { get; set; } = string.Empty;

    [Required(ErrorMessage = "Fakturapostnummer krävs")]
    [MaxLength(10)]
    public string FakturaPostnummer { get; set; } = string.Empty;

    [Required(ErrorMessage = "Fakturaort krävs")]
    [MaxLength(100)]
    public string FakturaOrt { get; set; } = string.Empty;
}