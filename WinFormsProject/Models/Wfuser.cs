using System;
using System.Collections.Generic;

#nullable disable

namespace WinFormsProject.Models
{
    public partial class Wfuser
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public string UserName { get; set; }
        public  string Password { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public bool? Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public DateTime? CreateTime { get; set; }
        public bool Status { get; set; }
        public virtual Wfrole Role { get; set; }
    }
}
