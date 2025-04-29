using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository.Classes
{
  public class Company
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Product> Buy_Details { get; set; } = new List<Product>();
  }
}
