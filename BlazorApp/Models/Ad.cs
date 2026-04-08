using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tbl_ads")]
public class Ad
{
    [Key]
    [Column("ad_id")]
    public int Id { get; set; }

    [Column("ad_ann_id")]
    public int AnnonsorId { get; set; }

    [Column("ad_rubrik")]
    [Required, MaxLength(200)]
    public string Rubrik { get; set; } = string.Empty;

    [Column("ad_innehall")]
    [Required]
    public string Innehall { get; set; } = string.Empty;

    [Column("ad_varupris")]
    public decimal Varupris { get; set; }

    [Column("ad_annonspris")]
    public decimal Annonspris { get; set; }

    public Annonsor Annonsor { get; set; } = null!;
}