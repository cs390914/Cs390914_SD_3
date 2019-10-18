using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cs390914_SD_3.Models
{
    public class WorkoutDetails
    {
        public int WorkoutDetailsID { get; set; }
        public string WorkoutTitle { get; set; }
        public DateTime Duration { get; set; }
        public string EquipmentUsed { get; set; }
        // the next two properties link the WorkoutDetail to the WorkOut
        public int WorkoutID { get; set; }
        public virtual Workout Workout { get; set; }
        // the next two properties link the orderDetail to the Product
        public int TrainerID { get; set; }

        public virtual Trainers Trainers { get; set; }
    }
}