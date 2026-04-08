using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tbl_annonsorer")]
public class Annonsor
{
    [Key]
    [Column("ann_id")]
    public int Id { get; set; }

    [Column("ann_typ")]
    [Required, MaxLength(20)]
    public string Typ { get; set; } = string.Empty;

    [Column("ann_pre_id")]
    public int? PreId { get; set; }

    [Column("ann_namn")]
    [Required, MaxLength(200)]
    public string Namn { get; set; } = string.Empty;

    [Column("ann_organisationsnummer")]
    [MaxLength(20)]
    public string? Organisationsnummer { get; set; }

    [Column("ann_telefonnummer")]
    [MaxLength(20)]
    public string? Telefonnummer { get; set; }

    [Column("ann_utdelningsadress")]
    [Required, MaxLength(200)]
    public string Utdelningsadress { get; set; } = string.Empty;

    [Column("ann_postnummer")]
    [Required, MaxLength(10)]
    public string Postnummer { get; set; } = string.Empty;

    [Column("ann_ort")]
    [Required, MaxLength(100)]
    public string Ort { get; set; } = string.Empty;

    [Column("ann_fakt_adress")]
    [MaxLength(200)]
    public string? FakturaAdress { get; set; }

    [Column("ann_fakt_postnummer")]
    [MaxLength(10)]
    public string? FakturaPostnummer { get; set; }

    [Column("ann_fakt_ort")]
    [MaxLength(100)]
    public string? FakturaOrt { get; set; }

    public ICollection<Ad> Ads { get; set; } = new List<Ad>();
}