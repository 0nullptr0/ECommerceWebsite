using System.ComponentModel.DataAnnotations;

namespace BiankaApp.Models;

public class Item
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter a name for the item.")]
    [StringLength(100, ErrorMessage = "The name must be at least {2} and at most {1} characters long.", MinimumLength = 1)]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter a description for the item.")]
    [StringLength(500, ErrorMessage = "The description must be at least {2} and at most {1} characters long.", MinimumLength = 1)]
    public string Description { get; set; }

    [Required(ErrorMessage = "Please enter a price for the item.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "The price must be at least {1}.")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Please enter the number of items in stock.")]
    [Range(0, int.MaxValue, ErrorMessage = "The quantity must be at least {1}.")]
    public int Quantity { get; set; }

    [Required(ErrorMessage = "Please select a category for the item.")]
    public string Category { get; set; }

    public string ImageUrl { get; set; }
}
