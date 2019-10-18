using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Cs390914_SD_3.Models
{
    public class Workout
    {
        [Key]
        public int WorkoutID { get; set; }
        public DateTime TrainerTime { get; set; }
        public string TrainerName { get; set; }

        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        public ICollection<WorkoutDetails> workoutDetails { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int ClientID { get; set; }
        public virtual Clients Clients { get; set; }
    }
}