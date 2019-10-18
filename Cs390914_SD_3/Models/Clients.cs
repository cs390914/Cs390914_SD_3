using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Cs390914_SD_3.Models
{
    public class Clients
    {
        [Key]
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime ClientSince { get; set; }

        public ICollection<WorkoutDetails> WorkoutDetails { get; set; }
    }
}