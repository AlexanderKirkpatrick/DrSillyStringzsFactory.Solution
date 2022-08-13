using System;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEngineerMachine = new HashSet<EngineerMachine>();
      Status = false;
    }
    public int MachineId { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
    public virtual ICollection<EngineerMachine> JoinEngineerMachine { get; set;}
  }
}