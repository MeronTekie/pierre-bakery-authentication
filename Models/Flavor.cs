using Pierre.Models;
using System.Collections.Generic;

namespace Pierre.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<PierreBakery>();
    }
    public int FlavorId { get; set; }
    public string Type { get; set;}
    public virtual ApplicationUser User { get; set;}
    public virtual ICollection<PierreBakery> JoinEntities { get;}

  }
}