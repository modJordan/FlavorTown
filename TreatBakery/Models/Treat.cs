using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TreatBakery.Models
{
  public class Treat
  {
    public int TreatId {get; set;}
    [Required(ErrorMessage = "The Treats Name is required")]
    public string Name {get; set;}
    public string Description {get; set;}

    public List<TreatFlavor> JoinEntities {get;}

    public ApplicationUser User { get; set; }
  }
}