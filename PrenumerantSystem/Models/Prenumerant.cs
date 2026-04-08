using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tbl_prenumeranter")]
public class Prenumerant
{
    [Key]
    [Column("pre_id")]
    public int Id { get; set; }

    [Column("pre_prenumerantnummer")]
    [Required]
    public int Prenumerantnummer { get; set; }

    [Column("pre_personnummer")]
    [Required, MaxLength(13)]
    public string Personnummer { get; set; } = string.Empty;

    [Column("pre_fornamn")]
    [Required, MaxLength(100)]
    public string Fornamn { get; set; } = string.Empty;

    [Column("pre_efternamn")]
    [Required, MaxLength(100)]
    public string Efternamn { get; set; } = string.Empty;

    [Column("pre_utdelningsadress")]
    [Required, MaxLength(200)]
    public string Utdelningsadress { get; set; } = string.Empty;

    [Column("pre_postnummer")]
    [Required, MaxLength(10)]
    public string Postnummer { get; set; } = string.Empty;

    [Column("pre_ort")]
    [Required, MaxLength(100)]
    public string Ort { get; set; } = string.Empty;

    [Column("pre_telefonnummer")]
    [MaxLength(20)]
    public string? Telefonnummer { get; set; }
}