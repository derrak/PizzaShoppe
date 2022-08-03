using System.Collections.Generic;
using System;

namespace PizzaShoppe.Models
{
  public class Order
  {
    public Order()
    {
      this.JoinEntities = new HashSet<CustomerOrder>();
    }

    public int OrderId { get; set; }
    public DateTime Date { get; set; }

  public virtual ICollection<CustomerOrder> JoinEntities {get;}
  }
}