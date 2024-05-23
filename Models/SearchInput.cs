
using System.ComponentModel.DataAnnotations;

public class SearchInput
{
    [Required(ErrorMessage = "Text input is required.")]
    [StringLength(100, ErrorMessage = "Text input cannot exceed 100 characters.")]
    [MinLength(3,  ErrorMessage = "Text input must have minimum 3 characters.")]
    public string? SearchBarInput { get; set; }
}