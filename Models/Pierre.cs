namespace Pierre.Models
{
  public class Pierre
  {
    public int PierreId { get; set; }
    public int  TreatId { get; set; }
    public int FlavorId { get; set; }
    public virtual Flavor Flavor { get; set; }
    public virtual Treat Treat { get; set; }
  }
}