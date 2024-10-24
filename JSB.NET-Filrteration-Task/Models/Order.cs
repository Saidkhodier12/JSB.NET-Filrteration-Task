using System.Collections.Generic;
namespace JSB.NET_Filrteration_Task.Models;

public class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public List<OrderProduct> OrderProducts { get; set; }
}
