using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Cs390914_SD_3.Models
{
    public class Trainers
    {
        [Key]
        public int TrainerID { get; set; }
        public int GymID { get; set; }
        public string GymName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string AreaOfFocus { get; set; }
        public string Phone { get; set; }
       
        public DateTime TrainerSince { get; set; }
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<WorkoutDetails> WorkoutDetails { get; set; }
    }
}