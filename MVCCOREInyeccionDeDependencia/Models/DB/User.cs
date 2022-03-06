using System;
using System.Collections.Generic;

#nullable disable

namespace MVCCOREInyeccionDeDependencia.Models.DB
{
    public partial class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; set; }
    }
}
