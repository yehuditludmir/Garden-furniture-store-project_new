using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository.Classes
{
  public  class Buy_Details
  {
    public int Id { get; set; }
    
    public int BuyId { get; set; }

    public int ProductId { get; set; }

    public int Amount { get; set; }

    public virtual Buy Buy { get; set; } 
    public virtual Product Product { get; set; }
  }
}
