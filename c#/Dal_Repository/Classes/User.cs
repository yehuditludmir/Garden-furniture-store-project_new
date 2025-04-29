using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository.Classes
{
  public class User
  {
    public int Id { get; set; }
    public string Name { get; set; }
    
    public string Email { get; set; }
    public DateTime Birthday { get; set; }

    public string? Phone { get; set; }
    public virtual ICollection<Buy> Buy { get; set; }=new List<Buy>();



  }
}
