using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Dal_Repository.Classes;

namespace Dal_Repository.Classes
{
  public class Buy
  {
    
    public int Id { get; set; }
    public DateTime DateOfBuy { get; set; }

    public int AmountPay { get; set; }

    

    public int UserId { get; set; }
    public bool IsPay { get; set; }


    public string? Remark { get; set; }
    public virtual User? User { get; set; }

    public virtual ICollection<Buy_Details> Buy_Details { get; set; } = new List<Buy_Details>();


  }
}
