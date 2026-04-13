using System.ComponentModel.DataAnnotations;

public class PrenumerantDto
{
    public int Id { get; set; }
    public int Prenumerantnummer { get; set; }

    [Required(ErrorMessage = "Personnummer krävs")]
    [MaxLength(13)]
    public string Personnummer { get; set; } = string.Empty;

    [Required(ErrorMessage = "Förnamn krävs")]
    public string Fornamn { get; set; } = string.Empty;

    [Required(ErrorMessage = "Efternamn krävs")]
    public string Efternamn { get; set; } = string.Empty;

    [Required(ErrorMessage = "Adress krävs")]
    public string Utdelningsadress { get; set; } = string.Empty;

    [Required(ErrorMessage = "Postnummer krävs")]
    public string Postnummer { get; set; } = string.Empty;

    [Required(ErrorMessage = "Ort krävs")]
    public string Ort { get; set; } = string.Empty;

    public string? Telefonnummer { get; set; }
}