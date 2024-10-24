using System.ComponentModel.DataAnnotations;

namespace JSB.NET_Filrteration_Task.Models;


    public class Product
    {
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Description is required.")]
    public string Description { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Price must be non-negative.")]
    public decimal Price { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Stock must be non-negative.")]
    public int Stock { get; set; }

    public List<OrderProduct> OrderProducts { get; set; }
}

