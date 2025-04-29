using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Commom.new_model
{
  public class Buy
  {
    [Key]
    public int Id { get; set; }


    public DateTime DateOfBuy { get; set; }

    public int AmountPay { get; set; }

    

    public int UserId { get; set; }

    public string UserName { get; set; }

    public bool IsPay { get; set; }

    public string? Remark { get; set; }

    
  }
}
