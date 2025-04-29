using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Commom.new_model
{
  public class Basket
  {
    public int pid { get; set; }
    public string pname { get; set; }
    public int totalprice { get; set; }
    public int pprice { get; set; }
    public int qty { get; set; }
    public string? ppic { get; set; }
    public string? pdesc { get; set; }
  }
}
