using System;
using System.Collections.Generic;

#nullable disable

namespace WinFormsProject.Models
{
    public partial class Wfrole
    {
        public Wfrole()
        {
            Wfusers = new HashSet<Wfuser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Wfuser> Wfusers { get; set; }
    }
}
