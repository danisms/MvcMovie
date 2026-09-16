using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    public string? Title { get; set; }

    [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true), Display(Name = "Release Date"), Required(ErrorMessage = "Release date is required"), Range(typeof(DateTime), "1/1/1900", "12/31/2026", ErrorMessage = "Release date must be between 1/1/1900 and 12/31/2026")]
    public DateTime ReleaseDate { get; set; }

    public string? Genre { get; set; }
    
    public decimal Price { get; set; }
}