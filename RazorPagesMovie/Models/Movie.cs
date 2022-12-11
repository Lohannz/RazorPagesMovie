using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models;

public class Movie
{
    public int Id { get; set; }

    // Title
    [StringLength(60, MinimumLength =2), Required]
    public string? Title { get; set; } = string.Empty;

    // Release
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]

    // Genre
    public string? Genre { get; set; } = string.Empty;

    // Price
    [DataType(DataType.Currency), Range(1,100), Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    // Rating
    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5)]
    [Required]
    public string Rating { get; set; } = string.Empty;
}