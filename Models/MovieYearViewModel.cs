using Microsoft.AspNetCore.Mvc.Rendering;
using MvcMovie.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MvcMovie.Models;

public class MovieYearViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }

    [YearRangeFrom1900ToCurrentYear]
    public int? MiniYear { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
}