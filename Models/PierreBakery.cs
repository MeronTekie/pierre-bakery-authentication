namespace Pierre.Models
{
  public class PierreBakery
  {
    public int PierreBakeryId { get; set; }
    public int  TreatId { get; set; }
    public int FlavorId { get; set; }
    public virtual Flavor Flavor { get; set; }
    public virtual Treat Treat { get; set; }
  }
}