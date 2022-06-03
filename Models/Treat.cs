using Pierre.Models;
using System.Collections.Generic;

namespace Pierre.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<Pierre>();
    }
    public int TreatId { get; set; }
    public string Name { get; set;}
    public string Origin { get; set; }
    public string Ingredients { get; set; }
    
    public int Price{ get; set;}
    public string AllergyInfo { get; set; }
    // public virtual ApplicationUser User { get; set;}
    
    public virtual ICollection<Pierre> JoinEntities { get; set; }

  }
}