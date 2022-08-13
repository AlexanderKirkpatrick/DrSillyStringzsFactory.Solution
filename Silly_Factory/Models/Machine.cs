using System;
using System.Collections.Generic;

namespace Silly_Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinMachineEngineer = new HashSet<MachineEngineer>();
      Status = False;
    }
    public int MachineId { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
    public virtual ICollection<MachineEngineer> JoinMachineEngineer { get;}
  }
}